using System;
using System.Windows.Forms;

namespace DPluginDemo {
    public partial class PluginGui : Form {
        private readonly EventHandler _formCloseEvent;

        public PluginGui(string s, EventHandler handler) {
            _formCloseEvent = handler;

            InitializeComponent();
            Owner = null;
            StartPosition = FormStartPosition.CenterParent;
            LabelText.Text = s;
        }

        private void ButtonCheckNetwork_Click(object sender, EventArgs e) {
            MessageBox.Show(@"oops");
        }

        private void PluginGUI_FormClosed(object sender, FormClosedEventArgs e) {
            _formCloseEvent(this, EventArgs.Empty);
        }
    }
}
