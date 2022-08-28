/*
Задача 51
*/

int[,] FillArray(int row, int column)
{
    int[,] array = new int[row, column];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 101);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    return array;
}


int DiagonalSum(int[,] matrix)
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == j)
            {
                sum += matrix[i, j];
            }
        }
    }
    return sum;
}

int[,] array = FillArray(5, 5);

int result = DiagonalSum(array);

Console.WriteLine(result);