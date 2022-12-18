Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
int [] fib = new int [N];
fib [0] = 0;
fib [1] = 1;
for(int i = 2; i < N; i++)
{
    fib [i] = fib[i - 1] + fib[i - 2];
}
Console.WriteLine($"{string.Join(" ,", fib)}");