/*
Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
*/

void ChangeFirstToLastStringInArray(int[,] array)
{
    int rowSize = array.GetLength(0);
    int columnSize = array.GetLength(1);
    int j = 0;
    while (j < columnSize)
    {
        int temp = array[0, j];
        array[0, j] = array[rowSize - 1, j];
        array[rowSize - 1, j] = temp;
        j++;
    }
}

int[,] FillArray(int row, int column, int min, int max)
{
    int[,] array = new int[row, column];
    Console.WriteLine("Исходный массив");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(min, max + 1);
            Console.Write("{0, 4}", array[i, j]);
        }
        Console.WriteLine();
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0, 4}" , array[i, j]);
        }
        Console.WriteLine();
    }
}

int[,] targetArray = FillArray(4,6,0,100);
ChangeFirstToLastStringInArray(targetArray);
Console.WriteLine();
PrintArray(targetArray);