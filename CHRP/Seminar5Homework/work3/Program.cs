/*Задача 38: Задайте массив целых чисел. Найдите разницу между максимальным 
и минимальным элементов массива.
[3 7 22 2 78] -> 76*/
void PrintArray(int[] col)
    {
        int count = col.Length;
        int position = 0;
        while (position < count)
            {
                Console.Write($"{col[position]} ");
                position++;
            }
    }

Console.WriteLine("Введите размерность массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] massive = new int[size];
void FillArray ()
{       
for(int i = 0; i < massive.Length; i++)
    {
        massive[i] = new Random().Next(0,99);
    
    }
} 
FillArray();   
int min = massive.Min();
int max = massive.Max();
int res = max - min;


//PrintArray(massive);
Console.WriteLine();
Console.WriteLine($"Min: {min} , Max: {max}, разница: {res}");