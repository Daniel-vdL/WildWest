using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildWest
{
    internal class Scenes
    {
        static Random rand = new Random();

        public static void Scene1()
        {
            Console.WriteLine($"You defeated {Program.EnemyList[0].Name}! ");
        }
        public static void Scene1Fled() 
        {
            Console.WriteLine($"You ran away from {Program.EnemyList[0].Name}. ");
        }
    }
}
