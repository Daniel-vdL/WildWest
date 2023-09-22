using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography.X509Certificates;
using System.IO;
using System.Linq.Expressions;

namespace WildWest
{
    internal class Program
    {

        public static Player currentPlayer = new Player();

        //Create List of Enemies
        public static List<Enemies> enemyList = new List<Enemies>
        {
            new Enemies("One shot Bill", 15, 15, 5),
            new Enemies("George", 25, 25, 8),
            new Enemies("Night Rider", 100, 100, 10),
        };

        //Create List of Npcs
        public static List<Npc> npcList = new List<Npc>()
        {
            new Npc("Jason", 50, 100, 10),
            new Npc("Dead Eye Jake", 15, 150, 5),
            new Npc("Joe Rudeboy", 500, 5, 999),
        };


        static void Main(string[] args)
        {
            Scenes.NewStart();

            while (currentPlayer.Health > 0 && GameLogic.ShouldContinueGame())
            {

                //Starts Encounter1
                Console.Clear();
                var encounter1 = new Encounters();
                encounter1.Name = $"Battle Against {Program.enemyList[0].Name}";
                encounter1.EnemyName = Program.enemyList[0].Name;
                encounter1.EnemyHealth = Program.enemyList[0].Health;
                encounter1.EnemyMaxHealth = Program.enemyList[0].MaxHealth;
                encounter1.EnemyPower = Program.enemyList[0].Damage;
                encounter1.DidPlayerRun = "";
                currentPlayer.Mission = $"Defeat {enemyList[0].Name}";

                Console.WriteLine($"{encounter1.Name} Started!");
                Console.WriteLine("");
                Console.WriteLine("Press Enter to continue...");
                Console.ReadKey();
                Console.Clear();

                encounter1.Combat();

                if (GameLogic.ShouldContinueGame() == false)
                {
                    Console.WriteLine("Game Stopped");
                    return;
                }

                if (currentPlayer.Health > 0 && encounter1.DidPlayerRun == "")
                {
                    //Starts Scene1
                    Console.Clear();
                    Scenes.Scene1();
                }
                else if (currentPlayer.Health > 0 && encounter1.DidPlayerRun == "yes")
                {
                    //Starts Scene1Fled
                    Console.Clear();
                    Scenes.Scene1Fled();
                }

                var encounter2 = new Encounters();
                encounter2.Name = $"Battle Against {Program.enemyList[1].Name}";
                encounter2.EnemyName = Program.enemyList[1].Name;
                encounter2.EnemyHealth = Program.enemyList[1].Health;
                encounter2.EnemyMaxHealth = Program.enemyList[1].MaxHealth;
                encounter2.EnemyPower = Program.enemyList[1].Damage;
                encounter2.DidPlayerRun = "";
                currentPlayer.Mission = $"Defeat {enemyList[1].Name}";

                Console.WriteLine($"{encounter2.Name} Started!");
                Console.WriteLine("");
                Console.WriteLine("Press Enter to continue...");
                Console.ReadKey();
                Console.Clear();

                encounter2.Combat();
            }

            if(currentPlayer.Health <= 0) 
            {
                Console.WriteLine("You died!");
                return;
            }
            Console.WriteLine("Game stopped");
            return;
        }
    }
}