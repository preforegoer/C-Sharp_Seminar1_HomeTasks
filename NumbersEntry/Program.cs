Console.Clear();

Console.Write("Enter First Number: ");
double a = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter Second Number: ");
double b = int.Parse(Console.ReadLine());

if(a > b)
{
    Console.WriteLine($"{a} is the Maximum");
}
else if (a < b)
{
    Console.WriteLine($"{b} is the Maximum");
}
else
{
    Console.WriteLine("The numbers are equal");
}