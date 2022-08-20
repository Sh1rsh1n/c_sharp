/*
Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2] 

*/

int[] changeElements(int capacity)
{
    int[] array = new int[capacity];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 100);
        Console.Write(array[i] + " ");
    }
    return array;
}


int[] arr = changeElements(10);

foreach (int item in arr)
{
    Console.Write((item * (-1)) + " ");
}







