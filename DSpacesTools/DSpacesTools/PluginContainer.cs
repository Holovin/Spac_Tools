using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.IO;
using System.Linq;
using SharedComponents;
using System.Reflection;

namespace DSpacesTools {
    public class PluginContainer: IBasePlugin {
        public string Name => "PluginContainer";
        public string InnerName => "core.pc";
        public int Version => 1;
        public string Author => "DJ_miXxXer";
        public string Link => "http://dj_mixxxer.spaces.ru";
        public string Description => "Inner plugin conatiner component.";

        private readonly List<string> _basePluginsList =
        new List<string>  {
            "IPlugin.dll",
            "DNetwork.dll",
            "DSpacesAPI.dll"
        };

        [ImportMany(typeof(ISpacesPlugin))]
        // ReSharper disable once UnusedAutoPropertyAccessor.Local
        public List<ISpacesPlugin> Plugins { get; private set; }

        private readonly Dictionary<string, int> _activePlugins;

        public PluginContainer() {
            _activePlugins = new Dictionary<string, int>();
        }

        public Message CheckBasePlugins() {
            return CheckBasePluginsThrow()
                ? new Message(MessageType.Success, Success.Default)
                : new Message(MessageType.Error, Error.CorePlguinCheckErr);
        }

        // TODO: add subDir support
        public int Load(string subDir = "") {
            var catalog = new AggregateCatalog();

            // TODO: fix warn
            catalog.Catalogs.Add(new DirectoryCatalog(GetCurrentPath()));
            var container = new CompositionContainer(catalog);

            try {
                container.SatisfyImportsOnce(this);
            }
            catch (ReflectionTypeLoadException ex) {            
                foreach (var inner in ex.LoaderExceptions) {
                    // http://stackoverflow.com/questions/6086633/get-types-in-assembly-error-system-reflection-reflectiontypeloadexception
                    // TODO: its only for debug
                    throw new Exception(inner.Message);
                }
            }

            return Plugins.Count;
        }

        public static string GetCurrentPath() {
            return Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        }
        
        public void ActivePluginsListAdd(string pluginInnerName, int currentVersion) {
            _activePlugins.Add(pluginInnerName, currentVersion);
        }

        public bool CheckDependency(int id) {
            foreach (var req in Plugins[id].Requires) {
                var usedVersion = 0;
                if (!_activePlugins.TryGetValue(req.Key, out usedVersion)) {
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
            return Plugins[id].Requires;
        }

        public void AddRequirePlugin(IBasePlugin plugin) {
            ActivePluginsListAdd(plugin.InnerName, plugin.Version);
        }


        private void RequireListClear() {
            _activePlugins.Clear();
        }

        private bool CheckBasePluginsThrow() {
            // https://msdn.microsoft.com/en-us/library/ms173100.aspx
            var current = GetCurrentPath();

            try {
                // ReSharper disable once UnusedVariable
                foreach (var testAssembly in _basePluginsList.Select(plugin => AssemblyName.GetAssemblyName(Path.Combine(current, plugin)))) {
                    // TODO: add name check
                }
                
                // ReSharper disable once RedundantCatchClause
            } catch (Exception) {
                // TODO: better way?
                // if file with filename is wrong assembly
                return false;
            }

            return true;
        }
    }
}
