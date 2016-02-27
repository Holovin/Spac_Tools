using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DNetwork;

namespace DPluginDemo {
    public partial class PluginGUI : Form {
        public PluginGUI(string s) {
            InitializeComponent();
            LabelText.Text = s;
        }

        private void ButtonCheckNetwork_Click(object sender, EventArgs e) {
            //  
        }
    }
}
