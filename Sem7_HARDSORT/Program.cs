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

int[,] ArrangeArray(int[,] arr)
{
    int i = 0;
    int j = 0;
    int min = arr[i, j];
    int save = 0;
    int changePointi = 0;
    int changePointj = 0;
    while (changePointi < arr.GetLength(1))
    {
        while (changePointj < arr.GetLength(0))
        {
            min = arr[j, i];
            while (i < arr.GetLength(1))
            {
                while (j < arr.GetLength(0))
                {
                    if (arr[j, i] < min)
                    {
                        min = arr[j, i];
                        save = arr[changePointj, changePointi];
                        arr[changePointj, changePointi] = min;
                        arr[j, i] = save;
                    }
                    j++;
                }
                i++;
                j = 0;
            }
            changePointj++;
            j = changePointj;
            i = changePointi;
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
    PrintArray(array);
    ArrangeArray(array);
    PrintArray(array);
}
catch
{
    Console.WriteLine("Проверьте правильность введенных данных");
}

