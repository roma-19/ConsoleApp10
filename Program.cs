using System;

namespace ConosleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 1.

            Random ran = new Random();
            int[] mas = new int[22];
            int sum = 0;
            int count = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = ran.Next(300, 551);
                //Console.WriteLine($"mas[{i}] = {mas[i]} мм");
                sum += mas[i];
                count++;
            }
            double mid = sum / count;
            Console.WriteLine($"Среднее количество осадков = {mid} мм\n");
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] > mid)
                {
                    double dif = mas[i] - mid;
                    Console.WriteLine($"Отклонение = {dif}");
                }
                else if (mas[i] < mid)
                {
                    double dif1 = mid - mas[i];
                    Console.WriteLine($"Отклонение = {dif1}");
                }
                else
                {
                    Console.WriteLine("Отклонение = 0");
                }
            }
            Console.ReadKey();
        }
    }
}