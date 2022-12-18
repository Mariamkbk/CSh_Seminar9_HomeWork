// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N через рекурсию.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите основание");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(PowRec(numberA, numberB));

int PowRec(int numberA, int numberB)
{
    if (numberB == 0) return 1;
    return numberA * PowRec(numberA, numberB - 1);
}






