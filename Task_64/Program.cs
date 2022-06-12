// Задайте значение N. Напишите программу, которая выведет все
// натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int n = ReadInt("Введите значение N: ");

PrintNumbers(n);

void PrintNumbers(int n)
{
    if (n == 1)
    {
        Console.Write(n);
    }
    else
    {
        Console.Write($"{n}, ");
        PrintNumbers(n - 1);
    }
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
