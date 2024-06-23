using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniFightGame.Models
{
    internal class Buyucu : Base
    {
        int vurulanHasar;

        public int buyucuCan()
        {
            Buyucu buyucu = new Buyucu();
            buyucu.can = 120;
            return buyucu.can;
        }
        public string buyucuSilah()
        {
            Buyucu buyucu = new Buyucu();
            buyucu.kullanılanSilah = "Asa";
            return buyucu.kullanılanSilah;
        }

        public int buyucuHasar(int canavarCan)
        {
            Buyucu buyucu = new Buyucu();
            vurulanHasar = buyucu.verilenHasar.Next(10, 60);
            canavarCan = canavarCan - vurulanHasar;
            return canavarCan;
        }

        public int buyucuIyilesme()
        {
            Buyucu buyucu = new Buyucu();
            if(buyucu.can < 120)
            {
                int iyilesme = buyucu.iyilesenCan.Next(1, 50);
                buyucu.can = buyucu.can + iyilesme;
            }
            else
            {
                buyucu.can = 120;
            }
            return buyucu.can;
        }
    }
}
