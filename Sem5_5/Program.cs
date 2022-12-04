// Задача 35: Задайте одномерный массив из 15 случайных чисел от -100 до 100.
//  Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

int[] FillPrintArray()
{
    {
        int[] array = new int[15];
        for (int i = 0; i < 15; i++)
        {
            array[i] = new Random().Next(-100, 101);
            Console.Write(array[i] + " ");
        }
        return array;
    }
}

int Elements(int[] array)
{
    int count = 0;
    foreach (int el in array)
    {
        if (el >= 10 && el <=99) count++;
    }
    return count;
}

int[] array = FillPrintArray();
Console.WriteLine();
Console.WriteLine($"Количество элементов массива, значения которых лежат в отрезке [10,99] = {Elements(array)}");

