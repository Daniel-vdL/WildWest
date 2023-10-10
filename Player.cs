using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace WildWest
{
    internal class Player
    {
        Random rand = new Random();

        public int Id;
        public string Name;
        public int Health = 15;
        public int MaxHealth = 15;
        public int Money = 5;
        public int Damage = 2;
        public int Armor = 1;
        public int WhiskeyBottles = 5;
        public int Level = 1;
        public string Mission = "No mission yet...";

        public int Getcoins()
        {
            int upper = (15 * Level + 50);
            int lower = (10 * Level + 10);
            return rand.Next(lower, upper);
        }

    }
}
