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
        public FormSessions() {
            InitializeComponent();
            RefreshSessionList();
            Init();
        }
       
        private void ListBoxSessions_SelectedIndexChanged(object sender, EventArgs e) {
            LoadSession(ListBoxSessions.SelectedIndex);
        }


        private void MainMenuRemoveItem_Click(object sender, EventArgs e) {
            RemoveSession(ListBoxSessions.SelectedIndex);
        }

        private void Init() {
            Text = Resources.ApplicationName;
        }

        private void RemoveSession(int id) {
            ListBoxSessions.Items.Remove(id);
            Program.AppCore.SessionManager.RemoveById(id).ShowError();
            RefreshSessionList();
        }

        private void RefreshSessionList() {
            ListBoxSessions.Items.Clear();
            ListBoxSessions.Items.Add("Анонимный");

            for (var i = 1; i < Program.AppCore.SessionManager.Sessions.Count; i++) {
                ListBoxSessions.Items.Add(Program.AppCore.SessionManager.Sessions[i].Login);
            }

            ListBoxSessions.SelectedIndex = 0;
        }

        private void LoadSession(int id) {
            LabelLogin.Text = Program.AppCore.SessionManager.Sessions[id].Login;
            LabelSid.Text = Program.AppCore.SessionManager.Sessions[id].Sid;
            LabelAccountId.Text = Program.AppCore.SessionManager.Sessions[id].UserId;

            LabelTimeChecked.Text = Program.AppCore.SessionManager.Sessions[id].LastCheckTime.ToString(CultureInfo.InvariantCulture);
            LabelTimeCreated.Text = Program.AppCore.SessionManager.Sessions[id].CreationTime.ToString(CultureInfo.InvariantCulture);

            switch (Program.AppCore.SessionManager.Sessions[id].State) {
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

        private void MainMenuAddItem_Click(object sender, EventArgs e) {
            var form = new FormSessionAdd();
            form.ShowDialog();
            RefreshSessionList();
        }

        private void MainMenuRefreshItem_Click(object sender, EventArgs e) {
            RefreshSessionList();
        }
    }
}
