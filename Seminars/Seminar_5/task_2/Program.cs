
/*
Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

*/
int[] array = { 15, 26, 37, 43, 35, 56, 67, 37, 88 };


bool indexOf(int[] array, int num)
{
    int size = array.Length;
    int index = 0;

    while (index < size)
    {
        if (array[index] == num)
        {
            return true;
        }
        index++;
    }
    return false;
}

Console.WriteLine("Число есть в массиве?" + indexOf(array, 35));