//Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите число от 1 до 7: ");
int day = Convert.ToInt32(Console.ReadLine());

string week (int d )
{
    if (d > 0 && d < 6) return "нет";   
    else if (d > 5 && d < 8) return "да";              
    else return "Введите число от 1 до 7 ";
}            
    Console.WriteLine(week(day));    
