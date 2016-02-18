using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IPlugin;

namespace DNetwork {
    public class Network: IBasePlugin {
        public string Name => "Base.Network";

        public string Author => "DJ_miXxXer";

        public string Description => "Base plugin for network";

        public string InnerName => "network";

        public string Link => "http://spaces.ru";

        public int Version => 1;

        public string Test(string s) {
            return "OK: " + s + ";";
        }
    }
}
