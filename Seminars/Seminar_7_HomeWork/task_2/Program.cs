/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
*/

/*
    метод GetElement() принимает на вход двумерный массив, индекс строки и индекс столбца
    
    Если indexRow или indexColumn >= array.GetLength(), 
    то метод выбрасывает исключение IndexOutOfRangeException
    и сообщение что элемент с индексами (indexRow, indexColumn) не существует.
    Если условие не выполняется, возвращает значение, которое находится по указанному индексу
*/
int GetElement(int[,] array, int indexRow, int indexColumn)
{
    if (indexRow >= array.GetLength(0) || indexColumn >= array.GetLength(1))
    {
        throw new IndexOutOfRangeException($"Invalid index array: ({indexRow}, {indexColumn}) such element is don't exist");
    }
    return array[indexRow, indexColumn];
}

/*
    метод IndexOF() принимает на вход двумерный массив и значение,
    по которое нужно найти в массиве

    Проходим по всем элементам массива и если значение найдено,
    выводим сообщение в консоль и сразу завершаем метод,
    если значение не найдено, так же выводим сообщение об этом в консоль
*/
void IndexOF(int[,] array, int element)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == element)
            {
                Console.WriteLine($"Element is found on possition {i}, {j}");
                return;
            }
        }
    }
    Console.WriteLine($"Element is not found");
}

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


int[,] array = FillArray(5, 4, 0, 10); //создаем новый двумерный массив.
int result = GetElement(array, 4, 2); //получаем результат выполнения метода IndexOf()

Console.WriteLine($"Execution result of method IndexOf(): {result}");

IndexOF(array, 11); //поиск элемента по значению