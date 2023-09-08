using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildWest
{
    internal class Npc
    {
        public int Id { get; set; }
        public string name { get; set; }
        public int health { get; set; }
        public int money { get; set; }
        public int damage { get; set; }

        public string DisplayString { get { return this.ToString(); } }

        public Npc(string Name, int Health, int Money, int Damage)
        {
            this.name = Name;
            this.health = Health;
            this.money = Money;
            this.damage = Damage;
        }

        public override string ToString()
        {
            return $"Name: {name}, Health: {health}, Money: {money}, Damage: {damage}.";
        }
    }
}
