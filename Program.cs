
// вход число N и выдаёт таблицу кубов чисел от 1 до N
/*
void K( int num)

{
    int current = 1;
    while (current <= num)
    {
    Console.Write($"{current * current * current} , ");
    current ++; 
    }
}

Console.WriteLine("Введите  число");
int num = Convert.ToInt32(Console.ReadLine());
K( num);
// всё как в задаче. В строкУ, через запятую.

*/

// проверка пятизначного числа на палендром

/*

Console.WriteLine("Введите пятизначное число");
String num = Console.ReadLine();
int length = num.Length;

if (length ==5)
{
        
        
        if (num[0] == num[4] && num[1]==num[3])
        {
        Console.WriteLine($" Число {num}  палендром");
        }
        else
        {
        Console.WriteLine($" Число {num} не палендром");
        }
}    
else
        {
        Console.WriteLine($"Число {num} не является пятизначным"); 
        }

*/

// Расстояние в 3D



double FindWay(double x1, double y1, double z1, double x2, double  y2, double z2)
{
   
    double Way = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2) + Math.Pow(z2-z1, 2));
    return Way;
}

Console.WriteLine("введите координату x1");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите координату y1");
double y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите координату z1");
double z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введиту координату x2");
double x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите координату y2");
double y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите координату z2");
double z2 = Convert.ToInt32(Console.ReadLine());


double res = FindWay(x1, y1, z1, x2, y2, z2);
Console.WriteLine($"расстояние между точек {res}");