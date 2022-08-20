using System;

public class Program
{
	static void sizeMonitors(double[] arrayInch)
	{
		int[] arrayMeters = new int[arrayInch.Length];
		
		for(int i = 0; i < arrayInch.Length; i++)
		{
			arrayMeters[i] = (int)(arrayInch[i] * 2.54);
			Console.WriteLine($"size monitor {arrayInch[i]} inch = {arrayMeters[i]} santimeters");
		}
	}

    static public void Main ()
    {
		
       double[] array = {10.1, 11.6, 14, 15.6, 17, 19, 24, 27};
		
		sizeMonitors(array);
    }
}
