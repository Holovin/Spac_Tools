using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DNetwork;
using DSpacesAPI;
using DSpacesTools.Properties;

namespace DSpacesTools {
    public partial class FormApp : Form {
        private Network network;
        private PluginContainer pluginContainer;
        private SessionManager sessionManager;

        public FormApp(ref Network network, ref PluginContainer pluginContainer, ref SessionManager sessionManager) {
            InitializeComponent();

            this.network = network;
            this.pluginContainer = pluginContainer;
            this.sessionManager = sessionManager;
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
            pluginContainer.Load();

            ListBoxPlugins.Items.Clear();
            foreach (var plugin in pluginContainer.Plugins) {
                ListBoxPlugins.Items.Add(new KeyValuePair<string, string>(plugin.InnerName, plugin.Name));
            }

            ListBoxPlugins.SelectedIndex = 0;
        }

        private void LoadPlugin(int id) {
            LabelPluginName.Text = pluginContainer.Plugins[id].Name;
            LabelPluginAuthor.Text = pluginContainer.Plugins[id].Author;
            LabelPluginLink.Links.Clear();
            LabelPluginLink.Links.Add(new LinkLabel.Link() {
                LinkData = pluginContainer.Plugins[id].Link                
            });
            LabelPluginVersion.Text = Resources.VersionShort + pluginContainer.Plugins[id].Version;
            TextBoxPluginDescription.Text = pluginContainer.Plugins[id].Description;

            if (pluginContainer.CheckDependency(id)) {
                EnablePlugin(id);
            }
            else {
                DisablePlugin(id);
            }
        }

        private void DisablePlugin(int id) {
            ButtonPluginRun.Text = Resources.ButtonPluginRunDisabed;
            ButtonPluginRun.Enabled = false;
        }

        private void EnablePlugin(int id) {
            ButtonPluginRun.Text = Resources.ButtonPluginRunEnabled;
            ButtonPluginRun.Enabled = true;
        }

        private bool RunPlugin(int id) {
            pluginContainer.Plugins[0].Run(this.FindForm(), null);
            return true;
        }

        private string GetCompabilityVersion(int id) {
            return pluginContainer.GetCompabilityList(id).
                Aggregate(@"Имя файла / Версия (min; max) (если 0 - любая)", (current, req) => current + ("\n" + req.Key + @": " + req.Value[0] + @"; " + req.Value[1]));
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
            MessageBox.Show(this, GetCompabilityVersion(ListBoxPlugins.SelectedIndex), "Информация о совместимости");
        }

        private void MainMenuSessionsItem_Click(object sender, EventArgs e) {
            var form = new FormSessions(ref sessionManager);
            form.ShowDialog();
        }
    }
}
