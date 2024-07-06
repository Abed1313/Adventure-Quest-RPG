using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureQuestRPG
{
    public class Inventory
    {
        public static void DropInventory(Player abood)
        {
            try
            {
                Potions potions = new Potions();
                Armor armor = new Armor();
                Weapons weapons = new Weapons();

                Random random = new Random();                               // Random Items List
                string[] drop = { "potions", "armor", "weapons" };
                int index = random.Next(drop.Length);
                string itemsDropped = drop[index];

                Console.ForegroundColor = ConsoleColor.Cyan;
                if (itemsDropped == "potions" && abood.Level < 3)
                {
                    Console.WriteLine($"Congratulations , You Win In This Level {itemsDropped} Do You Want Use It In Next Level Y/N");
                    string response = Console.ReadLine().ToUpper();
                    if (response == "Y")
                    {
                        abood.OregenalHealth += 5;
                        potions.Description = "Congratulations We Added +5 on your => ";
                        Console.WriteLine($"{potions.Description} {itemsDropped} !");
                    }

                }
                else if (itemsDropped == "armor" && abood.Level < 3)
                {
                    Console.WriteLine($"Congratulations , You Win In This Level {itemsDropped} Do You Want Use It In Next Level Y/N");
                    string response = Console.ReadLine().ToUpper();
                    if (response == "Y")
                    {
                        abood.Defense += 5;
                        armor.Description = "Congratulations We Added +5 on your => ";
                        Console.WriteLine($"{armor.Description} {itemsDropped}!");
                    }
                }
                else if (itemsDropped == "weapons" && abood.Level < 3)
                {
                    Console.WriteLine($"Congratulations , You Win In This Level {itemsDropped} Do You Want Use It In Next Level Y/N");
                    string response = Console.ReadLine().ToUpper();
                    if (response == "Y")
                    {
                        abood.AttackPower += 5;
                        weapons.Description = "Congratulations We Added +5 on your => ";
                        Console.WriteLine($"{weapons.Description} {itemsDropped}!");
                    }
                }
                Console.ResetColor();
            }catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        //public static void DeseplayInfo(string itemsDropped) //I dont need to write this method ,becouse i can do the functionalty in the method above
        //{
        //    Potions potions = new Potions();
        //    Armor armor = new Armor();
        //    Weapons weapons = new Weapons();

        //    Console.ForegroundColor = ConsoleColor.Cyan;
        //    if (itemsDropped == "potions")
        //    {
        //        potions.Description = "Congratulations We Added +5 on your => ";
        //        Console.WriteLine($"{potions.Description} {itemsDropped} !");
                
        //    }
        //    else if (itemsDropped == "armor")
        //    {
        //        armor.Description = "Congratulations We Added +5 on your => ";
        //        Console.WriteLine($"{armor.Description} {itemsDropped}!");
        //    }
        //    else if (itemsDropped == "weapons")
        //    {
        //        weapons.Description = "Congratulations We Added +5 on your => ";
        //        Console.WriteLine($"{weapons.Description} {itemsDropped}!");
        //    }
        //    Console.ResetColor();
        //}
    }
}
