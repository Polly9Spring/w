using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Razr4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество элементов: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Введите число: ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int j = arr.Length-1; j > -1; j--)
            {
                Console.WriteLine(arr[j]);
            }
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    sum = sum + arr[i];
                }
            }
            Console.WriteLine("Сумма четных чисел равна: " + sum);
            int minim = arr[0];
            for (int i = 1; i<arr.Length; i++)
            {
                if (arr[i] < minim)
                {
                    minim = arr[i];
                }
            }
            Console.WriteLine("Минимальный элемент массива: " + minim);
            Console.ReadKey();
}
    }
}
