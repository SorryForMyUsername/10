using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Компьютерный_практикум__10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача 1. В одномерном массиве из 8 целых чисел с явной инициализацией
            //обнулить значения трех элементов, начиная с индекса, равного 1.
            //int[] omas = new int[] { 3, 4, 6, 2, 7, 2, 9, -1 };
            ////for (int i = 0; i < omas.Length; i++)
            ////{
            ////    if (i >= 1 && i < 1 + 3)
            ////    {
            ////        omas[i] = 0;
            ////    }
            ////}
            //Array.Clear(omas, 1, 3);
            //foreach (int el in omas)
            //{
            //    Console.WriteLine(el);
            //}

            //Задача 2. Изменить размер одномерного массива.
            //int[] omas = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //foreach(int el in omas)
            //{
            //    Console.WriteLine(el);
            //}

            //Array.Resize(ref omas, 5);
            //Console.WriteLine("Массив с длиной 5:");
            //foreach (int el in omas)
            //{
            //    Console.WriteLine(el);
            //}

            //Array.Resize(ref omas, 15);
            //Console.WriteLine("Массив с длиной 15:");
            //foreach (int el in omas)
            //{
            //    Console.WriteLine(el);
            //}

            //Задача 3. Найти индекс первого отрицательного элемента одномерного массива,
            //заполненного случайным образом в диапазоне от -5 до 5.
            //Random rnd = new Random();
            //int[] omas = new int[10];
            //for (int i = 0; i < omas.Length; i++)
            //{
            //    omas[i] = rnd.Next(-5, 5);
            //    Console.WriteLine($"omas[{i}] = {omas[i]}");
            //}
            ////int indexOfNegativeNumber = -1;
            ////for(int i = 0; i < omas.Length; i++)
            ////{
            ////    if(omas[i] < 0)
            ////    {
            ////        indexOfNegativeNumber = i;
            ////        break;
            ////    }
            ////}
            ////Console.WriteLine($"Индекс первого отрицательного элемента массива: {indexOfNegativeNumber}");
            //Console.WriteLine($"Индекс первого отрицательного элемента массива: {Array.FindIndex<int>(omas, prop => prop < 0)}");

            //Сортировка массива
            int[] omas = new int[] { 4, 6, -2, 0, 6, 1, 2 };
            Console.WriteLine("Неотсортированный массив: ");
            foreach(int el in omas)
            {
                Console.Write($"{el}  ");
            }
            Array.Sort(omas);
            Console.WriteLine("\nОтсортированный массив: ");
            foreach (int el in omas)
            {
                Console.Write($"{el}  ");
            }

            Console.ReadKey();
        }
    }
}
