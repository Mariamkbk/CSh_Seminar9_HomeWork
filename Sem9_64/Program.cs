// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

string LineOfNumbers(int N)
{
    if (N == 1) return "1";
    return N + ", " + LineOfNumbers(N - 1);
}
try
{
Console.WriteLine("Введите целое число");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Ряд чисел от {N} до 1: {LineOfNumbers(N)}");
}
catch
{
    Console.WriteLine("Проверьте правильность введенных данных");
}