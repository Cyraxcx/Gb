//Напишите программу, которая принимает на вход пятизначное число и 
//проверяет, является ли оно палиндромом.

/*Console.WriteLine("Введите 5-ти значное число");
int num = Convert.ToInt32(Console.ReadLine());
int reverse = 0;
int a = 0;
for (num > 0)
{
    a = num % 10;
    reverse = (reverse* 10) + a;
    //num = num / 10;
}


    if (num == reverse)
    {
    //reverse = (num / 10) % 10;
//Console.WriteLine("Число является палиндромом ");
        Console.WriteLine(reverse);
    }
    else 
    {
        Console.WriteLine("Не является палиндромом ");

    }*/
   
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
        