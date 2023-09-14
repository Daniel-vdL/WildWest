namespace WildWest
{
    internal class Program
    {

        public static Player currentPlayer = new Player();

        static List<Enemies> npcList = new List<Enemies>
        {
            new Enemies("Bob", 15, 100, 5),
            new Enemies("George", 15, 150, 5),
        };


        static void Main(string[] args)
        {
            Start();
            Encounters.Encounter1();
        }

        static void Start()
        {
            Npc npc1 = new Npc();
            npc1.Name = "John";
            npc1.Health = 50;
            npc1.Money = 150;
            npc1.Damage = 5;

            Console.WriteLine("WildWest Adventure");
            Console.WriteLine("Name:");
            currentPlayer.Name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("");
            
            if (currentPlayer.Name == "")
                Console.WriteLine("You don't have a name? Strange...");

            else
                Console.WriteLine($"Your name is {currentPlayer.Name}");
            Console.ReadKey();

        }
    }
}