// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и
// выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] FillArray(int horizontal, int vertical)
{
    int[,] Array = new int[horizontal, vertical];
    for (int i = 0; i < vertical; i++)
    {
        for (int j = 0; j < horizontal; j++)
        {
            Array[j, i] = new Random().Next(1, 20);
        }
    }
    return Array;
}
void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            Console.Write($"{arr[j, i]}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
void PrintArrayy(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}\t");
    }
        Console.WriteLine();
    }
    

int[] SumNumsInString(int[,] arr)
{
    int[] numsSum = new int[arr.GetLength(1)];
    int sum = 0;
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            sum += arr[j, i];
        }
        numsSum[i] = sum;
        sum = 0;
    }
    return numsSum;
}
int MinSumString(int[] arr)
{
    
    int min = arr[0];
    int minI = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
            minI = i;
        }
    }
    return minI+1;
}
try
{
    Console.WriteLine("Введите количество столбцов в массиве");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество строк в массиве");
    int n = Convert.ToInt32(Console.ReadLine());
    int[,] array = FillArray(m, n);
    Console.WriteLine("Массив создан: ");
    PrintArray(array);
    Console.WriteLine(
        $"В {MinSumString(SumNumsInString(array))} строке сумма элементов является наименьшей"
    );
}
catch
{
    Console.WriteLine("Проверьте правильность введенных данных");
}
