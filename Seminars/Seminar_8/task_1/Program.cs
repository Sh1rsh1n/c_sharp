/*
Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, 
которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
*/

//создаем двумерный массив
int[,] FillArray(int row, int column, int min, int max)
{
    int[,] array = new int[row, column];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(min, max + 1);
            Console.Write($"{array[i, j]}\t");
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
    Console.WriteLine($"{minIndexRow}, {minIndexColumn}");



    int[,] tempArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    for (int i = 0; i < tempArray.GetLength(0); i++)
    {
        for (int j = 0; j < tempArray.GetLength(1); j++)
        {
            if (i == minIndexRow -1 || j == minIndexColumn - 1)
            {
                continue;
            }
            else
            {
                tempArray[i, j] = array[i, j];
                Console.Write($"{tempArray[i, j]} ");

            }
        }
        Console.WriteLine();
    }
}

FindMinValue(targetArray);
