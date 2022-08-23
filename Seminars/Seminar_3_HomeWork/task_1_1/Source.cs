using System;

public class Program
{
    static public void Main ()
    {
		Console.WriteLine("Input number: ");
		int number = Convert.ToInt32(Console.ReadLine());
		
		findPalindrom(number);
	}
	
	static void findPalindrom(int num)
	{
		int countExp = 0; //счетчик десятков
		int ten = 10;
		int temp = num; //временная переменная для вычисления десятка
		
		while(temp > 10) //пока переменная temp > 10, отнимаем один десяток каждую итерацию и увеличиваем count на 1.
		{
			temp /= ten; 
			countExp++;
		}
		
		Console.WriteLine("exponent = " + countExp);
		
		int digitAmountAtNum = (int) Math.Pow(ten, countExp); //возводим 10 в степень равную countExp
		
		while(num > 0)
		{
			if(num / digitAmountAtNum == num % ten) //проверяем первое и последнее числа
			{
				num = num % digitAmountAtNum / ten; //отнимаем от переменной num первое и последнее числа
				digitAmountAtNum /= ten * ten; //отнимаем два десятка и заново проходим цикл
			}
			else
			{
				Console.WriteLine("Not Palindrom");// если число не является палиндромом выводим сообщение и выходим из метода
				return;
			}
			
			Console.WriteLine(num);
		}
		
		Console.WriteLine("Is Palindrom");
	}
}
