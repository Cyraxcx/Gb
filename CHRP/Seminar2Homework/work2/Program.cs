/*Напишите программу, которая выводит третью цифру
 заданного числа или сообщает, что третьей цифры нет.*/

Console.Write("Введите любое число: ");
int num = Convert.ToInt32(Console.ReadLine());
int x;
if ( num < 99)
{
    Console.Write("Третьей цифры нет ");
    
}
else if (num > 99 && num <= 999)
{
    x = num % 10;

    Console.Write(x);
}
else if (num > 999 && num <= 9999)
{
    x = (num / 10) % 10;
    Console.Write(x);
}
else if (num > 9999 && num <= 99999)
{
    x = (num / 100) % 10;
    Console.Write(x);
}
else if (num > 99999 && num <= 999999)
{
    x = (num / 1000) % 10;
    Console.Write(x);
}