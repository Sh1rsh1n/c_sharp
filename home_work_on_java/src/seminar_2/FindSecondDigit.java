/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

public class FindSecondDigit{

    public static void main(String args[]){

       	int number = (int) (Math.random() * 1000);
		System.out.println("number = " + number);
		
		if(number < 100){
			System.out.println("Incorrect number.");
			return;
		} else {
		int result = number / 10 % 10;
		System.out.println("second digit: " + result);
		}
    }
}



