/*
Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, 
которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
*/

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

int[,] targetArray = FillArray(5, 5, 0, 1000);

void FindMinValue(int[,] array)
{
    int min = array[0, 0];
    int minIndexRow = 0;
    int minIndexColumn = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min)
            {
                min = array[i, j];
                minIndexRow = i;
                minIndexColumn = j;
            }
        }
    }

    Console.WriteLine();
    Console.WriteLine($"индексы минимального элемента: строка = {minIndexRow}, столбец = {minIndexColumn}");
    Console.WriteLine();

    int[,] tempArray = new int[array.GetLength(0), array.GetLength(1)];
    Console.WriteLine("Массив после удаления строк и столбцов наименьшего элемента");
    for (int i = 0; i < tempArray.GetLength(0); i++)
    {
        if (i == minIndexRow)
        {
            continue;
        }
        for (int j = 0; j < tempArray.GetLength(1); j++)
        {
            if (j == minIndexColumn)
            {
                continue;
            }
                tempArray[i, j] = array[i, j];
                Console.Write("{0,4}", tempArray[i, j]);
        }
        Console.WriteLine();
    }
}

FindMinValue(targetArray);
