// Находим Максимум из 2, 3, 7

Console.Clear();

double a = 2, b = 3, c = 7, max = a;

Console.WriteLine("First number: ");
Console.WriteLine(a);
Console.WriteLine("Second number: ");
Console.WriteLine(b);
Console.WriteLine("Third number: ");
Console.WriteLine(c);
Console.WriteLine("Maximum: ");

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.WriteLine(max);