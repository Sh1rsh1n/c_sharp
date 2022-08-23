/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/


public class Task2{
	
	static double distance(double x1, double y1, double z1, double x2, double y2, double z2){
		return Math.sqrt((Math.pow(x1 - x2, 2)) + (Math.pow(y1 - y2, 2)) + (Math.pow(z1 - z2, 2)));
	}


    public static void main(String args[]){

        System.out.println(distance(1, 4, 3, 3, 7, 0));
    }
}



