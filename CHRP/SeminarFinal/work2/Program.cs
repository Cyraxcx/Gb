/*Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/
Console.WriteLine("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

int Sum(int m, int n)
{   
    if (n == 0) return 0;
    else return Sum(m, n - 1) + n; 
}   
Console.WriteLine("Сумма чисел: " + Sum(m,n));  