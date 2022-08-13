using System;


/*
Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
public class FindWeekendDays
{
    static public void Main()
    {

        /*
            переменной num присваиваем рандомное значение от 1 до 1000
            и выводим его в консоль
        */
        int num = new Random().Next(1, 1000);
        Console.WriteLine($"Input number = {num}");


        /*
           тут признаю, излишне замороченно с тернарным оператором, просто хотелось разнообразия :)
            решение: если num < 8 то переменной daysOfWeek = num, иначе
                   если num кратно 7 то daysOfWeek = 7 иначе daysOfWeek = num % 7
        */
        int daysOfWeek = num < 8 ? num : (num % 7 == 0 ? 7 : num % 7);
        Console.WriteLine($"daysOfWeek = {daysOfWeek}");


        /*
           с помощью switch case проверяем какой же день недели был в переменной num выходной или рабочий.
        */
        switch (daysOfWeek)
        {
            case 1:
            case 2:
            case 3:
            case 4:
            case 5: Console.WriteLine("No. Today is workday"); break;
            case 6:
            case 7: Console.WriteLine("Yes. Today is weekend"); break;
        }
    }
}
