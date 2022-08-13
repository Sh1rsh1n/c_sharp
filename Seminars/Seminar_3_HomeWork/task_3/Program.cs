/*
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

/*
    Вызваем метод allCubeNumber() с аргументом, который получаем в результате выполнения метода checkValue()
*/
allCubeNumber(checkValue());

/*
    метод allCubeNumber принимает в качестве аргумента значение типа int и ничего не возвращает (void)
    в цикле for берем каждое значение от 1 до N и возводим в третью степень статическим методом Pow() класса Math
    выводим результат в консоль для каждой итерации цикла.
*/
void allCubeNumber(int N)
{
    for (int i = 1; i <= N; i++)
    {
        double result = Math.Pow(i, 3);
        Console.WriteLine($"Digit {i} at cube = {result}");
    }
}

/*
    метод checkValue() проверяет правильность ввода числового значения,
    чтоб пользователь не мог ввести, например, буквы за место чисел,
    а также проверка на отрицательные числа.
*/
int checkValue()
{
    int digit = 0;
    bool value;
    do
    {
        Console.WriteLine("Input number more zero: ");
        value = int.TryParse(Console.ReadLine(), out digit);
        if (digit < 0)
        {
            value = false;
        }
    } while (!value);

    return digit;
}