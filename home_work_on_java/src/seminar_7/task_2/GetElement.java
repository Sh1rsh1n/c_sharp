package seminar_7.task_2;

import java.util.Random;

public class GetElement {
    static int getValue(int[][] array, int indexRow, int indexColumn) {
        if (indexRow >= array.length || indexColumn >= array[0].length) {
            throw new IndexOutOfBoundsException("Invalid index array");
        }
        return array[indexRow][indexColumn];
    }

    static int[][] fillArray(int row, int column) {
        int[][] array = new int[row][column];
        for (int i = 0; i < array.length; i++) {
            for (int j = 0; j < array[i].length; j++) {
                array[i][j] = new Random().nextInt() / 1_000_000;
                System.out.print(array[i][j] + " ");
            }
            System.out.println();
        }
        return array;
    }

    public static void main(String[] args) {
        int[][] array = fillArray(4, 4);
        int value = getValue(array, 3, 4);
        System.out.println(value);
    }
}
