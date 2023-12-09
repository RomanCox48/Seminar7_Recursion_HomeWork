// Задайте произвольный массив.
// Выведете его элементы, начиная с конца.
// Использовать рекурсию, не использовать циклы.

int[] array = new int[10];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 100);
}
Console.WriteLine(string.Join(", ", array));

void rec (int [] array, int index)
{
    if (index < 0)
    {
        return;
    }
    Console.Write($"{array[index]} ");
    rec (array, index-1);
}

rec (array, array.Length-1);