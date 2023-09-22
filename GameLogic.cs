using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildWest
{
    internal class GameLogic
    {
        static int armorMod;
        static int gunMod;

        //Method to check if player wants to continue
        public static bool ShouldContinueGame() 
        {
            string answer = null;
            Console.WriteLine("Press enter to continue or type 'Exit' to stop!");
            answer = Console.ReadLine();
            
            if (answer.ToLower() == "exit")
            {
                Console.Clear();
                return false;
            }
            return true;
        }

        public static void Inventory()
        {
            Console.Clear();
            Console.WriteLine($"Current mission: {Program.currentPlayer.Mission}. ");
            Console.WriteLine("");
            Console.WriteLine($"===============================");
            Console.WriteLine($"| Level: {Program.currentPlayer.Level}                    |");
            Console.WriteLine($"| Health: {Program.currentPlayer.Health}                  |");
            Console.WriteLine($"| Damage: {Program.currentPlayer.Damage}                   |");
            Console.WriteLine($"| Armor: {Program.currentPlayer.Armor}                    |");
            Console.WriteLine($"| Amount of coins: {Program.currentPlayer.Money}          |");
            Console.WriteLine($"| Whiskey Bottles: {Program.currentPlayer.WhiskeyBottles}          |");
            Console.WriteLine($"===============================");
            Console.WriteLine($"{Program.currentPlayer.Name}");
        }

        public static void Help()
        {
            Console.WriteLine();
        }

        public static void Shop()
        {
            Console.Clear(); 
            Console.WriteLine("==================");
            Console.WriteLine("| *Banjo Bazaar* |");
            Console.WriteLine("==================");


        }
    }
}
