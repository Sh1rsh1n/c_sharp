/*
Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
import java.util.Scanner;

public class FindWeekendDays{

    public static void main(String args[]){
		
        	Scanner scan = new Scanner(System.in);
		int value = scan.nextInt();
		
		int result = value < 8 ? value : (value % 7 == 0 ? 7 : value % 7);
		System.out.println("result = " + result);
		
		switch(result)
		{
			case 1:
			case 2:
			case 3:
			case 4:
			case 5: System.out.println("is workday"); break;
			case 6:
			case 7: System.out.println("is weekend"); break;
		}
    }
}



