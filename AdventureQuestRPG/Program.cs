namespace AdventureQuestRPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                bool playAgain = true;

                while (playAgain)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;

                Player player = new Player("Abood", 100, "Sword");
                player.DesblayInfo();
                Console.WriteLine();

                Adventure.Game();
                    Console.WriteLine("Would you play again (Y/N)?");
                    string response = Console.ReadLine().ToUpper();
                    if (response != "Y")
                    {
                        playAgain = false;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            
            Console.ReadKey();
        }
    }
}
