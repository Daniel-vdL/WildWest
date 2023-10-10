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
            Console.WriteLine("");
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

        public static void Info()
        {
            Console.Clear();
            Console.WriteLine("========================");
            Console.WriteLine("| *WildWest Adventure* |");
            Console.WriteLine("|        *info*        |");
            Console.WriteLine("========================");
            Console.WriteLine("");
            Console.WriteLine("This is a Text based game.");
            Console.WriteLine("You will be following a story line from a cowboy who suddenly woke up.");
            Console.WriteLine("The story is mostly text that you have to read.");
            Console.WriteLine("");
            Console.WriteLine("Sometimes you will get choices where you can choose from one of the options that have been given.");
            Console.WriteLine("You can decide to not fill in anything, but it will not always turn out great.");
            Console.WriteLine("Every option has an effect on the story!");
            Console.WriteLine("");
            Console.WriteLine("You will also end up in battles with enemies, where you will also have options to choose from.");
            Console.WriteLine("Defeating them will level you up, and sometimes you will gain rewards!");
            Console.WriteLine("");
            Console.WriteLine("Goodluck and have fun!");
        }

        public static void Help()
        {
            Console.Clear();
            Console.WriteLine("========================");
            Console.WriteLine("| *WildWest Adventure* |");
            Console.WriteLine("|        *Help*        |");
            Console.WriteLine("========================");
            Console.WriteLine("");
            Console.WriteLine("I am also not sure what to do, but have some coins!");
            Console.WriteLine("");
            int coins = Program.currentPlayer.Getcoins();
            Program.currentPlayer.Money = coins + Program.currentPlayer.Money;

            Console.WriteLine($"You now have {Program.currentPlayer.Money}.");
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
