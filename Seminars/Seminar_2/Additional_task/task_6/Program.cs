/*
Генерируется 10 случайных чисел в интервале (– 20, 20). Выводятся только
положительные числа и сообщения: четное - нечетное
*/

int[] array = new int[10];

for (int i = 0; i < 10; i++)
{
    array[i] = new Random().Next(-20, 20);
    if (array[i] >= 0)
    {
        string s2 = array[i] % 2 == 0 ? "четное" : "нечетное";
        Console.WriteLine($"{array[i]} {s2}");
    }
    /*
    второй вариант решения: 
    ***********************
    
    for (int i = 0; i < 10; i++)
	{
    	int rnd= new Random().Next(-20, 20);
    	if (rnd >= 0)
    	{
        string s2 = rnd % 2 == 0 ? "even" : "odd";
        Console.WriteLine($"{rnd} {s2}");
    } 
    */ 
    
    /*
    третий вариант решения:
    *******************
    
    int count = 0;
	
	while(count < 10)
	{
		int value = new Random().Next(-20,20);
		if(value > 0)
		{
			string str = value % 2 == 0 ? "even" : "odd";
			Console.WriteLine($"{value} is {str}");
		}
	}
   
    */
    
}