using System;

/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/
public class FindSecondNumber
{
    static public void Main ()
    {
	/*
		переменной num присваиваем рандомное значение от 100 до 1000
		чтобы число точно было трехзначным
		и выводим его в консоль
	*/
        int num = new Random().Next(100, 1000);
	 Console.WriteLine($"Input number = {num}");
	 
	 
	 
	 /*
	 	две дополнительные переменные, чисто для краситы :)
		можно обойтись и без них просто написать:
		Console.WriteLine($"Second number = {num / 10 % 10}");
	 */
	 int val = 10;
	 int result = num / val % val;
	 
	 Console.WriteLine($"Second number = {result}");
    }
}
