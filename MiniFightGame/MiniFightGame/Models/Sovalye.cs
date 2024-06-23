using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniFightGame.Models
{
    internal class Sovalye : Base
    {
        int vurulanHasar;
        

        public int sovalyeCan()
        {
            Sovalye sovalye = new Sovalye();
            sovalye.can = 300;
            return sovalye.can;
        }
        public string sovalyeSilah()
        {
            Sovalye sovalye = new Sovalye();
            sovalye.kullanılanSilah = "Çift elli kılıç";
            return sovalye.kullanılanSilah;
        }

        public int sovalyeHasar(int canavarCan)
        {
            Sovalye sovalye = new Sovalye();
            vurulanHasar = sovalye.verilenHasar.Next(10, 80);
            canavarCan = canavarCan - vurulanHasar;
            return canavarCan;
        }

        public int sovalyeIyilesme()
        {
            Sovalye sovalye = new Sovalye();
            if(sovalye.can < 300)
            {
                int iyilesme = sovalye.iyilesenCan.Next(1, 20);
                sovalye.can = sovalye.can + iyilesme;
            }
            else
            {
                sovalye.can = 300;
            }
            return sovalye.can;
        }
    }
}
