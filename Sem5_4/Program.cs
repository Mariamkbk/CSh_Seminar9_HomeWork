// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(-8, 12);
    return array;
}

void PrintArray(int[] array)
{
    foreach (int el in array)
        Console.Write($"{el} ");
    Console.WriteLine();
}

Console.WriteLine("Введите размерность массива");
int length = Convert.ToInt32(Console.ReadLine());
int[] Array = CreateArray(length);
int[] ProizvArr = new int[length/2+length%2];
PrintArray(Array);
int i = 0;
int last = length-1; 
while (i<length/2)
{
  if (i==last) ProizvArr[i]=Array[i];
    
  else 
  {
    ProizvArr[i]=Array[i]*Array[last];
    i++;
    last--;
  }
  
}
if (length%2>0) ProizvArr[length/2+length%2-1] = Array[length/2+length%2-1];
PrintArray(ProizvArr);