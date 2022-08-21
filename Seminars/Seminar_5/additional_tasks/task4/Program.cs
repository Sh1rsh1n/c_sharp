/*
Формируется массив из n натуральных нечетных чисел.
Выводится исходный массив и числа кратные 3.
*/

int[] NaturalNumsArray(int capacity)
{
    int[] array = new int[capacity];
    int index = 0;

    while (index < array.Length)
    {
        int value = new Random().Next(0, 1000);

        if (value % 2 == 1)
        {
            array[index] = value;
            Console.Write(value + " ");
            index++;
        }
    }
    Console.WriteLine();
    return array;
}

int[] targetArray = NaturalNumsArray(10);

foreach (int item in targetArray)
{
    if (item % 3 == 0)
    {
        Console.Write(item + " ");
    }
}