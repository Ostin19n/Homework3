// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

void CheckNumberPal(int number)
{
    if (number >= 10000)
    {
        int division = number / 10000;
        int remainder = number % 10;
        if (division == remainder)
        {
            Console.WriteLine("Число является палиндромом");
        }
        else
        {
            Console.WriteLine("Число не является палиндромом");
        }
    }
    else
    {
        Console.WriteLine("Число не является пятизначным");
    }
}

int enternumber(string text)
{
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int GetNum = enternumber("Введите пятизначное число: ");

CheckNumberPal(GetNum);