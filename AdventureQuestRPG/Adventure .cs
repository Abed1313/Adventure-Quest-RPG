using System;
using System.Collections.Generic;
using System.Numerics;

namespace AdventureQuestRPG
{
    public class Adventure 
    {
        public static void Game(Player abood)                                       
        {
            Random random = new Random();                                  // Random Monster List
            Monster[] monsters = { new Falcon(), new Dragon(), new Eagle() };
            int index = random.Next(monsters.Length);
            Monster monster = monsters[index];

            

            List<string> locations = new List<string>                       // Location List
        {
            "WadiRumDesert", "DeadSea", "AjlounForest", "Petra", "MountNebo"
        };

            List<string> actions = new List<string>()                      // Action List
        {
            "ChooseLocation", "Attack"
        }; 
            abood.DesblayInfo();
            monster.DesblayInfo();

            Console.WriteLine("Choose Map");
                    Console.WriteLine("1 - DeadSea\n2 - WadiRumDesert\n3 - AjlounForest\n4 - Petra\n5 - MountNebo");
                    string chosenLocation = Console.ReadLine();

                    while (!locations.Contains(chosenLocation, StringComparer.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("You entered an invalid input. Please choose a valid location:");
                        chosenLocation = Console.ReadLine();
                    }
                    Console.WriteLine($"Welcome to {chosenLocation}, Play Started");
                    BattleSystem.StartBattel(monster, abood);
            
                    Console.WriteLine($"ExperiencePoints : {abood.ExperiencePoints}");

        }
    }
}
