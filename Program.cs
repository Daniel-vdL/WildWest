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

        }

        static void Start()
        {
            Npc npc1 = new Npc();
            npc1.name = "John";
            npc1.health = 50;
            npc1.money = 150;
            npc1.damage = 5;

            Console.WriteLine("WildWest Adventure");
            Console.WriteLine("Name:");
            currentPlayer.name = Console.ReadLine();
            Console.WriteLine("Fill in start of story here!");
            
            if (currentPlayer.name == "")
                Console.WriteLine("You don't have a name? Strange...");

            else
                Console.WriteLine($"Your name is {currentPlayer.name}");

        }
    }
}