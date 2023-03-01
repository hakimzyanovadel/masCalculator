using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace masCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Введите начальное значение диапазона");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите конечное значение диапазона");
            b = int.Parse(Console.ReadLine());

            int height;
            Console.WriteLine("Введите количество строк в массиве");
            height = int.Parse(Console.ReadLine());
            int width;
            Console.WriteLine("Введите количество столбцов в массиве");
            width = int.Parse(Console.ReadLine());

            int[,] mas = new int[height, width];

            Random r = new Random();
            //int k = 0;
           
            /// зачем использовать допольнительные переменные счетчики
            /// у тебя в цикле уже создается переменная, которая
            /// уже как счетчик работает, используй его 
            for (int i = 0; i < height; i++)
            {
                // int l = 0;
                for ( int j = 0; j < width; j++) 
                {
                    mas[i, j] = r.Next(a, b); // mas[k, l] = r.Next(a, b);
                    Console.Write(mas[i, j] + " "); // Console.Write(mas[k, l] + " ");
                    // l++; +
                }
                Console.WriteLine();
                // k++;
            }

            Console.ReadKey();
        }
    }
}
