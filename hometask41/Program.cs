// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// Ввод чисел останавливается при помощи ввода слова "stop"

Console.WriteLine("Введите число");
string a = "0";
int count = 0;
while(a != "stop")
{
    if(Convert.ToInt32(a) > 0)
    {
        count = count + 1;
    }
    a = Console.ReadLine();
    
}
Console.WriteLine(count);