// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
void PrintBinaryView(int n)
{
    if(n <=0) return;
    PrintBinaryView(n / 2);
    Console.Write(n % 2);
}
// while(a / 2 >= 0)
// {
//     a = a / 2;
//     Console.Write(a % 2);
//     if(a == 0) break;
// }
PrintBinaryView(a);