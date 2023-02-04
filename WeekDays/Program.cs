Console.Clear();

Console.Write("Enter a number of Week day: ");
int v = Convert.ToInt32(Console.ReadLine());

if (v < 1 || v > 7)
{
    Console.Write("There are only 7 days in a week, Please enter a number from 1 to 7: ");
    int v = Convert.ToInt32(Console.ReadLine());
}
if (v == 1)
    Console.Write("The first day of week is Monday");

else if (v == 2)
    Console.Write("The second day of week is Tuesday");

else if  (v == 3)
    Console.Write("The third day of week is Wendnesday");

else if  (v == 4)
    Console.Write("The first day of week is Monday");

else if  (v == 5)
    Console.Write("The fifth day of week is Friday");

else if  (v == 6)
    
    Console.Write("The first day of week is Saturday");

else
    Console.Write("The seventh day of week is Sunday");