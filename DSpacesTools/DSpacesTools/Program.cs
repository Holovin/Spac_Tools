using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSpacesTools {
    public static class Program {
        public static Core AppCore;

        [STAThread]
        static void Main() {
            try {
                AppCore = new Core();
            }
            catch (Exception e) {
                MessageBox.Show(e.Message, @"Ошибка начальной загрузки");
                return;
            }
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormApp());
        }
    }
}
