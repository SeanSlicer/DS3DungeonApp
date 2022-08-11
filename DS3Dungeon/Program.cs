using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DS3DungeonClassLibrary;

namespace DS3Dungeon
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            string heroName;
            Class heroClass = 0;
            int KillCount = 0;

            ConsoleName.PrintName();
            Console.ResetColor();
            Console.Title = "The Castle of irithyll";
            Console.Write("Enter your name, Champion of ash: ");
            heroName = Console.ReadLine();
            Console.Clear();
            bool classMenu = true;
            Inventory inventory = new Inventory();
            do
            {

                Console.WriteLine("Choose your Class:\n" +
                   "1) Knight - High Life decent defense and hit chance\n" +
                   "2) Mercenary - High Life decent defense and hit chance\n" +
                   "3) Warrior - High Life decent defense and good hit chance\n" +
                   "4) Herald - High Life decent defense and hit chance\n" +
                   "5) Thief - Decent health and high hit chance\n" +
                   "6) Assassin - Decent health and mid-high hit chance\n" +
                   "7) Deprived - Very low health and extremely high hit chance\n");
                ConsoleKey classChoice = Console.ReadKey().Key;
                Console.Clear();
                switch (classChoice)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        heroClass = Class.Knight;
                        classMenu = false;
                        break;

                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        heroClass = Class.Mercenary;
                        classMenu = false;
                        break;

                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        heroClass = Class.Warrior;
                        classMenu = false;
                        break;

                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        heroClass = Class.Herald;
                        classMenu = false;
                        break;

                    case ConsoleKey.D5:
                    case ConsoleKey.NumPad5:
                        heroClass = Class.Thief;
                        classMenu = false;
                        break;

                    case ConsoleKey.D6:
                    case ConsoleKey.NumPad6:
                        heroClass = Class.Assassin;
                        classMenu = false;
                        break;

                    case ConsoleKey.D7:
                    case ConsoleKey.NumPad7:
                        heroClass = Class.Deprived;
                        classMenu = false;
                        break;

                    default:
                        Console.WriteLine($"{classChoice} was not a valid option. Please choose again.");
                        break;
                }

            } while (classMenu);

            Console.Clear();

            Console.WriteLine($"Welcome, {heroName}\nYou must seek out the lords of cinder");

            System.Threading.Thread.Sleep(2500);

            Console.WriteLine("Your expedition starts now ash.\n");

            System.Threading.Thread.Sleep(2500);
            Console.Clear();
            //Player Creation
            Weapon equippedWeapon = Weapons.swordOfGods;
            Player player = new Player(heroName, 60, 10, 50, 50, heroClass, equippedWeapon);
            GameStatus gameStatus = GameStatus.None;

            do
            {

                Console.WriteLine(Room.GetRoom());

                Monster[] monsters;
                if (KillCount > 15)
                {
                    //Undead settlement monsters
                    monsters = new[]
                    {
                       Monsters.thrall, Monsters.thrall, Monsters.thrall, Monsters.thrall, Monsters.rootSkeleton, Monsters.rootSkeleton, Monsters.hallowManServant, Monsters.evangelist
                    };
                }
                else
                {
                    monsters = new[]
                    {
                        //Lothric monsters
                        Monsters.dog, Monsters.dog, Monsters.dog, Monsters.dog, Monsters.dog, Monsters.dog, Monsters.dog, Monsters.lothric_Knight, Monsters.lothric_Knight, Monsters.sewerCentipede, Monsters.deepAccursed
                    };
                }


                int index = rand.Next(monsters.Length);
                Monster monster = monsters[index];


                //Boss call
                if (KillCount == 15)
                {
                    monster = Monsters.Vordt;
                };

                Console.WriteLine(MonsterIntro.GetIntro(), monster.Name);
                //menu
                MenuSelect menuSelect = new MenuSelect(heroName, player, monster, inventory);
                do
                {
                    gameStatus = menuSelect.CallMenu(ref KillCount);
                    if (player.Life <= 0)
                    {
                        Console.WriteLine($"The {monster.Name} has put an end to your quest");
                        gameStatus = GameStatus.Exit;
                    }

                } while (gameStatus == GameStatus.None);

            } while (gameStatus != GameStatus.Exit);

            Console.WriteLine("GAME OVER!");
            System.Threading.Thread.Sleep(250);
        }
    }
}
