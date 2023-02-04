Console.Clear();
// Console.Write("Enter a Number: ");
// int a = Convert.ToInt32(Console.ReadLine());

int a = 8;
Console.WriteLine($"All Even numbers from 0 to {a}: ");

for (int i = 2 ; i <=a; i++)
if (i % 2 ==0)
    Console.Write($" {i}");
else
    Console.Write(";");