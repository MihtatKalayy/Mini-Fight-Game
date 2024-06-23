using MiniFightGame.Models;

int canavarCan = 0;
int oyuncuCan = 0;
string karakterSilah = null;

Random dusmanSaldiri = new Random();

Buyucu buyucu = new Buyucu();
Sovalye sovalye = new Sovalye();
Suikastci suikastci = new Suikastci();
Enemy dusman = new Enemy();
canavarCan = dusman.dusmanCan();



Console.WriteLine("////////////////////////////////////////////////////");
Console.WriteLine("/////////Welcome to Kalay's Mini Fight Game/////////");
Console.WriteLine("////////////////////////////////////////////////////");

Console.Write("\nPlease enter your character name: ");
string _name = Console.ReadLine();

Console.WriteLine("1.Knight\n2.Sorcerer\n3.Assasin\nChoose your class: ");
string _class = Console.ReadLine();
Console.WriteLine(" ");

while(true)
{
    if (_class == "Knight" || _class == "knight" ||_class == "1")
    {
        Console.WriteLine("You chose Knight");
        oyuncuCan = sovalye.sovalyeCan();
        karakterSilah = sovalye.sovalyeSilah();
        break;
    }
    else if (_class == "Sorcerer" || _class == "sorcerer" || _class == "2")
    {
        Console.WriteLine("You chose Sorcerer");
        oyuncuCan = buyucu.buyucuCan();
        karakterSilah = buyucu.buyucuSilah();
        break;
    }
    else if (_class == "Assasin" || _class == "assasin"|| _class == "3")
    {
        Console.WriteLine("You chose Assasin");
        oyuncuCan = suikastci.suikastciCan();
        karakterSilah = suikastci.suikastciSilah();
        break;
    }
    else
    {
        Console.WriteLine("Please enter a valid reason...");
    }
    Console.WriteLine(" ");
}


while (true)
{
    
    for (global::System.Int32 i = 0; i <= 1;)
    {
        if(i == 0)
        {
            Console.WriteLine("Your Turn...\n");
            Console.Write("1-Attack\n2-Check stats\n3.Wait and Heal\n4.Check enemy stats\nPlease choose your action: ");
            string _action = Console.ReadLine();

            if (_action == "Attack" || _action == "attack" || _action == "1")
            {
                Console.WriteLine("You attacked!!");
                if (_class == "Knight" || _class == "knight")
                {
                    sovalye.sovalyeHasar(canavarCan);
                    canavarCan = sovalye.sovalyeHasar(canavarCan);
                    Console.WriteLine(canavarCan);
                }
                else if (_class == "Sorcerer" || _class == "sorcerer")
                {
                    buyucu.buyucuHasar(canavarCan);
                    canavarCan = buyucu.buyucuHasar(canavarCan);
                }
                else if (_class == "Assasin" || _class == "assasin")
                {
                    suikastci.suikastHasar(canavarCan);
                    canavarCan = suikastci.suikastHasar(canavarCan);
                }
            }
            else if (_action == "Check Stats" || _action == "check stats" || _action == "2")
            {
                Console.WriteLine($"Your Name: {_name}\nYour Class: {_class}");
                Console.WriteLine("******************************************");
                Console.WriteLine($"Your health: {oyuncuCan}\n Your Weapon: {karakterSilah}");

            }
            else if (_action == "Wait" || _action == "wait" || _action == "3")
            {
                Console.WriteLine("You Healing");
                if (_class == "Knight" || _class == "knight")
                {
                    sovalye.sovalyeIyilesme();
                }
                else if (_class == "Sorcerer" || _class == "sorcerer")
                {
                    buyucu.buyucuIyilesme();
                }
                else if (_class == "Assasin" || _class == "assasin")
                {
                    suikastci.suikastIyilesme();
                }
            }
            else if (_action == "Enemy Check Stats" || _action == "enemy check stats" || _action == "4")
            {
                Console.WriteLine(" ");
                Console.WriteLine($"Enemy Health: {canavarCan}");
                Console.WriteLine(" ");
            }

            
            i++;
        }
        else if (i == 1)
        {
            Console.WriteLine("Enemy Turn..\n");
            int dusmanSalInt = dusmanSaldiri.Next(1, 3);

            if(dusmanSalInt == 1)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Enemy attacked");
                if (_class == "Knight" || _class == "knight" || _class == "1")
                {
                    oyuncuCan = dusman.dusmanHasar(oyuncuCan);
                }
                else if (_class == "Sorcerer" || _class == "sorcerer" || _class == "2")
                {
                   oyuncuCan = dusman.dusmanHasar(oyuncuCan);
                }
                else if (_class == "Assasin" || _class == "assasin" || _class == "3")
                {
                   oyuncuCan = dusman.dusmanHasar(oyuncuCan);
                }
            }
            else if (dusmanSalInt == 2)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Enemy healthed");
                dusman.dusmanIyilesme();             
            }
            i--;
        }
    }
    
}
if(canavarCan <= 0)
{
    Console.WriteLine(" ");
    Console.WriteLine("YOU WIN!!!!!!");
    Console.WriteLine(" ");
}
else if (oyuncuCan <= 0)
{
    Console.WriteLine(" ");
    Console.WriteLine("YOU LOSE!!!!!");
    Console.WriteLine(" ");
}