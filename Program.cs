using System;

class Program
{

static double Area(double radius)
{
    return Math.PI * radius * radius;
}
 
static double Area(double width, double height)
{
    return width * height;
}
 
static double Area(double a, double b, double c)
{
    double p = (a + b + c) / 2;
    return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
}

static void Main(string[] args)
{
 
Console.WriteLine($"Doira: {Area(5):F2}");
Console.WriteLine($"To'rtburchak: {Area(4, 6):F2}");
Console.WriteLine($"Uchburchak: {Area(3, 4, 5):F2}");
}
}

