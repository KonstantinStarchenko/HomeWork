// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6
Console.Clear();
Console.Write("Введите трёхзначное число (строковой метод) : "); //от 100 до 999
String NumStr = Console.ReadLine()!;
if (NumStr.Length>=3)
{
    Console.WriteLine($"{NumStr} -> {NumStr[2]}");
}
else
{
    Console.WriteLine($"{NumStr} -> третьей цифры нет");
}
