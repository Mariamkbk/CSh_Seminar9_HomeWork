// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void FillAndShowArray(int horizontal, int vertical)
{
    double[,] Array = new double[horizontal, vertical];
    for (int i = 0; i < vertical; i++)
    {
        for (int j = 0; j < horizontal; j++)
        {
            Array[j, i] = new Random().NextDouble()*10;
            Console.Write($"{Array[j, i]} ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите количество строк в таблице");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в таблице");
int n = Convert.ToInt32(Console.ReadLine());
FillAndShowArray(m, n);
