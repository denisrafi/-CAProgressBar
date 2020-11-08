using System;

namespace ByDenisRafi
{
    class Program
    {
        static void Main()
        {
            Console.Title = "C# CA ProgressBar | ByDenisRafi";
            ProgressBarCiz(2, 1, 60, 0, ConsoleColor.DarkRed);
            ProgressBarCiz(2, 5, 70, 1, ConsoleColor.Blue);
            ProgressBarCiz(2, 10, 80, 2, ConsoleColor.Green);
            ProgressBarCiz(2, 15, 90, 3, ConsoleColor.Cyan);
            ProgressBarCiz(2, 20, 100, 4, ConsoleColor.Yellow);
            Console.Read();
        }
        public static void ProgressBarCiz(int sol, int ust, int deger, int isaret, ConsoleColor color)
        {
            char[] symbol = new char[5] { '\u25A0', '\u2592', '\u2588', '\u2551', '\u2502' };
            
            int maxBarSize = Console.BufferWidth - 1;
            int barSize = deger;
            decimal f = 1;
            if (barSize + sol > maxBarSize)
            {
                barSize = maxBarSize - (sol + 5); 
                f = (decimal)deger / (decimal)barSize;
            }
            Console.CursorVisible = false;
            Console.ForegroundColor = color;
            Console.SetCursorPosition(sol + 5, ust);
           
            for (int i = 0; i < barSize + 1; i++)
            {
                System.Threading.Thread.Sleep(10);
                Console.Write(symbol[isaret]);
                Console.SetCursorPosition(sol, ust);
                Console.Write("%" + (i * f).ToString("0,0"));
                Console.SetCursorPosition(sol + 5 + i, ust);
            }
            Console.ResetColor();
        }
    }
}
