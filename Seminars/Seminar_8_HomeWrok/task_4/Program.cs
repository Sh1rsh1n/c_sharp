/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

/*
    HasSameValue() - метод проверяет, находится ли, данный элемент в массиве
    на вход принимает трехмерный массив и значение, которое нужно проверить
*/
bool HasSameValueInArray(int[,,] array, int value)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i, j, k] == value) 
                {
                    // Console.WriteLine($"значение {value} уже есть в массиве"); для понимания
                    return true;
                }
            }
        }
    }
    return false;
}


/*
    Fill3DArray() - заполняет трехмерный массив рандомными числами от 10 до 99
    во вложенном третьем цикле выполняем проверку с помощью цикла do-while
    присваиваем переменной rndValue значение и в блоке while проверяем с помощью метода HasSameValueInArray,
    если метод возвращает true, то значит значение в массиве уже есть и опять переходим в блок do, 
    где присваиваем переменной rndValue новое значение, так до тех пор пока не будет найдено
    уникальное значение и метод HasSameValueInArray вернет false, 
    только тогда сможем присвоить это значение на данную позицию массива array[i, j, k]
*/
void Fill3DArray(int size)
{
    int[,,] array = new int[size, size, size];
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            for (int k = 0; k < size; k++)
            {
                int rndValue;
                do
                {
                    rndValue = new Random().Next(10, 100);
                }
                while (HasSameValueInArray(array, rndValue));
                array[i, j, k] = rndValue;

                Console.Write($"{array[i, j, k]} ({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}


Fill3DArray(3);