// Задача 4

Console.WriteLine("Введите число a");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число c");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;
if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.Write("Максимальное число " + max);


/* Пытался сделать через массив пишет ошибку не могу понять почему 
оставлю как комментарий вдруг вы подскажите в чем проблема */
/*
Console.WriteLine("Введите число a");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число c");
int c = Convert.ToInt32(Console.ReadLine());

int [] list = {a , b , c};
int size = list.Length;
int index = 0;
int max = list[0];
while (index < size ) {
    if (list[index] > max );
    int max = 0;
    int max = list[index];
    index = index + 1;
}

Console.WriteLine(max);
*/