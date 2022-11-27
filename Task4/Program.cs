// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число A:");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B:");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число C:");
int c = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    if (a > c) {
        Console.WriteLine("Max = {0}", a);
    } else if (c > a) {
        Console.WriteLine("Max = {0}", c);
    } else {
        Console.WriteLine("a и c больше b");
    }
}
else if (b > a)
{
    if (b > c) {
        Console.WriteLine("Max = {0}", b);
    } else if (c > b) {
        Console.WriteLine("Max = {0}", c);
    } else {
        Console.WriteLine("b и c больше a");
    }
} else {
    if (b > c) {
        Console.WriteLine("a и b больше c");
    } else if (c > b) {
        Console.WriteLine("Max = {0}", c);
    } else {
        Console.WriteLine("числа равны");
    }
}
