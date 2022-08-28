/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
 */
package seminar_7.task_1;

import java.util.Random;

public class FillArray2D {

    static double[][] fillArray(int row, int column){
        double[][] array = new double[row][column];
        for (int i = 0; i < array.length; i++) {
            for (int j = 0; j < array[i].length; j++) {
                array[i][j] = Math.random() + (new Random().nextInt() / 1_000_000);
                String result = String.format("%.2f", array[i][j]);
                System.out.print(result + " ");
            }
            System.out.println();
        }
        return array;
    }
    public static void main(String[] args) {
        fillArray(5,5);
    }
}
