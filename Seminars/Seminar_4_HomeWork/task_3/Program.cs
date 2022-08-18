/*
Задача 29: Напишите программу, которая задаёт массив 
из 8 элементов и выводит их на экран.
*/

/*
метод arrayNums возвращает массив чисел
аргумент capacity задает начальный размер массива
в цикле for проходимся по всем элементам массива и присваиваем каждому рандомное значение
*/
int[] arrayNums(int capacity)
{
    int[] array = new int[capacity];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-1000, 1000);
    }
    return array;
}

/*
вызываем метод arrayNums() с аргументом 10 и присваиваем результат его выполнения новому массиву targetArray
далее в цикле foreach проходимся по всем элементам массива targetArray и выводим все значения в консоль
*/
int[] targetArray = arrayNums(10);
foreach (int item in targetArray)
{
    Console.Write(item + " ");
}