/*Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, заданы 2 массива:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
и
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7
Их произведение будет равно следующему массиву:
1 20 56 10
20 81 8 6
56 8 4 24
10 6 24 49*/
Console.WriteLine("Введите кол-во строк и столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] array1 = new int[m,n];
int[,] array2 = new int[m,n];
int[,] res = new int[m,n];
void PrintArray(int[,] array1)
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            Console.Write($"{array1[i, j]}   ");

        }
        Console.WriteLine();
    }

}

void FillArray(int[,] array1) 
{

    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {

            array1[i, j] = new Random().Next(1,10);
            
        }
    }
}

void HardArray(int[,] res) 
{

    for (int i = 0; i <= res.GetLength(0) - 1; i++)    
    {   
        for (int j = 0; j <= res.GetLength(1) - 1; j++)
        {
            res[i,j] = array1[i,j] * array2[i,j];
            
        }
    }
}
FillArray(array1);
PrintArray(array1);
Console.WriteLine();
FillArray(array2);
PrintArray(array2);
Console.WriteLine();
HardArray(res);
PrintArray(res);