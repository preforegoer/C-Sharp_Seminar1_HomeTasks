// Находим Максимум из 5 и 7

Console.Clear();

double a = 5, b = 7, max = a;

Console.WriteLine("First number: ");
Console.WriteLine(a);
Console.WriteLine("Second number: ");
Console.WriteLine(b);
Console.WriteLine("Maximum: ");

if (max<b) max = b;
if (max>b) max = a;

Console.WriteLine(b);