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
        public FormApp() {
            InitializeComponent();
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
            Program.AppCore.Load();

            ListBoxPlugins.Items.Clear();
            foreach (var plugin in Program.AppCore.PluginContainer.Plugins) {
                ListBoxPlugins.Items.Add(new KeyValuePair<string, string>(plugin.InnerName, plugin.Name));
            }

            ListBoxPlugins.SelectedIndex = 0;
        }

        private void LoadPlugin(int id) {
            LabelPluginName.Text = Program.AppCore.PluginContainer.Plugins[id].Name;
            LabelPluginAuthor.Text = Program.AppCore.PluginContainer.Plugins[id].Author;
            LabelPluginLink.Links.Clear();
            LabelPluginLink.Links.Add(new LinkLabel.Link() {
                LinkData = Program.AppCore.PluginContainer.Plugins[id].Link                
            });
            LabelPluginVersion.Text = Resources.VersionShort + Program.AppCore.PluginContainer.Plugins[id].Version;
            TextBoxPluginDescription.Text = Program.AppCore.PluginContainer.Plugins[id].Description;

            if (Program.AppCore.PluginContainer.CheckDependency(id)) {
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
            Program.AppCore.PluginContainer.Plugins[0].Run(this);
            return true;
        }

        private static string GetCompabilityVersion(int id) {
            return Program.AppCore.PluginContainer.GetCompabilityList(id).
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

        private void MenuMainAbout_Click(object sender, EventArgs e) {
            MessageBox.Show(@"by " + Resources.AppAuthor + @", 2016", Resources.ApplicationName);
        }

        private void MenuMainAccounts_Click(object sender, EventArgs e) {
            var form = new FormAccounts();
            form.ShowDialog();
        }

        private void MainMenuSessionsItem_Click(object sender, EventArgs e) {
            var form = new FormSessions();
            form.ShowDialog();
        }
    }
}
