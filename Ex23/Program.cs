// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void outNumbers(int checknum)
{
    int i = 1;
    while (i <= checknum)
    {
        Console.Write(Math.Pow(i, 3));
        if (i < checknum) Console.Write(", ");
        i++;
    }
}

int enternumber(string text)
{
    Console.WriteLine(text);
    int dozens = int.Parse(Console.ReadLine());
    return dozens;
}
int getNumber = enternumber("Введите число: ");

outNumbers(getNumber);