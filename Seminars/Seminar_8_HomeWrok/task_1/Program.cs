/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

/*
    SortedEveryStringArray() - принимает на вход массив чисел и сортирует каждую строку по убыванию
    метод используюет пузырьковую сортировку
    в условие (if) третьего цикла мы проверяем каждое значение в данной строке со всеми остальными
    и в случае, если (array[i, j] < array[i, k]) меняем числа местами

    Пример: 
    Строка_1: 7 5 7 8 10
    array[0,0] < array[0,1] -> false, 7 5 7 8 10
    array[0,0] < array[0,2] -> false, 7 5 7 8 10
    array[0,0] < array[0,3] -> true, 8 5 7 7 10
    array[0,0] < array[0,4] -> true, 10 5 7 7 8
    array[0,1] < array[0,2] -> false, 10 7 5 7 8
    array[0,1] < array[0,3] -> false, 10 7 5 7 8
    array[0,1] < array[0,4] -> true, 10 8 5 7 7
    array[0,2] < array[0,3] -> true, 10 8 7 5 7
    array[0,2] < array[0,4] -> false, 10 8 7 5 7
    array[0,3] < array[0,4] -> true, 10 8 7 7 5
    и т.д с каждой строкой
*/
void SortedEveryStringArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = j + 1; k < array.GetLength(0); k++)
            {
                if (array[i, j] < array[i, k])
                {
                    int temp = array[i, j];
                    array[i, j] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}


/*
 FillArray() - вспомогательный метод для заполнения массива рандомными числами.
 Принимает на вход двумерный массив и диапозон значений,
 для заполнения массива рандомными числами.
*/
void FillArray(int[,] array, int minValue, int maxValue)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
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

int[,] array = new int[5,5]; //инициализировали массив
FillArray(array, 0, 10); //передаем массив для заполнения его рандомными числами.

SortedEveryStringArray(array); //передаем массив для сортировки

Console.WriteLine();

PrintArray(array); //выводим массив после сортировки



