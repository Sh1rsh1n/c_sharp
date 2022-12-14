/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

/*
SpiralArray() - заполняет массив числами в порядке возрастания от 1 до N по спирали(в направлении хода часовой стрелки)

P.S. Делал метод для массив 4х4, а в итоге получился универсальный для любого размера (size) массива, при условии
что массив имеет форму квадрата.
*/
int[,] SpiralArray(int size)
{
    int[,] array = new int[size, size]; //инициализировали новый массив

    int i = 0, j = 0; //инициализировали две переменные начальная позиция обхода массива
    int count = 1; //после каждого присвоения на указанную позицию, данная переменная будет увеличивается на 1

    while (size != 0)
    {
        for(int k = 0; k < size - 1; k++) //обходим верхнюю часть массива
        {
            array[i, j++] = count++;
        }
        for (int k = 0; k < size - 1; k++) //обходим правую часть массива
        {
            array[i++, j] = count++;
        }
        for (int k = 0; k < size - 1; k++) //обходим нижнюю часть массива
        {
            array[i, j--] = count++;
        }
        for (int k = 0; k < size - 1; k++) //обходим левую часть массива
        {
            array[i--, j] = count++;
        }

        /*
        каждую итерацию проверяем значение переменной size, если оно меньше 2, 
        то присваиваем size = 0 и выходим из цикла
        если больше 2, то выполнить действие size = size - 2; 
        и цикл продолжит заполнять массив заново, учитываю новую стартовую позицию[i,j] и значение size
        стартовая позиция [i,j] будет каждую итерацию стремиться к центру массива(что нам и нужно)
        */
        size = size < 2 ? 0 : size - 2; 
        i++; 
        j++; 
    }
    return array;
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
            Console.Write("{0,4}", array[i, j]);
        }
        Console.WriteLine();
    }
}

int[,] array = SpiralArray(4);
PrintArray(array);