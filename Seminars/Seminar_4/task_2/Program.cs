/*
Задача 28: Напишите программу, которая 
принимает на вход число N и выдаёт 
произведение чисел от 1 до N.
*/


int sum(int num)
{
    int result = 0;
    for (int i = 1; i <= num; i++)
    {
        result *= i;
    }
    return result;
}

Console.WriteLine("Input number: ");
int value = int.Parse(Console.ReadLine());
Console.WriteLine($"result = {sum(value)}");
