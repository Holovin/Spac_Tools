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

        public string Link => "";

        public Dictionary<string, int> Requires => new Dictionary<string, int>() {
            {"core", 1}
        };

        public string Description => "Demo project for demonstration";

        private PluginGUI app;

        public void Run(params object[] o) {          
            app = new PluginGUI(Convert.ToString(o[1]));
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
