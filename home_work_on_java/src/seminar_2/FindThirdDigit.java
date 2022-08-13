/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

public class FindThirdDigit{

    public static void main(String args[]){

        int number = (int) (Math.random() * 100000000);
		System.out.println("number = " + number);
		
		if(number % 100 == 0){
			System.out.println("number is less 3 digit. Third digit is null");
			return;
		}
		
		int result = 0;
		int value = 10;
		
		while(number > 99){
			result = number % value;
			number /= value;
		}
		
		System.out.println("Third digit = " + result);
		
    }
}



