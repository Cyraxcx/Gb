/*Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

int[,] matr = new int[3,3];
int s1 = 0;
int s2 = 0;
int s3 = 0;
void PrintArray(int[,] matr)

{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]}    ");

        }
        Console.WriteLine();
    }

}
void FillArray(int[,] matr) 

{

    for (int i = 0; i < matr.GetLength(0); i++) 
        for (int j = 0; j <matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(0,99);
            s1= (matr[0,0]+matr[1,0]+matr[2,0]) /  matr.GetLength(0) ;
            s2= (matr[0,1]+matr[1,1]+matr[2,1]) /  matr.GetLength(0) ;
            s3= (matr[0,2]+matr[1,2]+matr[2,2]) /  matr.GetLength(0) ;
        }

}
FillArray(matr);
PrintArray(matr);
Console.WriteLine();
Console.Write($"Среднее арифмeтическое 1 столбца: {s1}, 2 столбца: {s2}, 3 столбца: {s3} ");