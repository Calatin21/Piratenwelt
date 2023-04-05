using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piratenwelt {
    internal class Pirat {
        static int fortlaufend = 0814;
        public int PiratID { get; set; }
        public String Name { get; set; }
        public string Gang { get; set; }
        public Pirat() {
            fortlaufend++;
            PiratID = fortlaufend;
            Name = "0815Pirat";
            Gang = "Standardgang";
        }
        public Pirat(string name) {
            fortlaufend++;
            PiratID = fortlaufend;
            Name = name;
        }
    }
}
