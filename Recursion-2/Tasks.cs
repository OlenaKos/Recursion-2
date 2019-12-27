using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion_2
{
    class Tasks
    {
        public string[] MenuArray()
        {
            string[] str = {
                "1.Разработать рекурсивный метод, который по заданному натуральному числу N\n" +
                "выведет на экран все натуральные числа не больше N в порядке возрастания.",
                "2.Разработать рекурсивный метод, который по заданному натуральному числу N\n" +
                 "выведет на экран все натуральные числа не больше N в порядке убывания.",
                "3.Разработать рекурсивный метод для вывода на экран стихотворения.",
                "4.Дано натуральное число N. Разработать рекурсивный метод для вывода на экран\n" +
                "следующей последовательности чисел:",
                "5.Дано натуральное число N. Разработать рекурсивный метод для вывода на экран\n" +
                "следующей последовательности чисел:",
                "6.Дано натуральное четное число N. Разработать рекурсивный метод для вывода на экран\n" +
                "следующей картинки:",
                "7.Дано натуральное четное число.Разработать рекурсивный метод для вывода на экран\n" +
                "следующей картинки:",
                "8.Дано натуральное число N. Разработать рекурсивный метод для вывода на экран\n" +
                "следующей картинки:",
                "9.Разработать рекурсивный метод для вывода на экран следующей картинки:",
                "10.Exit"
            };

            return str;
        }


        public void Task1(int n)
        {


            if (n > 0)
            {
                Task1(n - 1);
                Console.Write(n + " ");
            }
        }

        public int Task2(int n)
        {

            if (n == 1)
            {
                Console.Write(n + " ");
                return 1;
            }
            else
            {
                Console.Write(n + " ");
                return Task2(n - 1);
            }

        }

        public void Task3(int n)
        {

            if (n > 0)
            {
                Console.WriteLine(n + " лунатиков жили на луне");
                Console.WriteLine(n + " лунатиков ворочались во сне");
                Console.WriteLine("Один из лунатиков упал с луны во сне");
                if (n != 1)
                    Console.WriteLine(n - 1 + " лунатиков осталось на луне");
                Task3(n - 1);
            }
            else
                Console.WriteLine("И больше лунатиков не стало на луне");
        }

        public void Task4(int n)
        {
            if (n > 0)
            {
                Task4(n - 1);
                for (int i = 0; i < n; i++)
                {
                    Console.Write(n + " ");
                }
                Console.WriteLine();
            }
        }

        public void Task5(int n)
        {
            if (n > 0)
            {
                Task5(n - 1);
                for (int i = 0; i < n; i++)
                {
                    Console.Write(n - i + " ");
                }
                Console.WriteLine();
            }
        }

        public void Task6(int n)
        {

            if (n > 0)
            {
                if (n > 0)
                {
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                    Task6(n - 1);
                }
            }
        }

        public void Task7(int n)
        {


            if (n > 1)
            {
                if (n % 2 == 0)
                    Console.WriteLine(new string('*', n));

                Task7(n - 1);

                if (n % 2 == 0)
                    Console.WriteLine(new string('*', n));
            }
        }

        public void Task8(int n, int z = 1)
        {


            for (int i = 0; i < 2 * z - 1; ++i)
                Console.Write(z);
            Console.WriteLine();

            if (2 * z - 1 < n)
            {
                Task8(n, z + 1);

                for (int i = 0; i < 2 * z - 1; ++i)
                    Console.Write(z);
                Console.WriteLine();

            }

        }

        public void Task9(int n = 80, int c = 65)
        {
            //9.Разработать рекурсивный метод для вывода на экран следующей картинки:

            //AAAAAAAAAA…AAAAAAAAAA(80 раз)
            //BBBBBBBBB…BBBBBBBB(78 раз)
            //СССССССС …СССССССС(76 раз)
            //…	…
            //YYY…YYY(32 раза)
            //ZZ...ZZ(30 раз)
            //YYY…YYY(32 раза)
            //…	…
            //СССССССС …СССССССС(76 раз)
            //BBBBBBBBB…BBBBBBBB(78 раз)
            //AAAAAAAAAA…AAAAAAAAAA(80 раз)
            if (n >= 30)
            {
                char b = (char)c;
                Console.WriteLine(new string(b, n));
                Task9(n - 2, c + 1);
                Console.WriteLine(new string(b, n));
            }
        }
    }
}
