/*
Формируется массив из n целых случайных чисел от -50 до 50.
Массив упорядочивается. Выводятся числа в интервале от – 20 до +20.
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

int[] sortedArray(int[] array)
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
    return array;
}




int[] targetArray = arrayMaker(-50, 50, 10);
Console.WriteLine();
int[] afterSortArray = sortedArray(targetArray);

foreach (int item in afterSortArray)
{
    if (item > -21 && item < 21)
    {
        Console.Write(item + " ");
    }
    
}
