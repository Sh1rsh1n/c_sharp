/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

/*
    MultiplyMatrix() - принимает два двумерный массив(матрицы), возвращает так же двумерный массив
    для удобства вычисления, объявим переменную size равную размеру матрицы.
    
    Пример вычислений:
    2 4 | 3 4
    3 2 | 3 3
    resultArray[0,0] += firstMatrix[0, 0] * secondMatrix[0, 0]; 6 = 2 * 3; resultArray[0,0] += 6;
    resultArray[0,0] += firstMatrix[0, 1] * secondMatrix[1, 0]; 12 = 4 * 3; resultArray[0,0] += 12; resultArray[0,0] = 18;
    resultArray[0,1] += firstMatrix[0, 0] * secondMatrix[0, 1]; 8 = 2 * 4; resultArray[0,0] += 8;
    resultArray[0,1] += firstMatrix[0, 1] * secondMatrix[1, 0]; 12 = 4 * 3; resultArray[0,0] += 12; resultArray[0,1] = 20;
    resultArray[1,0] += firstMatrix[1, 0] * secondMatrix[0, 0]; 9 = 3 * 3; resultArray[0,0] += 9;
    resultArray[1,0] += firstMatrix[1, 1] * secondMatrix[1, 0]; 6 = 2 * 3; resultArray[0,0] += 6; resultArray[1,0] = 15;
    resultArray[1,1] += firstMatrix[1, 0] * secondMatrix[0, 1]; 12 = 3 * 4; resultArray[0,0] += 12;
    resultArray[1,1] += firstMatrix[1, 1] * secondMatrix[1, 1]; 6 = 2 * 3; resultArray[0,0] += 6; resultArray[1,0] = 18;
    результат вычислений:
    18 20
    15 18

*/
int[,] MultiplyMatrix(int[,] firstMatrix, int[,] secondMatrix)
{
    int size = firstMatrix.GetLength(0);
    int[,] resultArray = new int[size, size];

    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            for(int k = 0; k < size; k++)
            {
                resultArray[i,j] += firstMatrix[i, k] * secondMatrix[k, j];
            }
        }
    }
    return resultArray;
}

/*
    PrintArray() - вспомогательный метод для вывода на экран всех значений массива
*/
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

/*
 FillArray() - вспомогательный метод для заполнения массива рандомными числами.
 Принимает на вход размер матрицы и диапозон значений,
 для заполнения массива рандомными числами.
*/
int[,] FillArray(int size, int minValue, int maxValue)
{
    int[,] array = new int[size, size];
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    return array;
}


int[,] firstM = {{2, 4}, {3,2}};
int[,] secondM = {{3,4}, {3,3}};
int[,] matrix2x2 = MultiplyMatrix(firstM, secondM);
PrintArray(matrix2x2);
Console.WriteLine();


Console.WriteLine("Create first matrix");
int[,] firstMatrix = FillArray(5, 0, 10);
Console.WriteLine("Create second matrix");
int[,] secondMatrix = FillArray(5, 0, 10);
int[,] result = MultiplyMatrix(firstMatrix, secondMatrix);
PrintArray(result);

