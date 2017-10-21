using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Program
    {
        static void Main()
        { 
            Warrior maximus = new Warrior("Maximus", 1000, 600, 150);
            Warrior gannicus = new Warrior("Gannicus", 1000, 400, 200);

            Battle battle = new Battle();
            battle.StartFight(maximus, gannicus);

            Console.ReadLine();
        }
    }
}
