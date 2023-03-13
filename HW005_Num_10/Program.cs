// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.Clear();
Console.Write("Введите трёхзначное число : "); //от 100 до 999
int number = int.Parse(Console.ReadLine()!);
int result = 0;
if (number >= 100 && number < 1000)
{
    result = (number % 100 - number % 10) / 10;
    Console.WriteLine($"{number} -> {result}");
}
else
{
    Console.WriteLine("Ошибка при вводе трёхзначного числа");
}

Console.Write("Введите трёхзначное число (строковой метод) : "); //от 100 до 999
String NumStr = Console.ReadLine();
if (NumStr.Length==3)
{
    Console.WriteLine($"{number} -> {NumStr[1]}");
}
else
{
    Console.WriteLine("Ошибка при вводе трёхзначного числа");
}
