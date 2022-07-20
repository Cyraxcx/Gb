/*Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
*/

Console.Write("Введите кооординату x первой точки: ");
double a_x = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите кооординату y первой точки: ");
double a_y = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите кооординату z первой точки: ");
double a_z = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите кооординату x второй точки: ");
double b_x = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите кооординату y второй точки: ");
double b_y = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите кооординату z второй точки: ");
double b_z = Convert.ToDouble(Console.ReadLine());
double points (double a_x, double a_y, double a_z, double b_x, double b_y, double b_z)
{
    double num = (b_x - a_x) * (b_x - a_x) + (b_y - a_y) * (b_y - a_y) + (b_z - a_z) * (b_z - a_z);
    return Math.Sqrt(num);
    
}

Console.WriteLine(points(a_x, a_y, a_z, b_x, b_y, b_z));