using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using DSpacesTools.Properties;
using SharedComponents;

namespace DSpacesTools {
    public partial class FormSessionAdd : Form {
        private SessionManager _sessionManager;

        public FormSessionAdd(ref SessionManager sm) {
            InitializeComponent();
            Init(ref sm);
        }

        private async void ButtonAddSid_Click(object sender, EventArgs e) {
            await AddSid(TextBoxSid.Text);
        }

        private void Init(ref SessionManager sm) {
            _sessionManager = sm;
            Text = Resources.ApplicationName;

            Tabs.SelectedIndex = 0;
            ProgressBarLoading.MarqueeAnimationSpeed = 20; // <- random value
        }

        private async Task AddSid(string sid) {
            Tabs.SelectedTab = TabLoading;

            // wait tab switch
            await Task.Delay(1000);

            var result = await _sessionManager.Add(sid);
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
