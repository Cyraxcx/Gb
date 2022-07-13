// Задача 2.


Console.WriteLine("Введите число А ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число В ");
int b = Convert.ToInt32(Console.ReadLine());
int max = a;
      
if (a > b) { max = a;
}
else {
 max = b;
}
Console.Write("Максимальное число " );
Console.Write( max);
