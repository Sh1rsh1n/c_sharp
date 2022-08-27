/*
Задача 49
*/

void FillArray(int row, int column)
{
    int[,] array = new int[row, column];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 100);
            if (i % 2 == 0 && j % 2 == 0)
            {
                array[i, j] *= array[i, j];
                Console.Write("{" + array[i, j] + "}\t");
                continue;
            }
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

FillArray(5, 5);