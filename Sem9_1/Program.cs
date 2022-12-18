// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите целое число");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"сумма числа от 1 до {N}: {SummaRec(N)}");

int SummaRec(int N)
{
    if (N == 0)
        return 0;
    return N % 10 + SummaRec(N / 10);
}
