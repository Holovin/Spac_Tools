using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DSpacesAPI;
using DSpacesTools.Properties;

namespace DSpacesTools {
    public partial class FormSessions : Form {
        private SessionManager sessionManager;

        // Logic //
        private void RemoveSession(int id) {
            ListBoxSessions.Items.Remove(id);
            sessionManager.RemoveById(id).ShowError();
            RefreshSessionList();
        }

        private void RefreshSessionList() {
            ListBoxSessions.Items.Clear();
            ListBoxSessions.Items.Add("Анонимный"); // TODO: do something with it

            for (var i = 1; i < sessionManager.Sessions.Count; i++) {
                ListBoxSessions.Items.Add(sessionManager.Sessions[i].Login);
            }

            ListBoxSessions.SelectedIndex = 0;
        }

        private void LoadSession(int id) {
            LabelLogin.Text = sessionManager.Sessions[id].Login;
            LabelSid.Text = sessionManager.Sessions[id].Sid;
            LabelAccountId.Text = sessionManager.Sessions[id].UserId;

            LabelTimeChecked.Text = sessionManager.Sessions[id].LastCheckTime.ToString(CultureInfo.InvariantCulture);
            LabelTimeCreated.Text = sessionManager.Sessions[id].CreationTime.ToString(CultureInfo.InvariantCulture);

            switch (sessionManager.Sessions[id].State) {
                case SessionState.Empty:
                    LabelLogin.Text = Resources.UnknownValue;
                    LabelSid.Text = Resources.UnknownValue;
                    LabelAccountId.Text = Resources.UnknownValue;
                    LabelStatus.Text = Resources.SessionStatusEmpty;
                    break;   

                case SessionState.Anonymous:
                    LabelLogin.Text = Resources.SessionAnonymousLogin;
                    LabelSid.Text = Resources.UnknownValue;
                    LabelAccountId.Text = Resources.UnknownValue;
                    LabelStatus.Text = Resources.SessionStatusAnonymous;
                    break;

                case SessionState.Valid:
                    LabelStatus.Text = Resources.SessionStatusValid;
                    break;

                case SessionState.Invalid:
                    LabelStatus.Text = Resources.SessionStateInvalid;
                    LabelAccountId.Text = Resources.UnknownValue;
                    break;

                default:
                    return;
            }
        }

        private async void RefreshSession(int id) {
            LabelTimeChecked.Text = Resources.Common_LoadingBraces;

            var result = await sessionManager.Sessions[id].CheckStatus();
            result.ShowError();

            LoadSession(id);
        }

        // Gui methods //
        public FormSessions(ref SessionManager sessionManager) {
            InitializeComponent();

            Init(ref sessionManager);
            RefreshSessionList();            
        }

        private void ListBoxSessions_SelectedIndexChanged(object sender, EventArgs e) {
            LoadSession(ListBoxSessions.SelectedIndex);
        }

        private void Init(ref SessionManager sm) {
            sessionManager = sm;

            Text = Resources.ApplicationName;
        }

        private void MainMenuControlAddItem_Click(object sender, EventArgs e) {
            var form = new FormSessionAdd(ref sessionManager);
            form.ShowDialog();
            RefreshSessionList();
        }

        private void MainMenuControlRefreshItem_Click(object sender, EventArgs e) {
            RefreshSessionList();
        }

        private void MainMenuControlRemoveItem_Click(object sender, EventArgs e) {
            RemoveSession(ListBoxSessions.SelectedIndex);
        }

        private void LabelTimeChecked_Click(object sender, EventArgs e) {
            RefreshSession(ListBoxSessions.SelectedIndex);
        }
    }
}
