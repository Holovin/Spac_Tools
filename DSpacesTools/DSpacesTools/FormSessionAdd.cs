using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DSpacesTools.Properties;

namespace DSpacesTools {
    public partial class FormSessionAdd : Form {
        public FormSessionAdd() {
            InitializeComponent();
            Init();
        }

        private void ButtonAddSid_Click(object sender, EventArgs e) {
            AddSid(TextBoxSid.Text);            
        }

        private void Init() {
            Text = Resources.ApplicationName;

            Tabs.SelectedIndex = 0;
            ProgressBarLoading.MarqueeAnimationSpeed = 30; // <- random value
        }
        

        private async void AddSid(string sid) {
            Tabs.SelectedTab = TabLoading;

            // wait tab switch
            await Task.Delay(500);
           
            var result = await Program.AppCore.SessionManager.Add(sid);

            if (!result.GetSuccess()) {
                result.ShowError();
                Tabs.SelectedTab = TabInput;
                return;
            }

            Tabs.SelectedTab = TabSuccess;            
        }

        private void FormSessionAdd_FormClosing(object sender, FormClosingEventArgs e) {
            if (Tabs.SelectedTab == TabLoading) {
                e.Cancel = true;
            }            
        }
    }
}
