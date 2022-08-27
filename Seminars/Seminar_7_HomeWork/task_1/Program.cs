/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

/*
    метод FillArray() - заполняет двумерный массив, вещественными числами(double)
    в параметры принимает количество строк и столбцов(int row, int column) 
    и минимальное и максимальное значение (int min, int max)

    проходимся, через два цикла for, по всему массиву и каждому элементу присваиваем рандомное число
    так как new Random().NextDouble() возврашает число от 0.0 до 1.0,
    то будем прибавлять к нему значение new Random().Next(min, max + 1)
    чтобы максимальное число тоже входило в заданый диапазон, нужно выполнить такую конструкцию (max + 1) 
*/
double[,] FillArray(int row, int column, int min, int max)
{
    double[,] array = new double[row, column];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().NextDouble() + new Random().Next(min, max + 1);
        }
    }
    return array;
}


/*
    метод PrintArray() выводит в консоль все элементы двумерного массива,
    который метод принял в параметрах
    через два цикла for проходимся по все элементам массива
    и печатаем каждый в консоль, 
    когда цикл прошел одну строку, он переходит на другую и печатет значения с новой строки
*/

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("| {0:f2}\t", array[i, j]); //интерполяция для красивого вывода в консоль
            if(j == array.GetLength(1) - 1) //доп условие для красивого вывода в консоль
            {
                Console.Write("|");
            }
        }
        Console.WriteLine();
    }
}

double[,] targetArray = FillArray(5, 3, -10, 10);
PrintArray(targetArray);