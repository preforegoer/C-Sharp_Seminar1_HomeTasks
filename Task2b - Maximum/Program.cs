// находим максимум из 2 и 10
Console.Clear();

double a = 2, b = 10, max = a;

Console.WriteLine("First number: ");
Console.WriteLine(a);
Console.WriteLine("Second number: ");
Console.WriteLine(b);
Console.WriteLine("Maximum: ");


if (max<b) max = b;
if (max>b) max = a;

Console.WriteLine(max);