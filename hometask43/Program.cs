// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

double ReadLine(string msg)
{
    Console.WriteLine(msg);
    double number = Convert.ToInt32(Console.ReadLine());
    return number;
}
double b1 = ReadLine("Введите число для b1");
double k1 = ReadLine("Введите число для k1");
double b2 = ReadLine("Введите число для b2");
double k2 = ReadLine("Введите число для k2");
if(k1 == k2)
{
    Console.WriteLine("Прямые параллельны");
}
else
{
    Console.WriteLine($"Точка пересечения: ({(b2 - b1) / (k1 - k2)};{(k1 * b2 - k2 * b1) / (k1 - k2)})");
}