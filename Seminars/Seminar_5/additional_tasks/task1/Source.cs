/*

*/

using System;

public class Program
{
    static public void Main ()
    {
		int value = 7;
	
       string[] array = {"Mon", "Thu", "Wen", "Trs", "Fri", "Sat", "Sun"};
		
		switch(value)
		{
			case 1: Console.WriteLine(array[0] + " to Sunday " + (7 - value) + " days"); break;
			case 2: Console.WriteLine(array[1] + " to Sunday " + (7 - value) + " days"); break;
			case 3: Console.WriteLine(array[2] + " to Sunday " + (7 - value) + " days"); break;
			case 4: Console.WriteLine(array[3] + " to Sunday " + (7 - value) + " days"); break;
			case 5: Console.WriteLine(array[4] + " to Sunday " + (7 - value) + " days"); break;
			case 6: Console.WriteLine(array[5] + " to Sunday " + (7 - value) + " days"); break;
			case 7: Console.WriteLine(" Today is Sunday!"); break;
			default: Console.WriteLine("incorrect value"); break;
		}
		
    }
}
