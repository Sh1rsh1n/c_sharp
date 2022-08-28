package seminar_4;/*
Задача 25: Напишите цикл, который принимает на вход 
два числа (A и B) и возводит число A в натуральную 
степень B
*/

public class Exponent {
	static int exponent(int num, int ex){
		return (int) Math.pow(num, ex);
	}

    public static void main(String args[]){

        System.out.println("exponent = " + exponent(2, 5));

    }
}



