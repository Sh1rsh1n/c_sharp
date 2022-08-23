/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет
12821 -> да
23432 -> да
*/

public class Task1{
	static void findPalindrom(int num){
		
		int countExp = 0;
		int temp = num;
		int dec = 10;
		
		while(temp > dec){
			countExp++;
			temp /= dec;
		}
		
		int digitAmountAtNum = (int) Math.pow(dec, countExp);
		
		while(num > dec){
			if(num / digitAmountAtNum == num % dec){
				num = num % digitAmountAtNum / dec;
				digitAmountAtNum /= dec * dec;
			} else {
				System.out.println("Isn't palindrom");
				return;
			}
		}
		System.out.println("Is palindrom");
	}


    public static void main(String args[]){
		
        findPalindrom(12345432);
    }
}



