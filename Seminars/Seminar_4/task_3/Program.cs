/*
Задача 30: Напишите программу, которая 
выводит массив из 8 элементов, заполненный 
нулями и единицами в случайном порядке.
*/


int[] binArray(int capacity)
{
    int[] array = new int[capacity];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0,2);
    }

    return array;
}

int[] targetArray = binArray(10);

foreach (int item in targetArray)
{
    Console.Write(targetArray[item] + " ");
}