using System;
using System.Collections.Generic;

namespace Практика_Задание_6_6
{
    class Практика_Задание_6_6
    {
        public static List<double> list_sequence = new List<double> { };
        public static List<double> list_M = new List<double> { };
        public static double element = 0;
        public static int count = 0;
        static void Main()
        {
            Console.WriteLine("" +
                "Задание 6:\n\n" +
                "1. Ввести а1, а2, а3, М, N.\n\n" +
                "2. Построить последовательность чисел ак = ак–1 + ак-2 /3 + 3 * ак–3.\n\n" +
                "3. Проверить, существуют ли среди первых N элементов последовательности элементы, равные M,\n" +
                "и если существуют, то сколько их.\n\n" +
                "4. Напечатать N элементов последовательности после первых трёх и номера элементов, равных M.\n" +
                "-----------------------------");
            Console.WriteLine("1. Ввести а1, а2, а3, М, N.");
            Console.Write("Введите значение а1: ");
            double a1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение а2: ");
            double a2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение а3: ");
            double a3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение M: ");
            double M = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение N: ");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-----------------------------");
            Console.Write("Последовательность: ");
            RecursiveFunction(a1, a2, a3, N, element);
            foreach (double el in list_sequence)
            {
                count++;
                Console.Write(el + " ");
                if (el == M)
                {
                    list_sequence.Add(count);
                }
            }
            Console.WriteLine("");
            Console.Write($"Значение {M} имеет {list_M.Count} элементов. На позициях: ");
            try
            {
                foreach (int el in list_M)
                {
                    Console.Write($"{el} ");
                }
            }
            catch (InvalidOperationException) { };
            Console.ReadKey();
        }
        //ак = ак–1 + ак-2 /3 + 3 * ак–3
        static double RecursiveFunction(double a1, double a2, double a3, int N, double element)
        {
            element += a1 + (a2 / 3) + 3 * a3;
            list_sequence.Add(element);
            if (N != 1)
                return RecursiveFunction(a1, a2, a3, N - 1, element);
            else
                return 0;
        }
    }
}
