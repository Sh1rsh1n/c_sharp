/*

Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

x = (b2 - b1) / (k1 - k2);
y = (k1 * (b2 - b1)) / (k1 - k2) + b1;

*/

using System;

public class Program
{
	/*
		метод CrossingOfLine() принимает 4 параметра типа double
	*/
	static void CrossingOfLine(double b1, double b2, double k1, double k2)
	{
		if (k1==k2 && b1==b2) //линии нахрдятся на одной прямой
    	{
        	Console.WriteLine("The lines is matches");
        	return;
   		 } 
  		else if (k1==k2) //линии параллельны
    	{
        	Console.WriteLine("The lines is parallel.");
        	return;
    	}
  		else //находим точку пересечения двух линий
   		{
      		double x = (b2 - b1) / (k1 - k2);
			double y = (k1 * x + b1);
			Console.Write(x + ", " + y); //выводим результат вычислений
   		}
	}
	
	/*
		checkInput() дополнительный метод для проверки ввода значения
		возвращает значение типа double
		если на вход приходит неверный параметр, то выполняет цикл заново
	*/
	static double InputAndCheck()
	{
		double num;
		bool val;
		do
		{
			Console.WriteLine("Enter number: ");
			val = double.TryParse(Console.ReadLine(), out num);
		}
		while(!val);
		
		return num;
	}

    static public void Main ()
    {
		
		double b1 = InputAndCheck();
		double b2 = InputAndCheck();
		double k1 = InputAndCheck();
		double k2 = InputAndCheck();
			
       CrossingOfLine(b1, b2, k1, k2);
    }
}
