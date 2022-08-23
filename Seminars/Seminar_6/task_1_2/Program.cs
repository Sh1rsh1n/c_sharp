/*
Задача 1. Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.). 
Элементы двумерного массива задаются случано и лежат в промежутке от -10 до 10

[1 2 3 4 5] -> [5 4 3 2 1]

[6 7 3 6] -> [6 3 7 6]


*/

int[] FillArray(int capacity, int min, int max)
{
    int[] array = new int[capacity];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
        Console.Write(array[i] + " ");
    }
    return array;
}



void arrayReverse(int[] array)
{
    int size = array.Length;

    for (int i = 0; i < size / 2; i++)
    {
        int temp = array[i];
        array[i] = array[size - i - 1];
        array[size - i - 1] = temp;
    }
}

int[] arr = FillArray(9, -10, 10);

Console.WriteLine();
arrayReverse(arr);

foreach (int item in arr)
{
    Console.Write(item + " ");
}

/*
Задача 2. Вычислить среднее арифметическое положительных элементов в одномерном массиве. 
Элементы двумерного массива задаются случано и лежат в промежутке от -10 до 10

[1, -5, 8, 4, -9] -> 4.33

*/
double sum = 0;
int count = 0;

foreach (int item in arr)
{
    if (item > 0)
    {
        sum += item;
        count++;
    }
}
Console.WriteLine();


Console.WriteLine("sum = " + sum);
Console.WriteLine("count = " + count);
Console.WriteLine("foreach average: " + sum / count);

double average(int[] array)
{
    int count = 0;
    double sum = 0;
    foreach (int item in arr)
    {
        if (item > 0)
        {
            sum += item;
            count++;
        }
    }
    Console.WriteLine();

    Console.WriteLine("sum = " + sum);
    Console.WriteLine("count = " + count);
    return sum / count;
}

Console.WriteLine("method average = " + average(arr));