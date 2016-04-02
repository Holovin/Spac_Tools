using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using DNetwork;
using DSpacesAPI;
using DSpacesTools.Properties;
using SharedComponents;

namespace DSpacesTools {
    public partial class FormApp : Form {
        private Network _network;
        private readonly PluginContainer _pluginContainer;
        private SessionManager _sessionManager;

        public FormApp(ref Network network, ref PluginContainer pluginContainer, ref SessionManager sessionManager) {
            InitializeComponent();

            _network = network;
            _pluginContainer = pluginContainer;
            _sessionManager = sessionManager;
        }

        private void App_Load(object sender, EventArgs e) {
            // Localizing
            Text = Resources.ApplicationName;
            LabelPluginLink.Text = Resources.PluginAuthorLink;

            // List binding
            ListBoxPlugins.DisplayMember = "Value";
            ListBoxPlugins.ValueMember = "Key";

            RefreshPluginList();
        }

        private void RefreshPluginList() {
            _pluginContainer.Load();

            ListBoxPlugins.Items.Clear();
            foreach (var plugin in _pluginContainer.Plugins) {
                ListBoxPlugins.Items.Add(new KeyValuePair<string, string>(plugin.InnerName, plugin.Name));
            }

            ListBoxPlugins.SelectedIndex = 0;
        }

        private void LoadPlugin(int id) {
            LabelPluginName.Text = _pluginContainer.Plugins[id].Name;
            LabelPluginAuthor.Text = _pluginContainer.Plugins[id].Author;
            LabelPluginLink.Links.Clear();
            LabelPluginLink.Links.Add(new LinkLabel.Link() {
                LinkData = _pluginContainer.Plugins[id].Link                
            });
            LabelPluginVersion.Text = Resources.VersionShort + _pluginContainer.Plugins[id].Version;
            TextBoxPluginDescription.Text = _pluginContainer.Plugins[id].Description;

            if (_pluginContainer.CheckDependency(id)) {
                EnablePlugin();
            }
            else {
                DisablePlugin();
            }
        }

        private void DisablePlugin() {
            ButtonPluginRun.Text = Resources.ButtonPluginRunDisabed;
            ButtonPluginRun.Enabled = false;
        }

        private void EnablePlugin() {
            ButtonPluginRun.Text = Resources.ButtonPluginRunEnabled;
            ButtonPluginRun.Enabled = true;
        }

        private void RunPlugin(int id) {
            Hide();
            _pluginContainer.Plugins[id].Run(FormCloseEvent, new List<SessionModel>(_sessionManager.Sessions), null);
        }

        private void FormCloseEvent(object sender, EventArgs eventArgs) {
            Show();
        }
              
        private void ButtonReloadPlugins_Click(object sender, EventArgs e) {
            RefreshPluginList();
        }

        private void ListBoxPlugins_SelectedIndexChanged(object sender, EventArgs e) {
            LoadPlugin(ListBoxPlugins.SelectedIndex);
        }

        private void LabelPluginLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            var dialogResult = MessageBox.Show(Resources.PlguinAuthorLinkConfirm, Resources.ModalTitleYouSure, MessageBoxButtons.YesNo);
            if (dialogResult != DialogResult.Yes) {
                return;
            }

            if (e.Link.LinkData != null) {
                Process.Start(e.Link.LinkData.ToString());
            }
        }

        private void ButtonPluginRun_Click(object sender, EventArgs e) {
            RunPlugin(ListBoxPlugins.SelectedIndex);
        }

        private void LnkLabelCompability_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            // TODO
        }

        private void MainMenuSessionsItem_Click(object sender, EventArgs e) {
            var form = new FormSessions(ref _sessionManager);
            form.ShowDialog();
        }
    }
}
