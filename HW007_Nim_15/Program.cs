// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет
Console.Clear();
Console.Write("Введите порядковый номер дня недели для проверки выходного : "); // 6 и 7 выходные
int number = int.Parse(Console.ReadLine()!);
if (number >= 1 && number <= 7)
{
    if (number == 6 || number == 7)
    {
        Console.WriteLine($"{number} - > да");
    }
    else { Console.WriteLine($"{number} - > нет"); }
}
else { Console.WriteLine($"{number} - > не является порядковым днем недели"); }