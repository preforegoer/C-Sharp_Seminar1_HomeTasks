// OddOrEven
Console.Clear();

Console.Write("Enter a number: ");
int a = Convert.ToInt32(Console.ReadLine()), count = (-1) * a;

if (a%2 == 1)
    Console.WriteLine($"{a} is Odd");
else 
    Console.WriteLine($"{a} is Even");