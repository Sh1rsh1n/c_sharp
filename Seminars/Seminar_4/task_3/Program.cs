/*
Задача 30: Напишите программу, которая 
выводит массив из 8 элементов, заполненный 
нулями и единицами в случайном порядке.
*/


int[] binArray(int first, int last, int capacity)
{
    int[] array = new int[capacity];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(first, last);
    }

    return array;
}

int[] targetArray = binArray(0, 2, 10);

foreach (int item in targetArray)
{
    Console.Write(targetArray[item] + " ");
}