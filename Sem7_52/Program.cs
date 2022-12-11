// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] FillAndShowArray(int horizontal, int vertical)
{
    int[,] Array = new int[horizontal, vertical];
    for (int i = 0; i < vertical; i++)
    {
        for (int j = 0; j < horizontal; j++)
        {
            Array[j, i] = new Random().Next(1, 10);
            Console.Write($"{Array[j, i], 3}\t");
        }
        Console.WriteLine();
    }
    return Array;
}
string FindMiddleAriphmet(int[,]array)
{
    string midAriph = "Среднее арифметическое: ";
    double sum = 0;
    int j = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        sum=0;
        for (j = 0; j < array.GetLength(0); j++)
        {
            sum+=array[i,j];
        }
        midAriph+=$"{i+1} столбца={Math.Round(sum/array.GetLength(0),2)}; ";
    }
    return midAriph;
}

try
{
    Console.WriteLine("Введите количество строк в таблице");
    int stroki = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов в таблице");
    int stolbcy = Convert.ToInt32(Console.ReadLine());
    int [,] array = FillAndShowArray(stroki, stolbcy);
    Console.WriteLine($"{FindMiddleAriphmet(array)}");
   
}
catch
{
    Console.WriteLine("Проверьте правильность введенных данных");
}
