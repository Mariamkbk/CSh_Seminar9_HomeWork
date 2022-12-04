// Задача 33: Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

bool FindNum(int[] array, int num)
{
    bool res = false;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == num)
        {
            res = true;
            break;
        }
    }
    return res;
}

Console.WriteLine("Введите размерность массива");
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите искомое число: ");
int num = Convert.ToInt32(Console.ReadLine());

int[] array = CreateArray(size);
PrintArray(array);
if (FindNum(array, num)) Console.WriteLine("ДА, Число присутствует в массиве!");
else Console.WriteLine("НЕТ! Искомого числа");
