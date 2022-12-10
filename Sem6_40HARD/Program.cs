// На вход программы подаются три целых положительных числа.
// Определить , является ли это сторонами треугольника.
// Если да, то вывести всю информацию по нему -
// площадь, периметр, значения углов треугольника в градусах,
// является ли он прямоугольным, равнобедренным, равносторонним.

bool CheckTriangle(int side1, int side2, int side3)
{
    if (side1 < side2 + side3 && side2 < side3 + side1 && side3 < side2 + side1)
        return true;
    else
        return false;
}
void PerimetrAndArea(int side1, int side2, int side3)
{
    int P = side1 + side2 + side3;
    double p = P / 2;
    double S = (Math.Round(Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3)), 3));
    Console.WriteLine($"Площадь треугольника с заданными сторонами равна: {S}");
    Console.WriteLine($"Периметр треугольника с заданными сторонами равен: {P}");
}
void FindCompareAngles(int side1, int side2, int side3)
{
    double[] array = new double[3];
    array[0] = Math.Round((Math.Acos((Math.Pow(side1, 2) + Math.Pow(side3, 2) - Math.Pow(side2, 2)) / (2 * side1 * side3))) * 180 / Math.PI, 2);
    array[1] = Math.Round((Math.Acos((Math.Pow(side1, 2) + Math.Pow(side2, 2) - Math.Pow(side3, 2)) / (2 * side1 * side2))) * 180 / Math.PI, 2);
    array[2] = Math.Round((Math.Acos((Math.Pow(side2, 2) + Math.Pow(side3, 2) - Math.Pow(side1, 2)) / (2 * side3 * side2))) * 180 / Math.PI, 2);
    Console.WriteLine($"Углы треугольника с заданными сторонами равны: {array[0]}°, {array[1]}° и {array[2]}°");
    if (array[0] == 90 || array[1] == 90 || array[2] == 90)
        Console.WriteLine("Треугольник с заданными сторонами является прямоугольным");
    else
        Console.WriteLine("Треугольник с заданными сторонами не является прямоугольным");
    if (array[0] == array[1] || array[1] == array[2] || array[2] == array[0])
        Console.WriteLine("Треугольник с заданными сторонами является равнобедренным");
    else
        Console.WriteLine("Треугольник с заданными сторонами не является равнобедренным");
    if (array[0] == array[1] && array[1] == array[2] && array[2] == array[0])
        Console.WriteLine("Треугольник с заданными сторонами является равносторонним");
    else
        Console.WriteLine("Треугольник с заданными сторонами не является равносторонним");
}
try
{
Console.WriteLine("Введите первое целое положительное число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое положительное число");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье целое положительное число");
int num3 = Convert.ToInt32(Console.ReadLine());

if (CheckTriangle(num1, num2, num3) == true)
{
    PerimetrAndArea(num1, num2, num3);
    FindCompareAngles(num1, num2, num3);
}
else
    Console.WriteLine("Треугольник с заданными сторонами не существует");
}
catch
{
    Console.WriteLine("Проверьте правильность введенных данных");
}

