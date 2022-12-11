// Задача 50. Напишите программу, которая на вход принимает значение элемента
// в двумерном массиве, и возвращает позицию этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] FillAndShowArray(int horizontal, int vertical)
{
    int[,] Array = new int[horizontal, vertical];
    for (int i = 0; i < vertical; i++)
    {
        for (int j = 0; j < horizontal; j++)
        {
            Array[j, i] = new Random().Next(1, 30);
            Console.Write($"{Array[j, i], 3}\t");
        }
        Console.WriteLine();
    }
    return Array;
}
void FindNum(int[,] array, int num)
{
    int i = 0;
    int j = 0;
    bool findNum = false;
    for (; i < array.GetLength(0); i++)
    {
        for (j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == num)
            {
                Console.WriteLine($"Искомое число найдено в {i + 1} столбце, на {j + 1} строке");
                findNum = true;
            }
        }
    }
    if (findNum==false)
    {
        Console.WriteLine($"Искомое число отсутствует в массиве");
    }
}
try
{
    Console.WriteLine("Введите количество строк в таблице");
    int stroki = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов в таблице");
    int stolbcy = Convert.ToInt32(Console.ReadLine());
    int [,] array = FillAndShowArray(stroki, stolbcy);
    Console.WriteLine("Введите целое число, которое требуется найти в заданном массиве");
    int num = Convert.ToInt32(Console.ReadLine());
    FindNum(array,num);
}
catch
{
    Console.WriteLine("Проверьте правильность введенных данных");
}
