using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
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

        public string Description => "Demo project for demonstration";

        public Dictionary<string, List<int>> Requires => new Dictionary<string, List<int>>() {
            {"[reserved]", new List<int>() {1, 0} },
        };
      
        private PluginGui _app;
                  
        public void Run(Form parent, EventHandler formCloseEvent, params object[] o) {
            _app = new PluginGui("Test", formCloseEvent) {                
                StartPosition = FormStartPosition.CenterScreen
            };
                       
            _app.Show();
        }

        public bool RefreshData(params object[] o) {
            // TODO: ?
            throw new NotImplementedException();            
        }

        public void Stop(bool hardExit = false) {
            _app.Close();
        }
    }
}
