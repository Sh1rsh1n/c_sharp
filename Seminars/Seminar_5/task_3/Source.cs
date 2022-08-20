using System;

/*
Задача 35: Задайте одномерный массив из 123 случайных чисел.
Найдите количество элементов массива, значения которых лежат в
отрезке [10,99].
*/

public class Program
{
	/*
	метод CountOfRangeElements() 
	*/
	static int CountOfElementsRange(int first, int last, int[] array)
	{
		int count = 0;
	
		foreach(int item in array)
		{
			if(item >= first && item <= last)
			{
				Console.Write(item + " ");
			
				count++;
			}
		}
		Console.WriteLine();
		return count;
	}

    static public void Main ()
    {
        int[] array = new int[10];
		for(int i = 0; i < array.Length; i++)
		{
			array[i] = new Random().Next(0, 1000);
			Console.Write(array[i] + " ");
		}
		
		Console.WriteLine();
		int result = CountOfElementsRange(10, 99, array);
		Console.WriteLine($"count of element = {result}");
    }
}
