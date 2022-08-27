/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
*/

/*
    метод FillArray() - (взял из предыдущий задачи)
    заполняет двумерный массив, рандомными числами
    в параметры принимает количество строк и столбцов(int row, int column) 
    и минимальное и максимальное значение (int min, int max)

    проходимся, через два цикла for, по всему массиву и каждому элементу присваиваем рандомное значение типа int
    чтобы максимальное число тоже входило в заданый диапазон, нужно выполнить такую конструкцию (max + 1) 
*/
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

/*
    метод SumEveryColumn() принимает на вход двумерный массив
    и вычисляет среднее арифметическое элементов в каждом из столбцов

    в переменную sum мы будем копировать элементы по столбцам,
    чтобы брать элементы по столбцам нужно задать array[j,i] где j - строка, i - столбец
    внутренний цикл проходит по строкам, 
    а внешний по столбцам и выводит каждую итерацию результат вычислений
*/
void SumEveryColumn(int[,] array)
{
    for (int i = 0, sum = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum += array[j, i];
        }
        double average = (double)sum / array.GetLength(1);
        Console.WriteLine("Column {0}, average = {1}", i, average);
        sum = 0;
    }
}

int[,] array = FillArray(5, 5, 0, 100);
SumEveryColumn(array);