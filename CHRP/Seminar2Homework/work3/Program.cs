Console.Write("Введите число от 1 до 7: ");
int day = Convert.ToInt32(Console.ReadLine());

string week (int d )
{
    if (d > 0 && d < 2) return "нет";   
    else if (d > 1 && d < 3) return "нет";
    else if (d > 2 && d < 4) return "нет";  
    else if (d > 3 && d < 5) return "нет";
    else if (d > 4 && d < 6) return "нет";
    else if (d > 5 && d < 7) return "да";  
    else if (d > 6 && d < 8) return "да";
      
                
    else return "Введите число от 1 до 7 ";
}            
        Console.WriteLine(week(day));    
