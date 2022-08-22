/*Задача 62. Заполните спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
1 2 3 4
12 13 14 5
11 16 15 6
10 9 8 7*/



Console.WriteLine("Введите кол-во строк: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите кол-во столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());


int [,] Spirale (int n, int m)
{ 
    int  count=1;
    int [,] matr = new int[n,m];
    for (int k=1; k<=n/2+1; k++)
    {
        for (int j=k-1; j<m; j++ )
            {
                if (matr[k-1,j]==0) matr[k-1,j]=count++;
            }
        for (int i=k-1; i<n; i++ )
            {
                if (matr[i,m-k]==0) matr[i,m-k]=count++;
            }
        for (int j=m-k; j>=0; j--)
            {
                if (matr[n-k,j]==0) matr[n-k,j]=count++;
            }
        for (int i=n-k; i>=0; i--)
            {
                if (matr[i,k-1]==0) matr[i,k-1]=count++;
            }
    }
    return matr;
}

void PrintArray(int[,] col)
{
    for (int i = 0; i < col.GetLength(0); i++)
    {
        for (int j = 0; j < col.GetLength(1); j++)
        {
            Console.Write($"{col[i, j]}    ");
        }
        Console.WriteLine();
    }
}
Console.WriteLine();
PrintArray(Spirale(n,m));