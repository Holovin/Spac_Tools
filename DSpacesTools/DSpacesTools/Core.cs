using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DNetwork;
using DSpacesAPI;
using IPlugin;

namespace DSpacesTools {
    public class Core : IBasePlugin {
        public string Name => "iSpacesCore";
        public string InnerName => "base.core";
        public int Version => 1;
        public string Author => "DJ_miXxXer";
        public string Link => "http://spaces.ru";
        public string Description => "";
        
        public PluginContainer PluginContainer { get; }
        public SessionManager SessionManager { get; }
        public Network Network { get; }

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
            SessionManager = new SessionManager();
            Network = new Network();
        }

        public bool Load() {
            PluginContainer.RequireListAdd(Network.InnerName, Network.Version);
            //PluginContainer.RequireListAdd(SpacesApi.InnerName, SpacesApi.Version);
            PluginContainer.RequireListAdd(this.InnerName, this.Version);

            return PluginContainer.Load() > 0;
        }

        private string CheckBasePlugins() {
            // https://msdn.microsoft.com/en-us/library/ms173100.aspx
            var current = GetCurrentPath();

            try {
                foreach (var testAssembly in basePluginsList.Select(plugin => AssemblyName.GetAssemblyName(Path.Combine(current, plugin)))) {
                }
            }
            catch (Exception) {
                throw;
            }

            return string.Empty;
        }
    }
}
