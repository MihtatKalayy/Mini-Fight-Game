using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniFightGame.Models
{
    internal class Enemy : Base
    {
        public int dusmanCan()
        {
            Enemy enemy = new Enemy();
            enemy.can = 3000;
            return enemy.can;
        }
        public int dusmanHasar(int karakterCan)
        {
            Enemy enemy = new Enemy();
            int vurulanhasar = enemy.verilenHasar.Next(1, 10);
            karakterCan = karakterCan - vurulanhasar;
            return karakterCan;
        }

        public int dusmanIyilesme()
        {
            Enemy enemy = new Enemy();
            if(enemy.can < 3000)
            {
                int iyilesme = enemy.iyilesenCan.Next(1, 10);
                enemy.can = enemy.can + iyilesme;
            }
            else
            {
                enemy.can = 250;
            }
            return enemy.can;
        }
    }
}
