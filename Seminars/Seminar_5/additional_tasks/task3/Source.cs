using System;

public class Program
{
	
	static int[] array7Nums()
	{
		int[] array = new int[7];
		
		for(int i = 0; i < array.Length; i++)
		{
			int num;
			bool value;
			
			do
			{
				string str = Console.ReadLine();
				value = int.TryParse(str, out num);
				
				if(num < 99 && num > 9)
				{
					array[i] = num;
				} 
				else
				{
					value = false;
				}
			}
			while(!value);
		}
		return array;
		
	}
    static public void Main ()
    {
        int[] targetArray = array7Nums();
		
		foreach(int item in targetArray)
		{
			Console.Write(item + " ");
		}
    }
}
