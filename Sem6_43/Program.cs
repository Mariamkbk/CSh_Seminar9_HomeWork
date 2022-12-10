// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void FindDotCross(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    if (k1 - k2 == 0)
        Console.WriteLine("Заданные прямые параллельны и не имеют точек пересечения");
    else
        Console.WriteLine($"Прямые пересекаются в точке с координатами X = {Math.Round(x, 2)}; Y = {Math.Round(y, 2)}");
}
try
{
    Console.WriteLine("Введите значение b1");
    double b1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите значение k1");
    double k1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите значение b2");
    double b2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите значение k2");
    double k2 = Convert.ToDouble(Console.ReadLine());
    FindDotCross(b1, k1, b2, k2);
}
catch
{
    Console.WriteLine("Проверьте правильность введенных данных");
}
