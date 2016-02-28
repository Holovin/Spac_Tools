using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using DSpacesTools.Properties;

namespace DSpacesTools {
    public static class Program {
        public static Core AppCore;

        [STAThread]
        static void Main() {
            try {
                AppCore = new Core();
                if (!AppCore.Load()) {
                    MessageBox.Show(@"Не найдено ни одного плагина" + "\n\n" + @"Приложение будет закрыто", @"Информация");
                    return;
                }
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
