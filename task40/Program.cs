// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.


Console.WriteLine("Введите значение 1 стороны");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение 2 стороны");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение 3 стороны");
int c = Convert.ToInt32(Console.ReadLine());

if(a < b + c && b < a + c && c < a + b)
{
    Console.WriteLine("yes");
}
else
{
    Console.WriteLine("no");
}