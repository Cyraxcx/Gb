﻿/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

Console.WriteLine("Введите число А");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int b = Convert.ToInt32(Console.ReadLine());
int numb (int a, int b)
    {
        int count = 2;
        int result;
            for(result = a * a; count < b; count++)
            {
                result = result * a;
            }
        return result;
    }
Console.WriteLine($"{a} в степени {b} = {numb(a,b)}");
    