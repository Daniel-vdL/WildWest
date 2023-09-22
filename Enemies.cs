using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildWest
{
    internal class Enemies
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Health { get; set; }
        public int MaxHealth { get; set; }
        public int Damage { get; set; }

        public string DisplayString { get { return this.ToString(); } }

        public Enemies(string Name, int Health, int MaxHealth, int Damage)
        {
            this.Name = Name;
            this.Health = Health;
            this.MaxHealth = MaxHealth;
            this.Damage = Damage;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Health: {Health}, Damage: {Damage}.";
        }
    }
}
