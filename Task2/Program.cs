// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число A:");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B:");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    Console.WriteLine("Max = {0}", a);
}
else if (b > a)
{
    Console.WriteLine("Max = {0}", a);
}
else
{
    Console.WriteLine("a и b равны");
}
