using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IPlugin;

namespace DPluginDemo
{   
    [Export(typeof(ISpacesPlugin))]
    public class PluginDemo: ISpacesPlugin
    {
        public string Name => "Plugin Demo";

        public string InnerName => "plugindemo";

        public int Version => 1;

        public string Author => "DJ_miXxXer";

        public string Link => "http://spaces.ru/mysite/?name=DJ_miXxXer";

        public Dictionary<string, List<int>> Requires => new Dictionary<string, List<int>>() {
            {"base.core", new List<int>() {1, 0} },
            {"base.network", new List<int>() {1, 0}},
            {"base.api", new List<int>() {1, 0}}
        };

        public string Description => "Demo project for demonstration";

        private PluginGUI app;

        public void Run(params object[] o) {          
            app = new PluginGUI("Test");
            app.Show((Form)o[0]);
        }

        public bool RefreshData(params object[] o) {
            // TODO: ?
            throw new NotImplementedException();            
        }

        public void Stop(bool hardExit = false) {
            app.Close();
        }
    }
}
