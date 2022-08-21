/*
Формируется массив из n целых случайных чисел от 10 до 99
Выводится исходный массив, нечетные числа и их количество.
*/

int[] NegativeNumsArray(int capacity)
{
    int[] array = new int[capacity];
    for (int i = 0; i < array.Length; i++)
    {
        int value = new Random().Next(10, 100);
        Console.Write(value + " ");

        array[i] = value;
    }
    return array;
}

int[] arr = NegativeNumsArray(10);
int count = 0;
Console.WriteLine();
foreach (int item in arr)
{
    if (item % 2 == 1)
    {
        Console.Write(item + " ");
        count++;
    }
}
Console.WriteLine();
Console.WriteLine("количество нечетных чисел = " + count);
