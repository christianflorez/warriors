using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Battle
    {
        private Boolean isBattleActive = true;

        public void StartFight(Warrior warriorA, Warrior warriorB)
        {
            while(isBattleActive)
            {
                LaunchAttackRound(warriorA, warriorB);
                LaunchAttackRound(warriorB, warriorA);
            }

            if (warriorA.Health > warriorB.Health)
            {
                Console.WriteLine($"{warriorA.Name} wins!");
            }
            else
            {
                Console.WriteLine($"{warriorB.Name} wins!");
            }
        }

        public void LaunchAttackRound(Warrior attacker, Warrior defender)
        {
            if (isBattleActive)
            {
                GetAttackResult(attacker, defender);
                CheckDefenderHealth(defender);
            }
        }

        public void GetAttackResult(Warrior attacker, Warrior defender)
        {
            int attack = attacker.GetAttackValue();
            int block = defender.GetBlockValue();
            int damage = attack - block;

            if (damage > 0)
            {
                Console.WriteLine($"{attacker.Name} attacks {defender.Name} for {damage} points!");
                defender.Health -= damage;
            }
            else
            {
                Console.WriteLine($"{defender.Name} blocks the attack completely!");
            }
        }

        public void CheckDefenderHealth(Warrior defender)
        {
            if (defender.Health <= 0)
            {
                Console.WriteLine($"{defender.Name} faints.");
                isBattleActive = false;
            }
        }
    }
}
