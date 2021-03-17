using System;
using System.Collections.Generic;
using System.Linq;

namespace Autospace1
{
    class Program
    {
        //1a. Напишите алгоритм для сложения всех чётных чисел в массиве на LINQ.
        public static int AddEven(IEnumerable<int> list)
        {
            return list.Where(x => x % 2 == 0).Sum();
        }

        //1b.Напишите метод для удаления повторяющихся символов из строки.
        public static string DelRepeats(string s)
        {
            return String.Concat(s.Distinct().ToArray());
        }

        //1c  Напишите метод удаления всех нечетных элементов списка
        // как я понял это 1-й, 3-й, 5-й и т.д. элементы списка по счёту
        public static void DelOdd<T>(List<T> list)
        {
            for (int i = list.Count-1; i>-1; i--)
            {
                if (i%2 == 0)
                {
                    list.RemoveAt(i);
                }
            }
        }
        static void Main(string[] args)
        {
            var numbers = new int[] { 1, 2, 3, 4, 5, 6, 6 };
            var str = "aaaabbbcccdddaaadd22dd33";
            var list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine(AddEven(numbers));
            Console.WriteLine(DelRepeats(str));
            DelOdd(list);
            foreach (var i in list)
            {
                Console.WriteLine(i);
            }
        }
    }
}
