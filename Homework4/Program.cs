using System;
using System.Collections.Generic;
using System.IO;
using ArrayHelper;

namespace Homework4
{
    public static class MyArray
    {
        public static int[] GetRandArray(int count, int min, int max)
        {
            int[] array = new int[count];  
            Random r = new Random();
            for (int i = 0; i < count; i++)
                array[i] = r.Next(min, max);

            return array;
        }
        public static void Print(int[] a)
        {
            Console.WriteLine("Массив: ");
            foreach (int v in a)
                Console.Write(v + " ");
            Console.WriteLine();
        }
        public static int OneOfTheTwo(int[] a)          //Задание 1 и 2(а)
        {
            int sum = 0;
            for (int i = 1; i < a.Length; i++)
                if (a[i]%3 == 0 ^ a[i-1] % 3 == 0) sum++;
            return sum;
        }
        public static int[] Read()                      //Задание 2(б,в)
        {
            try
            {
                StreamReader stream = new StreamReader("..\\..\\data.txt");
                int N = File.ReadAllLines("..\\..\\data.txt").Length;           // Считываем количество элементов массива
                int[] a = new int[N];

                for (int i = 0; i < N; i++)
                {
                    a[i] = int.Parse(stream.ReadLine());
                }
                stream.Close();

                return a;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Task01_02();
            Task03();
        }

        private static void Task03()                    //Задание 3.
        {
            Class1 class1 = new Class1(5,2,1);
            Console.WriteLine("Масив, заданный по значениям размер/шаг/начальное_значение: {0}",class1);
            Console.WriteLine("Сумма массива : {0};",class1.Sum); 
            class1.Multi(5);
            Console.WriteLine("Умножили каждый элемент массива на 5: {0}",class1);
            int[] b = { 1, 2, 3, 4, 4, 4 };

            Class1 class2 = new Class1(b);
            Console.WriteLine($"Массив [1,2,3,4,4,4]. MaxCount = {class2.MaxCount}");
            Console.WriteLine();
            Console.WriteLine("Частота вхождения каждого элемента в массив");
            foreach (var map in class2.Map)
            {
                Console.WriteLine($"key: {map.Key}  value: {map.Value}");
            }
            Console.WriteLine();
            Console.WriteLine("Работа метода Inverse");
            Class1 class3 = class2.Inverse();
            Console.WriteLine("Исходный массив : {0}", class2);
            Console.WriteLine("Инверсированный массив : {0}", class3);

            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();
            Console.Clear();
        }

        private static void Task01_02()
        {
            int[] a = MyArray.GetRandArray(20, -10000, 10001);
            
            MyArray.Print(a);
            Console.WriteLine("Количество пар = {0};",MyArray.OneOfTheTwo(a));
            Console.WriteLine();

            int[] test = MyArray.Read();
            if(test != null)
            {
                MyArray.Print(test);
                Console.WriteLine("Test.Количество пар = {0};", MyArray.OneOfTheTwo(test));
            }

            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
