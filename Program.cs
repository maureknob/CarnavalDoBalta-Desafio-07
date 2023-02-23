void Fib(int n)
{
    int previous = 0;
    int current = 1;
    int next = 0;
    Console.Write($"{current} ");
    for (int i = 0; i < n; i++)
    {
        next = previous + current;
        previous = current;
        current = next;
        Console.Write($"{current} ");
    }
    Console.WriteLine();
}

for (int i = 1; i < 30; i++)
{
    Fib(i);
}