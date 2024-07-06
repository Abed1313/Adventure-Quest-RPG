using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace AdventureQuestRPG
{
    public class BattleSystem : Inventory
    {
        public static void StartBattel(Monster enemy, Player player)
        {
            
            try
            {
                while (player.Health > 0 && enemy.Health > 0)
                    {

                        // Player's Turn
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"It's the {player.Name} turn.");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Attack(player, enemy);
                        Console.ResetColor();
                    if (enemy.Health <= 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine($"Victory! The {enemy.Name} has been defeated.");
                            Console.WriteLine($"The {player.Name} won");
                            Console.ResetColor();
                        player.CheckExperiencePoints(10);    //from Characters
                        DropInventory(player);             //from Inventory
                        break;
                        }

                        // Enemy's Turn
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"It's the {enemy.Name} turn.");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Attack(enemy, player);
                        Console.ResetColor();

                        if (player.Health <= 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine($"Defeat! The {player.Name} has been defeated.");
                            Console.WriteLine($" --| The {enemy.Name} won |-- ");
                            Console.ResetColor();
                            //Console.WriteLine($"you are loss , you are stll in Level {player.Level}");
                            break;
                        }
                    }
            }catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }
        public static void Attack(dynamic attacker, dynamic target)
        {
            try
            {
                int damig = 0;
                if (target.Health > 0)
                {
                    damig = attacker.AttackPower - target.Defense;
                    target.Health -= damig;
                    Console.WriteLine($"Strike Force : {attacker.AttackPower}");
                    Console.WriteLine($"{attacker.Name} attacks {target.Name} for {damig} damage. {target.Name} now has {target.Health} health.");
                }
                else
                {
                    target.Health = 0;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"{attacker.Name} attacks {target.Name} for {damig} damage. {target.Name} now has {target.Health} health. {target.Name} is defeated!");
                    Console.ResetColor();
                }

            }catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        
        //public static int CalculateDamage(Characters attacker, Characters target)
        //{
        //    return attacker.AttackPower - target.Defense;
        //}
    }
}

//    while (player.Health > 0 && enemy.Health > 0)
//        { 
//            Console.WriteLine("It's the player's turn.");
//            Attack(player, enemy);
//            if (enemy.Health <= 0)
//            {
//                Console.WriteLine($"Victory! The {enemy.Name} has been defeated.");
//                break;
//            }
//            Console.WriteLine("It's the enemy's turn.");
//            Attack(enemy, player);
//            if (player.Health <= 0)
//            {
//                Console.WriteLine($"Defeat! The {player.Name} has been defeated.");
//                break;
//            }
//        }