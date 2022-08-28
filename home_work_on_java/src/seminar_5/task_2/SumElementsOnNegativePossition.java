/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
 */
package seminar_5.task_2;

import java.util.Random;

public class SumElementsOnNegativePossition {

    private static int[] fillArray(int capacity){
        int[] array = new int[capacity];
        for (int i = 0; i < array.length; i++) {
            array[i] = new Random().nextInt() / 1_000_000;
            System.out.print(array[i] + " ");
        }
        return array;
    }

    public static void main(String[] args) {
        int[] targetArray = fillArray(10);
        System.out.println();
        int sum = 0;
        for (int i = 0; i < targetArray.length; i++) {
            if(i % 2 == 0){
                System.out.print(targetArray[i] + " + ");
                sum += targetArray[i];
            }
        }

        System.out.print(" = " + sum);
    }
}
