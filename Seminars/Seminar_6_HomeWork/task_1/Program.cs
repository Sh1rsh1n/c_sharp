/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
*/

using System;

public class Program
{
	/*
		fillArray(int capacity) метод создает массив чисел, capacity - начальный размер массива
		в цикле do-while проверяем правильность ввод значения пользователем, если TryParse
		вернет true, то цикл завершает выполнение и по данному индексу массива значение присвоенно успешно.
	*/
	static int[] fillArray(int capacity)
	{
		int[] array = new int[capacity];
		
		for(int i = 0; i < capacity; i++)
		{
			bool val;
			do
			{
				Console.WriteLine("Enter more " + (capacity - i) + " numbers");
				val = int.TryParse(Console.ReadLine(), out array[i]);
				
				if(val) //доп уведомление о корректности ввода значения
				{
					Console.WriteLine("Number is correct");
				}
				else
				{
					Console.WriteLine("Incorrect value");
				}
				Console.WriteLine();
				
			} while(!val);
		}
		return array;
	}
	
    static public void Main ()
    {
		
       	int[] arr = fillArray(9); //создаем массив и присваиваем ему результат выполнения метода fillArray()
		int count = 0; //доп переменная счетчик
		foreach(int i in arr) //проходим по всем элементам массива
		{
			if(i > 0) //если элемент массива > 0 выводим его на экран и увеличиваем переменную счетчик на 1
			{
				count++;
				Console.Write(i + " ");
			}
		}
		Console.WriteLine("-> amount input numbers = " + count); //выводим результат подсчетов
    }
}
