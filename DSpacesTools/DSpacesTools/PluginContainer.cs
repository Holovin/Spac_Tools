using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DNetwork;
using DSpacesAPI;
using IPlugin;

namespace DSpacesTools {
    public class PluginContainer {
        [ImportMany(typeof(ISpacesPlugin))]
        public List<ISpacesPlugin> Plugins { get; set; }

        private Dictionary<string, int> requireDictionary;

        public PluginContainer() {
            requireDictionary = new Dictionary<string, int>();
        }

        // TODO: add subDir support
        public int Load(string subDir = "") {
            var catalog = new AggregateCatalog();

            // TODO: fix warn
            catalog.Catalogs.Add(new DirectoryCatalog(Path.GetDirectoryName(new Uri(Assembly.GetExecutingAssembly().CodeBase).LocalPath)));
            var container = new CompositionContainer(catalog);

            //container.ComposeParts(this);
            container.SatisfyImportsOnce(this);

            RequireListClear();

            return Plugins.Count;
        }

        private void RequireListClear() {
            requireDictionary.Clear();
        }

        public void RequireListAdd(string pluginInnerName, int currentVersion) {
            requireDictionary.Add(pluginInnerName, currentVersion);
        }

        public bool CheckDependency(int id) {
            foreach (var req in Program.AppCore.PluginContainer.Plugins[id].Requires) {
                var usedVersion = 0;
                if (!requireDictionary.TryGetValue(req.Key, out usedVersion)) {
                    continue;
                }

                var minVersion = req.Value[0];
                var maxVersion = req.Value[1] == 0 ? int.MaxValue : req.Value[1];

                if (minVersion > usedVersion || usedVersion > maxVersion) {
                    return false;
                }
            }
            return true;
        }

        public Dictionary<string, List<int>> GetCompabilityList(int id) {
            return Program.AppCore.PluginContainer.Plugins[id].Requires;
        }
    }
}
