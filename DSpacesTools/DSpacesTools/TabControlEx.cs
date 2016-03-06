using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSpacesTools {
    // http://blog.laplante.io/2011/01/hiding-tab-headers-on-a-tabcontrol-in-c/
    public class TabControlEx : TabControl {
        protected override void WndProc(ref System.Windows.Forms.Message m) {
            if (m.Msg == 0x1328 && !DesignMode) {
                m.Result = (IntPtr) 1;
            }
            else {
                base.WndProc(ref m);
            }
        }
    }
}
