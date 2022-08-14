/*Задача 50. Напишите программу, которая на вход принимает позиции элемента 
либо значение элемента в двумерном массиве, и возвращает значение 
либо индекс этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
4 -> такой элемент есть и его индекс 0, 1 (идеально было б найти все вхождения этого элемента)
2, 3 -> такой элемент есть и равен 4
5, 5 -> такой элемент отсутствует*/

Console.WriteLine("Введите кол-во столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение элемента: ");
int x = Convert.ToInt32(Console.ReadLine());
int[,] matr = new int[m,n];

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]}   ");

        }
        Console.WriteLine();
    }

}

void FillArray(int[,] matr) 

{

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(0,5);

            if(matr[i,j]==x) Console.WriteLine($"Такое число есть его индекс: {i}.{j}   ");

        }
    } 

}

FillArray(matr);
PrintArray(matr);