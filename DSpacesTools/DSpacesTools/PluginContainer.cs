using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using IPlugin;

namespace DSpacesTools {
    public class PluginContainer {
        [ImportMany(typeof(ISpacesPlugin))]
        public List<ISpacesPlugin> Plugins { get; set; }

        // TODO: add subDir support
        public int Load(string subDir = "") {
            var catalog = new AggregateCatalog();

            // TODO: fix warn
            catalog.Catalogs.Add(new DirectoryCatalog(Path.GetDirectoryName(new Uri(Assembly.GetExecutingAssembly().CodeBase).LocalPath)));
            var container = new CompositionContainer(catalog);

            //container.ComposeParts(this);
            container.SatisfyImportsOnce(this);

            return Plugins.Count;
        }

    }
}
