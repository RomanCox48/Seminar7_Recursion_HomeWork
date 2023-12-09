// Задайте значения M и N. Напишите программу,
// которая выведет все натуральные числа в промежутке от M до N.
// Использовать рекурсию, не использовать циклы.

string rec(int m, int n)
{
    if (m <= n)
    {
        if (m == n)
            return $"{n}";
        return $"{m}, " + rec(m + 1, n);
    }
    else
    {
        if (n == m)
            return $"{m}";
        return $"{m}, " + rec(m - 1, n);
    }
}

Console.Clear();
Console.WriteLine("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(rec(m, n));