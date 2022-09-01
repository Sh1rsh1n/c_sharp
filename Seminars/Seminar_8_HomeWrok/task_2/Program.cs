/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

/*
    CalcSumInEachRow() - на вход принмает двумерный массив
    внутри метода создаем одномерный массив, размер которого равен количеству строк двумерного массива,
    далее складываем суммы чисел в каждой строке двумерного массива
    и заполняем результатами вычислений одномерный массив, затем возвращаем его.
*/
int[] CalcSumInEachRow(int[,] array)
{
    int[] sumArray = new int[array.GetLength(0)];
    int sum;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        sumArray[i] = sum;
        Console.WriteLine($"Сумма строки {i + 1} = {sumArray[i]}");
    }

    return sumArray;
}


/*
    FindMinSumInArray() - простой поиск минимального значения и его индекса в одномерном массиве.
    переменная min - хранит минимальное значение
    переменная minIndex - хранит индекс минимального значения
    после всех вычислений, в консоль выводим результат.
*/
void FindMinSumInArray(int[] array)
{
    int min = array[0];
    int minIndex = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
            minIndex = i;
        }
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов: Строка {minIndex + 1}");
}

/*
FillArray() - вспомогательный метод для заполнения массива рандомными числами.
 Принимает на вход двумерный массив и диапозон значений,
 для заполнения массива рандомными числами.
*/
int[,] FillArray(int row, int column, int minValue, int maxValue)
{
    int[,] array = new int[row, column];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    return array;
}

int[] sumArray = CalcSumInEachRow(FillArray(6, 4, 0, 10)); //инициализировали одномерный массив

Console.WriteLine();

FindMinSumInArray(sumArray); // поиск строки с наименьшей суммой элементов
