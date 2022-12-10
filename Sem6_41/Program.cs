// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

void CountAboveNull(int size)
{
    int count = 0;
    string Nums = String.Empty;
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите {i+1} число");
        double num = Convert.ToDouble(Console.ReadLine());
        if (num > 0)
            count ++;
        Nums+=Convert.ToString(num)+" ";
    }
    Console.WriteLine($"В ряде чисел: {Nums} количество чисел больше 0 равно: {count}");
}

try
{
Console.WriteLine("Укажите, какое количество чисел будете вводить");
int M = Convert.ToInt32(Console.ReadLine());
CountAboveNull(M);
}
catch
{
    Console.WriteLine("Проверьте правильность введенных данных");
}
