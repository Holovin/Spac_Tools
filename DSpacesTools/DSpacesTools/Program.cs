using System;
using System.Windows.Forms;
using DNetwork;
using DSpacesTools.Properties;
using SharedComponents;

namespace DSpacesTools {
    public static class Program {
        private static PluginContainer _pluginContainer;
        private static SessionManager _sessionManager;
        private static Network _network;

        [STAThread]
        private static void Main() {
            _pluginContainer = new PluginContainer();

            var result = _pluginContainer.CheckBasePlugins();
            if (!result.GetSuccess()) {
                result.ShowError();
                return;
            }

            _pluginContainer.Load();

            _sessionManager = new SessionManager();
            _network = new Network();

            try {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FormApp(ref _network, ref _pluginContainer, ref _sessionManager));
            }
            catch (Exception e) {
                // ReSharper disable once LocalizableElement
                MessageBox.Show(Resources.ErrorCriticalGlobalMessage + "\n\n" + e.Source + @" @ " + e.Message, Resources.ErrorCriticalGlobalHeader);
            }            
        }
    }
}
