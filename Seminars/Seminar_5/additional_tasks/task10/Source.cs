using System;

public class Program
{
	static void monthAndDays(int month, int day)
	{
		int[] daysOfMonth = 
		{
			31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31
		};
		
		string[] months = 
		{
			"Jan", "Feb", "March", "Apr", "May", "June", "July", "Aug", "Sep", "Oct", "Nov", "Dec"
		};
		
		if(month > 12 && month < 1 && day > 31 && day < 1) return;
		
		Console.WriteLine($"Month: {months[month]}, days amount in current month: {daysOfMonth}, days to end of month: {daysOfMonth}, next month: {months[month]}");
	}

    static public void Main ()
    {
        monthAndDays(3, 25);
    }
}
