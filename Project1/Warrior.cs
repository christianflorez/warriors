using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Warrior
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int AttackMax { get; set; }
        public int BlockMax { get; set; }
        private Random rnd = new Random();

        public Warrior(string name = "No Name", int health = 10, int attack = 10, int block = 10)
        {
            Name = name;
            Health = health;
            AttackMax = attack;
            BlockMax = block;
        }

        public int GetAttackValue()
        {
            return rnd.Next(1, AttackMax);
        }

        public int GetBlockValue()
        {
            return rnd.Next(1, BlockMax);
        }
    }
}
