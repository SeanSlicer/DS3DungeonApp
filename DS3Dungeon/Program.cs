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
            string heroName;
            Class heroClass = 0;
            int KillCount = 0;

            ConsoleName.PrintName();
            Console.ResetColor();
            Console.Title = "The Castle of irithyll";
            Console.Write("Enter your name, Champion of ash: ");
            heroName = Console.ReadLine();
            Console.Clear();

            //Weapons
            Weapon shortSword = new Weapon("shortSword", 0, 1, 4, false);
            Weapon swordOfGods = new Weapon("Sword Of The Gods", 100, 100, 100, false);
            Weapon mace = new Weapon("mace", 10, 4, 10, false);
            Weapon claymore = new Weapon("claymore", 0, 7, 13, true);
            Weapon zweihander = new Weapon("zweihander", 0, 10, 15, true);


            //lothric Monster List
            Monster lothric_Knight = new Monster("Lothric Knight", 30, 4, 15, 15, 1, 5, "Knight of Lothric Castle");
            Monster dog = new Monster("Dog", 45, 4, 5, 5, 1, 2, "A scrawny ferocious dog peering at you for food");
            Spider deepAccursed = new Spider("Deep Accursed", 40, 15, 15, 10, 3, 7, "Large 6 legged spider, reminicent of a dog.", new Random().Next(2) == 1 ? true : false);
            Spider sewerCentipede = new Spider("Sewer Centipede", 65, 5, 10, 10, 1, 4, "a lifeless, pale body with 8 legs on both sides and hair covering the head.", new Random().Next(2) == 1 ? true : false);

            //Undead Settlement Monster List
            Monster thrall = new Monster("Thrall", 30, 4, 15, 15, 1, 5, "A small hooded creature carrying a knife.");
            Monster evangelist = new Monster("Evangelist", 45, 4, 5, 5, 1, 2, "A large Witch carrying a spiked metal mace.");
            Monster rootSkeleton = new Monster("Root Skeleton", 40, 15, 15, 10, 3, 7, "A gnarled looking skelaton with maggots inside.");
            Monster hallowManServant = new Monster("Hollow Manservant", 65, 5, 10, 10, 1, 4, "A large skelotinized looking creature with a red cloak on and a cage on his back.");

            //Boss list
            Monster Vordt = new Monster("Vordt Of The Boreal Valley", 85, 0, 100, 100, 1, 1, "A large armoured dog like creature, He has a large, frosted, spiked hammer who gaurds the undead settlement.");




            bool classMenu = true;

            do
            {

                Console.WriteLine("Choose your Class:\n" +
                   "1) Knight - High Life decent defense and hit chance\n" +
                   "2) Mercenary - High Life decent defense and hit chance\n" +
                   "3) Warrior - High Life decent defense and good hit chance\n" +
                   "4) Herald - High Life decent defense and hit chance\n" +
                   "5) Thief - Decent health and high hit chance\n" +
                   "6) Assassin - Decent healh and mid-high hit chance\n" +
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
            Weapon equippedWeapon = swordOfGods;
            Player player = new Player(heroName, 60, 10, 50, 50, heroClass, equippedWeapon);
            GameStatus gameStatus = GameStatus.None;

            do
            {
                //End of first boss
                if (KillCount == 16)
                {
                    Console.Clear();
                    Console.WriteLine("You have reached the Undead Settlement and cleared the first boss");
                    System.Threading.Thread.Sleep(2000);
                    Console.WriteLine("...");
                    System.Threading.Thread.Sleep(2500);
                    Console.Clear();
                }
                Console.WriteLine(Room.GetRoom());

                Monster[] monsters;
                if (KillCount > 15)
                {
                    //Undead settlment monsters
                    monsters = new[]
                    {
                        thrall, thrall, thrall, thrall, rootSkeleton, rootSkeleton, hallowManServant, evangelist
                    };
                }
                else
                {
                    monsters = new[]
                    {
                        //Lothric monsters
                        dog, dog, dog, dog, dog, dog, dog, lothric_Knight, lothric_Knight, sewerCentipede, deepAccursed
                    };
                }

                Random rand = new Random();
                int index = rand.Next(monsters.Length);
                Monster monster = monsters[index];


                //Boss call
                if (KillCount == 15)
                {
                    monster = Vordt;
                };

                Console.WriteLine(MonsterIntro.GetIntro(), monster.Name);
                //menu
                MenuSelect menuSelect = new MenuSelect(heroName, player, monster);
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
        }
    }
}
