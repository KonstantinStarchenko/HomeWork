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


//Числовой метод
int Prompt(string message)
{
    Console.Write(message);
    String value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int GetThirdRank(int number)
{
    while (number > 999)
    {
        number /= 10;
//        Console.WriteLine(number);
    }
    return number % 10;
}

bool ValidateNumber (int number)
{
    if (number < 100)
    {
        Console.WriteLine("Третьей цифры нет");
        return false;
    }
    return true;
}

int number = Prompt("Введите число > ");
if (ValidateNumber(number))
{
    Console.WriteLine(GetThirdRank(number));
}