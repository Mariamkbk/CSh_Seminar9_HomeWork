//Задача HARD SORT необязательная. Считается за три обязательных
// Задайте двумерный массив из целых чисел.
// Количество строк и столбцов задается с клавиатуры.
// Отсортировать элементы по возрастанию слева направо и сверху вниз.
// Например, задан массив:
// 1 4 7 2
// 5 9 10 3
// После сортировки
// 1 2 3 4
// 5 7 9 10

int[,] FillArray(int horizontal, int vertical)
{
    int[,] Array = new int[horizontal, vertical];
    for (int i = 0; i < vertical; i++)
    {
        for (int j = 0; j < horizontal; j++)
        {
            Array[j, i] = new Random().Next(1, 15);
        }
    }
    return Array;
}
void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[j, i], 3}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
int[,] ArrangeArray(int[,] arr)
{
    int save = 0;
    int starti = 0;
    int startj = 0;
    while (startj < arr.GetLength(0))
    {
        while (starti < arr.GetLength(1))
        {
            
            int min = arr[starti, startj];
            for (int j = startj; j < arr.GetLength(0); j++)
            {
                for (int i = starti; i < arr.GetLength(1); i++)
                {
                    if (arr[j, i] < min)
                    {
                        min = arr[j, i];
                        save = arr[startj, starti];
                        arr[startj, starti] = min;
                        arr[j, i] = save;
                    }
                }
            }
            starti++;
        }
        startj++;
        starti=0;
    }

    return arr;
}
try
{
    Console.WriteLine("Введите количество строк в таблице");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов в таблице");
    int n = Convert.ToInt32(Console.ReadLine());
    int[,] array = FillArray(m, n);
    PrintArray(array);
    ArrangeArray(array);
    PrintArray(array);
}
catch
{
    Console.WriteLine("Проверьте правильность введенных данных");
}
