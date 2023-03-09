// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5  -> 2, 4
// 8  -> 2, 4, 6, 8
Console.Clear();
Console.Write("Введите положительное число число N: ");
int N = int.Parse(Console.ReadLine()!);
int index=1;
Console.Write($"{N} - > ");
while (index<=N)
{
    if (index%2==0) 
    {
        if (index!=2) Console.Write($", ");
        Console.Write($"{index}");
    }
    index++;
}