// Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int m = ReadInt("Введите число M: ");
int n = ReadInt("Введите число N: ");

int sum = Sum(m, n);
Console.WriteLine(sum);

int Sum(int numberFrom, int numberTo)
{
    if (numberFrom == numberTo)
        return numberFrom;
    else
        return numberFrom + Sum(numberFrom + 1, numberTo);
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
