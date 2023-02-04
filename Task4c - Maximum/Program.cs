// Находим масимум из 22, 3 и 9
Console.Clear();

double a = 22, b = 3, c = 9, max = a;

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