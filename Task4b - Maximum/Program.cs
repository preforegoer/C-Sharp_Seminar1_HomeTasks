// Находим масимум из 44, 5 и 78
Console.Clear();

double a = -44, b = -5, c = -78, max = a;

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