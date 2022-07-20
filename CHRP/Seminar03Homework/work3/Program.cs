// Напишите программу, которая принимает на вход число (N) 
//и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Введите число: ");
int xx = Convert.ToInt32(Console.ReadLine());
void program (int a)
{
    for ( int i=1; i<a; i++)
    Console.Write(i * i * i +" ");
}
program(xx);