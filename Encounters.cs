using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace WildWest
{
    internal class Encounters
    {
        static Random rand = new Random();

        public string Name { get; set; }
        public string EnemyName { get; set; }
        public int EnemyHealth { get; set; }
        public int EnemyPower { get; set; }
        public string DidPlayerRun { get; set; }


        //Combat Tool
        public void Combat()
        {
            string n = "";
            int p = 0;
            int h = 0;

            n = this.EnemyName;
            p = this.EnemyPower;
            h = this.EnemyHealth;

            while (h > 0 && Program.currentPlayer.Health > 0)
            {
                Console.WriteLine(n);
                Console.WriteLine($"Power: {p} | Health: {h}");
                Console.WriteLine("");
                Console.WriteLine("=====================");
                Console.WriteLine("| (A)ttack (D)efend |");
                Console.WriteLine("| (R)un    (H)eal   |");
                Console.WriteLine("=====================");
                Console.WriteLine("");
                Console.WriteLine(Program.currentPlayer.Name);
                Console.WriteLine($"Health:  {Program.currentPlayer.Health} | Whiskey Bottles: {Program.currentPlayer.WhiskeyBottles}");

                string input = Console.ReadLine();
                if (input.ToLower() == "a" || input.ToLower() == "attack")
                {
                    //attack
                    Console.Clear();

                    Console.WriteLine($" You attack the {n} with your Pistol");
                    int damage = p - Program.currentPlayer.Armor;
                    if (damage < 0)
                        damage = 0;
                    int attack = rand.Next(0, Program.currentPlayer.Damage) + rand.Next(1, 4);
                    Console.WriteLine($"You lost {damage} health and deal {attack} damage!");
                    Program.currentPlayer.Health -= damage;
                    h -= attack;
                    Console.WriteLine("");
                    Console.WriteLine("Press Enter to continue...");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (input.ToLower() == "d" || input.ToLower() == "defend")
                {
                    //Defend
                    Console.Clear();

                    Console.WriteLine($"You defend yourself while {n} prepares to attack.");
                    int damage = (p/4) - Program.currentPlayer.Armor;
                    if (damage < 0)
                        damage = 0;
                    int attack = rand.Next(0, Program.currentPlayer.Damage)/2;
                    Console.WriteLine($"You lose {damage} health points and deal {attack} damage");
                    Program.currentPlayer.Health -= damage;
                    h -= attack;
                    Console.WriteLine("");
                    Console.WriteLine("Press Enter to continue...");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (input.ToLower() == "r" || input.ToLower() == "run")
                {
                    //Run
                    Console.Clear();
                    
                    if(rand.Next(0, 2) == 0)
                    {
                        Console.WriteLine($"You try to throw a whiskey bottle at {n}'s face but you miss! You lose 1 Whiskey bottle.");
                        Program.currentPlayer.WhiskeyBottles -= 1;
                        Console.WriteLine($"{Program.currentPlayer.WhiskeyBottles} bottles of whiskey remaining.");
                        Console.WriteLine("");
                        Console.ReadKey();
                        Console.WriteLine($"{n} shoots you while you cry on the floor.");
                        int damage = p - Program.currentPlayer.Armor;
                        if (damage < 0)
                            damage = 0;
                        Console.WriteLine($"You lose {damage} health points and are unable to escape.");
                        Program.currentPlayer.Health -= damage;
                        Console.WriteLine("");
                        Console.WriteLine("Press Enter to continue...");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine($"You throw a whiskey bottle in {n}'s face and you escape! You lose 1 Whiskey bottle.");
                        Program.currentPlayer.WhiskeyBottles -= 1;
                        Console.WriteLine($"{Program.currentPlayer.WhiskeyBottles} bottles of whiskey remaining.");
                        DidPlayerRun = "yes";
                        Console.WriteLine("");
                        Console.WriteLine("Press Enter to continue...");
                        Console.ReadKey();
                        Console.Clear();
                        h = 0;
                    }
                }
                else if (input.ToLower() == "h" || input.ToLower() == "heal")
                {
                    //Heal
                    Console.Clear();

                    if(Program.currentPlayer.WhiskeyBottles == 0)
                    {
                        Console.WriteLine("You reach into your satchel but you notice you ran out of whiskey. So sad...");
                        int damage = p - Program.currentPlayer.Armor;
                        if(damage < 0) 
                           damage = 0;
                        Console.WriteLine($"{n} attacks you while you were searching for whiskey and you lose {damage} health!");
                        Program.currentPlayer.Health -= damage;
                        Console.WriteLine("");
                        Console.WriteLine("Press Enter to continue...");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("You grab a bottle of whiskey and you drink it all in one go. Good for you buddy...");
                        int healthP = 10;
                        Console.WriteLine($"You gain {healthP} health points!");
                        Console.WriteLine("");
                        Program.currentPlayer.WhiskeyBottles -= 1;
                        Console.WriteLine($"{Program.currentPlayer.WhiskeyBottles} bottles of whiskey remaining.");
                        Program.currentPlayer.Health += healthP;
                        Console.WriteLine("");
                        Console.WriteLine("Press Enter to continue...");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
            }
            while (this.EnemyHealth < 0 || Program.currentPlayer.Health < 0)
            {
                return;
            }
        }
    }
}
