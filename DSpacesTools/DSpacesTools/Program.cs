using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using DNetwork;
using DSpacesTools.Properties;

namespace DSpacesTools {
    public static class Program {
        private static PluginContainer pluginContainer;
        private static SessionManager sessionManager;
        private static Network network;

        [STAThread]
        static void Main() {
            pluginContainer = new PluginContainer();

            var result = pluginContainer.CheckBasePlugins();
            if (!result.GetSuccess()) {
                result.ShowError();
                return;
            }

            pluginContainer.Load();

            sessionManager = new SessionManager();
            network = new Network();

            //try {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FormApp(ref network, ref pluginContainer, ref sessionManager));
            //}
            //catch (Exception e) {
                //MessageBox.Show(Resources.ErrorCriticalGlobalMessage + '\n' + e.Message, Resources.ErrorCriticalGlobalHeader);
            //}            
        }
    }
}
