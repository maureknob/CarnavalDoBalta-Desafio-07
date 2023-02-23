// Solução incompleta
Dictionary<int, long> _memorization = new Dictionary<int, long>();

long FibMemorization(int n)
{
    if (_memorization.ContainsKey(n))
        return _memorization[n];


    if (n <= 2)
        return 1;

    _memorization[n] = FibMemorization(n - 1) + FibMemorization(n - 2);
    return _memorization[n];
}

// Solução que funciona
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

Fib(1);
Fib(2);
Fib(3);
Fib(4);
Fib(5);
Fib(6);
Fib(7);
Fib(8);