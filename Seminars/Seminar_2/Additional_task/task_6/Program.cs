/*
Генерируется 10 случайных чисел в интервале (– 20, 20). Выводятся только
положительные числа и сообщения: четное - нечетное
*/

int[] array = new int[10];

for (int i = 0; i < 10; i++)
{
    array[i] = new Random().Next(-20, 20);
    if (array[i] >= 0)
    {
        string s2 = array[i] % 2 == 0 ? "четное" : "нечетное";
        Console.WriteLine($"{array[i]} {s2}");
    }
}