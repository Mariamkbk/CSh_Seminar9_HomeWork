// Задача 34: Задайте массив заполненный случайными положительными
// трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] FillArray(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++) arr[i] = new Random().Next(100, 1000);
    return arr;
}

void PrintArray(int[] SomeArr)
{
    foreach (int el in SomeArr) Console.Write($"{el} ");
    Console.WriteLine();
}

int EvenCount(int[] ElseArr)
{
    int count = 0;
    for (int i = 0; i < ElseArr.Length; i++)
        if (ElseArr[i] % 2 == 0) count++;
    return count;
}
try
{
    Console.WriteLine("Введите число, соответствующее размерности массива");
    int length = Convert.ToInt32(Console.ReadLine());
    int[] array = FillArray(length);
    PrintArray(array);
    Console.WriteLine($"В заданном массиве количество четных чисел равно: {EvenCount(array)}");
}
catch
{
    Console.WriteLine($"Проверьте правильность введенных данных");
}
