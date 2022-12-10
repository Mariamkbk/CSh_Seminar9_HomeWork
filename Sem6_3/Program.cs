// Задача 36: Задайте одномерный массив, заполненный 
// случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int [] FillArray(int size)
{ 
    int[]SomeArr = new int [size];
    for (int i=0; i<size; i++) SomeArr[i] = new Random().Next(-20,21);
    return SomeArr;
}

void PrintArray(int[]arr)
{
    foreach (int el in arr) Console.Write($"{el} ");
    Console.WriteLine();
}

int OddPosSum(int[]ArElse)
{
    int sum=0;
    for (int i=1;i<ArElse.Length;i+=2) sum+=ArElse[i]; 
    return sum;
}
try
{
Console.WriteLine("Ведите размерность массива в числовом значении");
int length = Convert.ToInt32(Console.ReadLine());
int[]array = FillArray(length);
PrintArray(array);
Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях равна: {OddPosSum(array)}");
}
catch
{
   Console.WriteLine("Проверьте правильность введенных данных"); 
}
