namespace AdventureQuestRPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Player player = new Player("Abood", 100, "Sword");
                player.DesblayInfo();
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Dragon dragon = new Dragon("Dragon", 100, "Scales");
                dragon.DesblayInfo();
                Console.WriteLine("");

                Falcon falcon = new Falcon("Falcon", 100, "Scales");

                BattleSystem battleSystem = new BattleSystem();
                // battleSystem.StartBattel(dragon, player);

                battleSystem.StartBattel(falcon, player);
            }catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            Console.ReadKey();
        }
    }
}
