Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
while ( a > 1 ) 
{
    if ( a % 2 == 0)
    {
        Console.WriteLine(a);
    }
    a--;
}