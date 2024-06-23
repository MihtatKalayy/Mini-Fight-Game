using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniFightGame.Models
{
    internal class Suikastci : Base
    {
        int vurulanHasar;
        

        public int suikastciCan()
        {
            Suikastci suikastci = new Suikastci();
            suikastci.can = 150;
            return suikastci.can;
        }

        public string suikastciSilah()
        {
            Suikastci suikastci = new Suikastci();
            suikastci.kullanılanSilah = "Hançer";
            return suikastci.kullanılanSilah;
        }

        public int suikastHasar(int canavarCan)
        {
            Suikastci suikastci = new Suikastci();
            vurulanHasar = suikastci.verilenHasar.Next(10, 70);
            canavarCan = canavarCan - vurulanHasar;
            return canavarCan;
        }

        public int suikastIyilesme()
        {
            Suikastci suikastci = new Suikastci();
            if(suikastci.can < 150)
            {
                int iyilesme = suikastci.iyilesenCan.Next(1, 30);
                suikastci.can = suikastci.can + iyilesme;
            }
            else
            {
                suikastci.can = 150;
            }
            return suikastci.can;
        }
    }
}
