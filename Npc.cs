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
        public string Name { get; set; }
        public int Health { get; set; }
        public int Money { get; set; }
        public int Damage { get; set; }

        public string DisplayString { get { return this.ToString(); } }

        public Npc(string Name, int Health, int Money, int Damage)
        {
            this.Name = Name;
            this.Health = Health;
            this.Money = Money;
            this.Damage = Damage;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Health: {Health}, Money: {Money}, Damage: {Damage}.";
        }
    }
}
