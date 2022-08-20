/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0

*/

/*
метод sumNegativeElements на вход принимает три значения, 
минимальное и максимальное значение рандомных чисел и размер массива 
*/
int sumNegativeElements(int minValue, int maxValue, int capacity)
{
    int sum = 0; 
    int[] array = new int[capacity]; //создаем массив с заданным размером

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1); //присваиваем элементам массива рандомные значения
        Console.Write(array[i] + " ");

        if (i % 2 == 1) //когда индекс имеет нечётное значение, то суммируем значение 
        {
            sum += array[i];
        }
    }
    Console.WriteLine();
    return sum;
}

int result = sumNegativeElements(0, 10, 10);

Console.WriteLine($"сумм нечётных элементов = {result}");