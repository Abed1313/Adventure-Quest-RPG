using AdventureQuestRPG;
using System.Threading;

namespace AdventureQuestRPGTests
{
    public class UnitTest1
    {
        [Fact]
        public void PlayerAttacks()
        {
            //Arreng
            Player player = new Player("Abood", 100, "Sword");
            Random random = new Random();                                  // Random Monster List
            Monster[] monsters = { new Falcon(), new Dragon(), new Eagle() };
            int index = random.Next(monsters.Length);
            Monster monster = monsters[index];

            //Act
            BattleSystem battleSystem = new BattleSystem();
            BattleSystem.StartBattel(monster, player);

            //Assert
            Assert.True(monster.Health < 100);

        }
        [Fact]
        public void EnemyAttack()
        {
            //Arreng
            Player player = new Player("Abood", 100, "Sword");
            Random random = new Random();                                  // Random Monster List
            Monster[] monsters = { new Falcon(), new Dragon(), new Eagle() };
            int index = random.Next(monsters.Length);
            Monster monster = monsters[index];

            //Act
            BattleSystem battleSystem = new BattleSystem();
            BattleSystem.StartBattel(monster, player);

            //Assert
            Assert.True(player.Health < 100);
        }

        [Fact]
        public void WinnerHasHhealthGreaterThanZero()
        {
            //Arreng
            Player player = new Player("Abood", 100, "Sword");
            Random random = new Random();                                  // Random Monster List
            Monster[] monsters = { new Falcon(), new Dragon(), new Eagle() };
            int index = random.Next(monsters.Length);
            Monster monster = monsters[index];

            //Act
            BattleSystem battleSystem = new BattleSystem();
            BattleSystem.StartBattel(monster, player);

            //Assert
            Assert.True(player.Health > 0 || monster.Health >0);
        }

        

    }
}