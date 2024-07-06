namespace AdventureQuestRPG
{
    public class Program
    {
        static void Main(string[] args)
        {
             int counter = 0;
            try
            {
                bool playAgain = true;
                
                Abood abood = new Abood();
                while (playAgain)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;

                    //player.DesblayInfo();
                    Console.WriteLine("");


                     if (abood.Level <= 2)
                    { 
                        Adventure.Game(abood);
                        if (abood.Level == 3)
                        {
                            Environment.Exit(0);
                        }
                        Console.WriteLine("Would you play again (Y/N)?");
                        string response = Console.ReadLine().ToUpper();
                        if (response != "Y")
                        {
                            playAgain = false;
                            Environment.Exit(0);
                        }
                        else if (response == "Y")
                        {
                            abood.Health = abood.OregenalHealth;
                        }
                    }
                    
                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Mutch End, Come Back for a new Adventure");

            Console.ReadKey();
        }
    }
}
