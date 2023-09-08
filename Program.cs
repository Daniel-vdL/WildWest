namespace WildWest
{
    internal class Program
    {

        public static Player currentPlayer = new Player();

        static List<Npc> npcList = new List<Npc>
        {
            new Npc("Bob", 15, 100, 5),
            new Npc("George", 15, 150, 5),
        };


        static void Main(string[] args)
        {
            Start();
        }

        static void Start()
        {
            Console.WriteLine("WildWest Adventure");
            Console.WriteLine("Name:");
            currentPlayer.name = Console.ReadLine();
            Console.WriteLine("Fill in start of story here!");
            
            if (currentPlayer.name == "")
                Console.WriteLine("You don't have a name? Strange...");

            else
                Console.WriteLine("Your name is " + currentPlayer.name);

            Console.WriteLine(npcList[1]);

        }
    }
}