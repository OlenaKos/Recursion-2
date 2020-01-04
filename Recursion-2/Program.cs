using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion_2
{
    class Program
    {
        static void Main()
        {
            bool flag = true;
            Tasks work = new Tasks();
            Menu menu = new Menu();
            while (flag)
            {
                switch (menu.SelectMenu(work.MenuArray()))
                {
                    case 0:
                        {
                            Console.Write("Введите число: ");
                            string s = Console.ReadLine();
                            int a = int.Parse(s);
                            work.Task1(a);
                            break;
                        }

                    case 1:
                        {
                            Console.Write("Введите число: ");
                            string s = Console.ReadLine();
                            int a = int.Parse(s);
                            work.Task2(a);
                            break;
                        }

                    case 2:
                        {
                            Console.Write("Введите число: ");
                            string s = Console.ReadLine();
                            int a = int.Parse(s);
                            work.Task3(a);
                            break;
                        }

                    case 3:
                        {
                            Console.Write("Введите число: ");
                            string s = Console.ReadLine();
                            int a = int.Parse(s);
                            work.Task4(a);
                            break;
                        }

                    case 4:
                        {
                            Console.Write("Введите число: ");
                            string s = Console.ReadLine();
                            int a = int.Parse(s);
                            work.Task5(a);
                            break;
                        }

                    case 5:
                        {
                            Console.Write("Введите число: ");
                            string s = Console.ReadLine();
                            int a = int.Parse(s);
                            work.Task6(a);
                            break;
                        }

                    case 6:
                        {
                            Console.Write("Введите число: ");
                            string s = Console.ReadLine();
                            int a = int.Parse(s);
                            work.Task7(a);
                            break;
                        }

                    case 7:
                        {
                            Console.Write("Введите число: ");
                            string s = Console.ReadLine();
                            int a = int.Parse(s);
                            work.Task8(a);
                            break;
                        }

                    case 8: work.Task9(); break;
                    case 9: flag = false; break;
                }

                Console.ReadKey();
                Console.Clear();
            }

        }
    }
}
