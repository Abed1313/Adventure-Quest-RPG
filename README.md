# AdventureQuestRPG
AdventureQuestRPG is a text-based role-playing game where players control a character named Abood, who battles various monsters and levels up by gaining experience points. The game includes various elements like characters, monsters, battles, items, and different locations for adventures.

## Classes and Structure
### Program.cs
The entry point of the game. It contains the Main method, which initializes the game and handles the main game loop.

### Characters.cs
Defines the base Characters class, which includes properties and methods common to all characters in the game, such as Name, Health, AttackPower, Defense, ExperiencePoints, and Level. It also includes methods for checking experience points and leveling up.

### Player.cs
Inherits from Characters and adds specific properties and methods for the player character, such as OriginalHealth and Inventory. The Abood class is a specific implementation of the player character.

### Monster.cs
An abstract class that inherits from Characters and serves as a base for all monster types in the game. Specific monsters like Dragon, Falcon, and Eagle inherit from this class.

### BattleSystem.cs
Handles the battle mechanics between the player and monsters. It includes methods for starting a battle and attacking.

### Adventure.cs
Defines the Game method, which starts a new adventure by selecting a random monster and location. It also manages the flow of the game, including battles and experience point allocation.

### Inventory.cs
Handles item drops and the player's inventory. It includes methods for dropping items after a battle and applying item effects to the player.

### Items.cs
Defines the base Items class and specific item types like Potions, Armor, and Weapons.

## Gameplay
Starting the Game: The game starts with the player character Abood. The player is prompted to choose a location for the adventure.
Battle: The player engages in a battle with a randomly selected monster. Both the player and the monster take turns attacking each other until one is defeated.
Experience and Leveling Up: After defeating a monster, the player gains experience points. If the player gains enough experience points, they level up, increasing their stats.
Item Drops: The player may receive item drops after defeating a monster. These items can enhance the player's health, defense, or attack power for future battles.
Replay: After a battle, the player is given the option to play again or exit the game.

## Console Output Explanation
The console output of the AdventureQuestRPG game guides the player through the various stages of gameplay, providing feedback and instructions. Here's a detailed explanation of what the player sees in the console:

### Game Start
Welcome Message and Initial Stats: The game starts with a welcome message, introducing the player to the game and displaying the initial stats of the player character, Abood. The stats include Health, Defense, and Experience Points.
### Location Selection Prompt:
The player is prompted to choose a location for the adventure from a list of available options (e.g., DeadSea, WadiRumDesert, AjlounForest, Petra, MountNebo).
Location Selection and Battle Start
Selected Location and Monster Introduction: After selecting a location, the game confirms the chosen location and introduces the monster that Abood will battle. The monster's stats, including Health and Defense, are displayed.
Battle Commencement: The battle between Abood and the monster begins, with turns alternating between the player and the monster.
### Battle Turns
Player's Turn: The game indicates that it's Abood's turn to attack. Abood's attack power is calculated, and the damage inflicted on the monster is displayed. The monster's updated health is shown.
Monster's Turn: The game indicates that it's the monster's turn to attack. The monster's attack power is calculated, and the damage inflicted on Abood is displayed. Abood's updated health is shown.
Alternating Turns: This process continues with turns alternating between Abood and the monster until one of them is defeated.
### Battle Victory or Defeat
Victory Announcement: If Abood defeats the monster, the game announces the victory and the monster's defeat. Abood's experience points are updated, and any level-ups are announced.
Defeat Announcement: If Abood is defeated, the game announces the defeat and the monster's victory.
### Item Drops and Usage
Item Drop: After a victory, the game may drop an item (e.g., potions, armor, weapons). The player is prompted to decide whether to use the item in the next level.
Item Effects: If the player chooses to use the item, the corresponding stat (Health, Defense, or Attack Power) is increased, and the game confirms the effect.
### Replay or Exit
Replay Prompt: After a battle, the player is asked whether they want to play again or exit the game.
Exit Message: If the player chooses to exit, the game displays a closing message encouraging the player to return for a new adventure.