// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число:");
int a = Convert.ToInt32(Console.ReadLine());

int i = 1;

Console.WriteLine("Четные числа");
while (i <= a)
{
    if (i % 2 == 0) 
    {
        Console.WriteLine(i);
    }
    i++;
}