/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.
*/

package seminar_5.task_1;

import java.util.Random;

public class ArrayOfThirdDigitNumbers {

    static int[] fillArray(int capacity){
        int[] array = new int[capacity];

        Random rnd = new Random(47);
        for (int i = 0; i < array.length;) {
            int number = rnd.nextInt() / 1000000;
            System.out.print(number + " gen number, ");
            if (number > 99 && number < 1000) {
                array[i] = number;
                System.out.print(number + " added number ");
                i++;
            }
            System.out.println();
        }

        return array;
    }
    public static void main(String[] args) {
        fillArray(10);
    }
}
