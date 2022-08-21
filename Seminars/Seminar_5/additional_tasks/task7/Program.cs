/*
Формируется массив из n целых случайных чисел от -40 до 40.
Выводятся нечетные отрицательные числа и их к-во.
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


int[] targetArray = arrayMaker(-40, 41, 10);
Console.WriteLine();

int count = 0;
foreach (int item in targetArray)
{
    if ((item < 0) && (item % 2 == -1))
    {
        Console.Write(item + " ");
        count++;
    }
}
Console.WriteLine();
Console.WriteLine(count);