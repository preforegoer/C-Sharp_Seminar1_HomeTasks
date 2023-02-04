// See https://aka.ms/new-console-template for more information
Console.Clear();

Console.Write("Enter First Number: ");
double a = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter Second Number: ");
double b = int.Parse(Console.ReadLine());

if (a==b*b)
    Console.Write($"{a} equals to {b}*{b}");
else
    Console.Write($"{a} does not equal to {b}*{b}");