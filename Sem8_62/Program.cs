// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] FillArray(int size)
{
    int[,] Array = new int[size, size];
    int number = 1;
    int i = 0;
    int j = 0;
    int leftWall = 0;
    int upperWall = 1;
    while (j <= size - 1)
    {
        if (j != size - 1)
        {
            Array[j, i] = number++;
            j++;                                              //двигаемся вправо
        }
        else if (upperWall >= size)
        {
            while (j > leftWall)
            {
                Array[j, i] = number++;
                j--;
            }
            break;
        }
        else
        {
            while (i <= size - 1 && j >= leftWall)
            {
                if (i != size - 1)
                {
                    Array[j, i] = number++;
                    i++;                                        //двигаемся вниз
                }
                else
                {
                    size--;
                    while (j >= leftWall)
                    {
                        if (j != leftWall)
                        {
                            Array[j, i] = number++;
                            j--;                                 //двигаемся влево
                        }
                        else
                        {
                            leftWall++;
                            while (i >= upperWall)
                            {
                                if (i != upperWall)
                                {
                                    Array[j, i] = number++;
                                    i--;                        //двигаемся вверх
                                }
                                else
                                    upperWall++;
                            }
                        }
                    }
                }
            }
        }
    }
    Array[j, i] = number++;
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

try
{
Console.WriteLine("Введите число соответствующее количеству столбцов и строк в массиве");
int n = Convert.ToInt32(Console.ReadLine());
PrintArray(FillArray(n));
}
catch
{
    Console.WriteLine("Проверьте правильность введенных данных");
}
