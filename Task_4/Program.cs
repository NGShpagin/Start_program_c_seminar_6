// Задача 3. Решение в группах задач
// Не используя рекурсию, выведите первые N чисел Фибоначчи.
// Первые два числа Фибоначчи: 0 и 1.

void Fibonacci(int n)
{
    int a = 0;
    int b = 1;
    for (int i = 0; i < n; i++)
    {
        // if (n == 1 || n == 2) return 1;
        Console.Write($"{a} ");
        (a, b) = (b, a + b);
    }
    Console.WriteLine();
}

Fibonacci(7);