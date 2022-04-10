using System;
using System.Threading;

using static System.Console;
using static System.ConsoleColor;

namespace DS3DungeonClassLibrary
{
    public static class ConsoleName
    {
        private static void WriteText(ConsoleColor color, int center, string centerText)
        {
            const int DelayAfterPrint = 250;

            ForegroundColor = color;
            WriteLine(string.Format($"{{0,{center}}}", centerText));
            Thread.Sleep(DelayAfterPrint);
            Clear();
        }

        public static void PrintName()
        {
            const int ColorIterations = 3;
            string centerText = "Champion of Irithyll";
            int center = ((WindowWidth / 2) + (centerText.Length / 2));
            var colors = new[] { Red, Blue, Yellow, Green, Magenta };
            for (int i = 0; i < ColorIterations; i++)
            {
                foreach (var color in colors)
                {
                    WriteText(color, center, centerText);
                }
            }
        }


    }
}
