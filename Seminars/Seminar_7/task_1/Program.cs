/*
Задача 48
*/

void FillArray(int row, int column)
{
    int[,] array = new int[row, column];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = i + j;
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

FillArray(5,5);