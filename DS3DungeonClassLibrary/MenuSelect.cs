using System;

namespace DS3DungeonClassLibrary
{
    public sealed class MenuSelect
    {
        private readonly string heroName;

        private readonly Player player;

        private readonly Monster monster;

        public MenuSelect(string heroName, Player player, Monster monster)
        {
            this.heroName = heroName;
            this.player = player;
            this.monster = monster;
        }

        public GameStatus CallMenu(ref int KillCount)
        {
            GameStatus gameStatus = GameStatus.None;
            Console.Title = $"{heroName}'s Journey";
            Console.WriteLine($"\nLife: {player.Life}        Score: {KillCount}\n" +
            "Champion of ash, Choose an action:\n" +
                "A)ttack\n" +
                "F)lee\n" +
                "V)iew Stats\n" +
                "M)onster Stats\n");
            ConsoleKey userChoice = Console.ReadKey().Key;
            Console.Clear();
            switch (userChoice)
            {

                case ConsoleKey.A:
                    Combat.Battle(player, monster);
                    if (monster.Life <= 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("You killed the " + monster.Name + "!");
                        Console.ResetColor();
                        gameStatus = GameStatus.Reload;
                        System.Threading.Thread.Sleep(2000);
                        KillCount++;
                    }
                    break;

                case ConsoleKey.F:
                    if (KillCount != 15)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Dodge rolled far enough away");
                        Console.ResetColor();
                        Console.WriteLine($"The {monster.Name} attacks you as you turn to flee!");
                        Combat.Attack(monster, player);
                        gameStatus = GameStatus.Reload;
                    }
                    if (KillCount == 15)
                    {
                        Combat.Attack(monster, player);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You might not want to try to do that again");
                        Console.ResetColor();
                    }
                    break;

                case ConsoleKey.V:
                    Console.WriteLine(player);
                    break;

                case ConsoleKey.M:
                    Console.WriteLine(monster);
                    break;

                case ConsoleKey.Escape:
                    Console.WriteLine("You have chosen to flee hmmmm...");
                    gameStatus = GameStatus.Exit;
                    break;
                default:
                    Console.WriteLine("You chose an incorrect option ash...");
                    break;
            }

            return gameStatus;
        }
    }
}
