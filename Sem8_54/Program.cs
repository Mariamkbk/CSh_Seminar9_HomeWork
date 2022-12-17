// Задача 54: Задайте двумерный массив.
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

int[,] ArrangeEveryString(int[,] arr)
{
    int i = 0;
    int j = 0;
    int save = 0;
    int changePointi = 0;
    int changePointj = 0;
    while (i < arr.GetLength(1))
    {
        while (changePointj < arr.GetLength(0))
        {
            int max = arr[j, i];
            while (j < arr.GetLength(0))
            {
                if (arr[j, i] > max)
                {
                    max = arr[j, i];
                    save = arr[changePointj, changePointi];
                    arr[changePointj, changePointi] = max;
                    arr[j, i] = save;
                }
                j++;
            }
            changePointj++;
            j = changePointj;
        }
        changePointi++;
        i = changePointi;
        changePointj = 0;
        j = changePointj;
    }
    return arr;
}
try
{
    Console.WriteLine("Введите количество строк в массиве");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов в массиве");
    int n = Convert.ToInt32(Console.ReadLine());
    int[,] array = FillArray(m, n);
    Console.WriteLine("Массив создан: ");
    PrintArray(array);
    ArrangeEveryString(array);
    Console.WriteLine("Массив отсортирован: ");
    PrintArray(array);
}
catch
{
    Console.WriteLine("Проверьте правильность введенных данных");
}
