﻿using System;

namespace _2курс4._1лаб
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число: ");
            double A = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            double B = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Сумма: " + Convert.ToDouble(A + B));
            Console.WriteLine("Разность: " + Convert.ToString(A - B));
            Console.WriteLine("Умножение: " + Convert.ToString(A * B));
            Console.WriteLine("Деление: " + Convert.ToString(A / B));

            Console.ReadKey();

        }
    }
}
