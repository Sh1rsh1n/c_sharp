/*
Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
В случае, если это невозможно, программа должна вывести сообщение для пользователя.
*/

int[,] ChangeRowsWithColumns(int[,] array)
{
    int[,] newArray = new int[array.GetLength(1), array.GetLength(0)];

    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            newArray[i, j] = array[j, i];
        }
    }
    return newArray;
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

int[,] targetArray = FillArray(5,8,0,100);
int[,] newArray = ChangeRowsWithColumns(targetArray);
Console.WriteLine();
PrintArray(newArray);