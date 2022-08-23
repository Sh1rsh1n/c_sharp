/*
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

public class Task3{
	
	static void cubeTable(int num){
		for(int i = 1; i <= num; i++){
			int cube = (int) Math.pow(i, 3);
		
			System.out.println(i + " -> " + cube);
		}
	}


    public static void main(String args[]){

        cubeTable(10);
    }
}



