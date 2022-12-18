// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int[,] FillArray(int horizontal, int vertical)
{
    int[,] Array = new int[horizontal, vertical];
    for (int i = 0; i < vertical; i++)
    {
        for (int j = 0; j < horizontal; j++)
        {
            Array[j, i] = new Random().Next(1, 6);
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
int[,] MultiplyMatrixes(int[,] arr, int[,] Arr)
{
    int[,] resultArray = new int[Arr.GetLength(0), arr.GetLength(1)];
    int i = 0;
    int j = 0;
    int k = 0;
    int l = 0;
    int m = 0;
    int n = 0;
    int res = 0;
    while (k < Arr.GetLength(0))
    {
        while (j < arr.GetLength(1))
        {
            while (i < arr.GetLength(0))
            {
                res+= arr[i, j] * Arr[k, l];
                i++;
                l++;
            }
            resultArray[m, n] = res;
            n++;
            j++;
            res = 0;
            i = 0;
            l = 0;
        }
        k++;
        m++;
        j = 0;
        n = 0;
    }
    return resultArray;
}
try
{
    Console.WriteLine("Введите количество столбцов в 1 матрице");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество строк в 1 матрице");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов во 2 матрице");
    int k = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество строк во 2 матрице");
    int l = Convert.ToInt32(Console.ReadLine());
    int[,] firstArray = FillArray(m, n);
    Console.WriteLine("Первая матрица: ");
    PrintArray(firstArray);
    int[,] secondArray = FillArray(k, l);
    Console.WriteLine("Вторая матрица: ");
    PrintArray(secondArray);
    if (m == l)
    {
        Console.WriteLine("Произведение предыдущих двух матриц: ");
        PrintArray(MultiplyMatrixes(firstArray, secondArray));
    }
    else
        Console.WriteLine(
            "Заданные матрицы несовместимы. Убедитесь, что количество столбцов 1 матрицы равно количеству строк 2 матрицы"
        );
}
catch
{
    Console.WriteLine("Проверьте правильность введенных данных");
}
