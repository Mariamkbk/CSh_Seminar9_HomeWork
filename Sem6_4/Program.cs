// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
double[] FillArray(int size)
{
    double[] arr = new double[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().NextDouble() + new Random().Next(-15, 15);
        arr[i] = Math.Round(arr[i], 1, MidpointRounding.AwayFromZero);
    }
    return arr;
}
void PrintArray(double[] array)
{
    foreach (double el in array)
        Console.Write($"{el} ");
    Console.WriteLine();
}
double FindMax(double[] Array)
{
    double max = Array[0];
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i] > max)
            max = Array[i];
    }
    return max;
}
double FindMin(double[] Array)
{
    double min = Array[0];
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i] < min)
            min = Array[i];
    }
    return min;
}
try
{
    Console.WriteLine("Введите размерность массива");
    int size = Convert.ToInt32(Console.ReadLine());
    double[] SomeArray = FillArray(size);
    PrintArray(SomeArray);
    Console.WriteLine($"Разница между максимальным числом {FindMax(SomeArray)} и минимальным числом {FindMin(SomeArray)} равна {FindMax(SomeArray) - (FindMin(SomeArray))}");
}
catch
{
    Console.WriteLine("Проверьте правильность введенных данных");
}
