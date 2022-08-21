/*
Формируется массив из n целых случайных чисел от -50 до 50.
Выводятся положительные числа в порядке убывания и их количество.
*/

int[] arrayMaker(int first, int last, int capacity)
{
    int[] array = new int[capacity];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(first, last + 1);
        Console.Write(array[i] + " ");
    }
    return array;
}

void sortedArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[i])
            {
                int temp = array[j];
                array[j] = array[i];
                array[i] = temp;
            }
        }
    }
}

int[] targetArray = arrayMaker(-50, 50, 10);
Console.WriteLine();
sortedArray(targetArray);

foreach (int item in targetArray)
{
    Console.Write(item + " ");
}
Console.WriteLine();

foreach (int item in targetArray)
{
    if (item > 0)
    {
        Console.Write(item + " ");
    }
}