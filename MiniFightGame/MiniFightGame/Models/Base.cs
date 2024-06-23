using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniFightGame.Models
{
    internal class Base
    {
        private Random Hasar = new Random();
        private Random Iyileşme = new Random();
        public Random verilenHasar { get { return Hasar; } set { Hasar = value; } }
        public Random iyilesenCan { get { return Iyileşme; } set { Iyileşme = value; } }
        public string kullanılanSilah { get; set; }
        public int can { get; set; }
        
    }
}
