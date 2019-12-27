using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion_2
{
    class Menu
    {
        public int Index { get; set; } = 0;
        public int SelectMenu(string[] MenuItem)
        {
            // int Index = 0;
            bool flag = true;

            while (flag)
            {
                for (int i = 0; i < MenuItem.Length; i++)
                {
                    if (i == Index)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine(MenuItem[i]);
                    }
                    else
                    {
                        Console.WriteLine(MenuItem[i]);

                    }
                    Console.ResetColor();
                }
                ConsoleKeyInfo ckey = Console.ReadKey();


                if (ckey.Key == ConsoleKey.DownArrow)
                {
                    if (Index == MenuItem.Length - 1)
                    {
                        Index = 0;
                    }
                    else
                        Index++;
                }

                else if (ckey.Key == ConsoleKey.UpArrow)
                {
                    if (Index <= 0)
                    {
                        Index = MenuItem.Length - 1;
                    }
                    else
                        Index--;
                }

                else if (ckey.Key == ConsoleKey.Enter)
                {
                    Console.Clear();

                    return Index;
                }

                Console.Clear();

            }
            return Index;
        }
    }
}
