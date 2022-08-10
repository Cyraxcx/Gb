/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/
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
int count = 0;       
int res = 0;
for(int i = 0; i < massive.Length; i++)
    {
        massive[i] = new Random().Next(0,10);
        
    }
while(count < massive.Length )
    {
        res = res + massive[count];
        count = count + 2;  
    }
PrintArray(massive);    
Console.Write("Сумму нечетных чисел: " + res);        