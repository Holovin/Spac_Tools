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
using DSpacesTools.Properties;

namespace DSpacesTools {
    public partial class FormSessionAdd : Form {
        private SessionManager sessionManager;

        public FormSessionAdd(ref SessionManager sm) {
            InitializeComponent();
            Init(ref sm);
        }

        private void ButtonAddSid_Click(object sender, EventArgs e) {
            AddSid(TextBoxSid.Text);            
        }

        private void Init(ref SessionManager sm) {
            sessionManager = sm;
            Text = Resources.ApplicationName;

            Tabs.SelectedIndex = 0;
            ProgressBarLoading.MarqueeAnimationSpeed = 20; // <- random value
        }
        

        private async void AddSid(string sid) {
            Tabs.SelectedTab = TabLoading;

            // wait tab switch
            await Task.Delay(1000);

            var result = await sessionManager.Add(sid);
            if (!result.GetSuccess()) {
                result.ShowError();
                Tabs.SelectedTab = TabInput;
                return;
            }

            Tabs.SelectedTab = TabSuccess;

            await Task.Delay(5000);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void FormSessionAdd_FormClosing(object sender, FormClosingEventArgs e) {
            if (Tabs.SelectedTab == TabLoading) {
                e.Cancel = true;
            }            
        }
    }
}
