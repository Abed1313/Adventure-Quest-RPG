using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace AdventureQuestRPG
{
    public class Characters : IBattleStates
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int AttackPower { get; set; }
        public string Defense { get; set; }

        public int GenerateAttackPower()
        {
            Random random = new Random();
            return random.Next(0, 50);
        }
    }
                                    // Player Class //
    public class Player : Characters 
    {
        //Constructor 
        public Player(string name, int health,  string defense) 
        {
            Name = name;
            Health = health;
            Defense = defense;
            AttackPower = GenerateAttackPower();
        }
        public void DesblayInfo()
        {
            Console.WriteLine($"Player Name: {Name} , Health: {Health}  , Defense: {Defense}");
        }
    }
                                // Monster abstract Class //
    public abstract class Monster : Characters
        {
        protected Monster(string name, int health, string defense)
        {
            Name = name;
            Health = health;
            Defense = defense;
            AttackPower = GenerateAttackPower();
        }
    }
                                     // Dragon Class //
        public class Dragon : Monster
            {
        public Dragon() : base("Dragon", 100, "Scales") { }

        public void DesblayInfo()
        {
            Console.WriteLine($"Monster Name: {Name} , Health: {Health}  , Defense: {Defense}");
        }

    }
                                      // Falcon Class //
    public class Falcon : Monster 
    {
        public Falcon() : base("Falcon", 75, "Feathers") { }
        public void DesblayInfo()
        {
            Console.WriteLine($"Monster Name: {Name} , Health: {Health}  , Defense: {Defense}");
        }
    }

    public class Eagle : Monster          // BossMonster 
    {
        public Eagle() : base("Eagle", 150, "Feathers") { }
        public void DesblayInfo()
        {
            Console.WriteLine($"Monster Name: {Name} , Health: {Health}  , Defense: {Defense}");
        }
    }


}

