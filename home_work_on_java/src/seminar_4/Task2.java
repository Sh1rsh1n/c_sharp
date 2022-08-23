/*
Задача 27: Напишите программу, которая принимает на 
вход число и выдаёт сумму цифр в числе.
*/


public class Task2{
	
	static int sumDigits(int num){
		
		int sum = 0;
		
		while(num > 0){
			sum += num % 10;
			num /= 10;
		}
		
		return sum;
	}


    public static void main(String args[]){

        int result = sumDigits(123456789);
		
		System.out.println(result);
    }
}



