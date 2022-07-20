//Напишите программу, которая принимает на вход пятизначное число и 
//проверяет, является ли оно палиндромом.

   
Console.WriteLine("Введите число: ");
int inter = Convert.ToInt32(Console.ReadLine());
int i, a = 0, reverse = 0;
for (i = inter; i > 0; i = (i / 10))
{
    a = i % 10;
    reverse = (reverse * 10) + a;

}

if (reverse == inter)
{
    Console.WriteLine("Число является палиндромом ");
}
else
{
    Console.WriteLine("Не является палиндромом ");
}
        