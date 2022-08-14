/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, -567, 89, 223-> 3*/
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
int res = 0;

Console.WriteLine("Введите число: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] array = new int[m];

for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-5, m);
        if(array[i] > 0) res = res + 1;
        
    }

PrintArray(array);
Console.WriteLine();
Console.Write($"Положительных чисел: {res}");

