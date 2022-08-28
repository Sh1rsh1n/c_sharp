package seminar_4;/*
Задача 29: Напишите программу, которая задаёт массив 
из 8 элементов и выводит их на экран.
*/


public class FillArrays {
	
	static void fillArray(int capacity, int max){
		int[] array = new int[capacity];
		
		for(int i = 0; i < array.length; i++){
			array[i] = (int) (Math.random() * max);
			System.out.println("index " + i + " : " + array[i]);
		}
	}


    public static void main(String args[]){

        fillArray(10, 100);
    }
}



