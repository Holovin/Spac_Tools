using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DSpacesTools {
    public class Core {
        public static int Version { get; } = 1;

        public PluginContainer PluginContainer;

        private readonly List<string> basePluginsList =
        new List<string>  {
            "IPlugin.dll",
            "DNetwork.dll",
            "DSpacesAPI.dll"
        };

        public static string GetCurrentPath() {
            return Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        }

        public Core() {
            CheckBasePlugins();

            PluginContainer = new PluginContainer();
            PluginContainer.Load();
        }

        private string CheckBasePlugins() {
            // https://msdn.microsoft.com/en-us/library/ms173100.aspx
            var current = GetCurrentPath();

            try {
                foreach (var testAssembly in basePluginsList.Select(plugin => AssemblyName.GetAssemblyName(Path.Combine(current, plugin)))) {
                }
            }
            catch (Exception e) {
                throw;
            }

            return string.Empty;
        }
    }
}
