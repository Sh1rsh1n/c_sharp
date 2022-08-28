package seminar_5.task_3;

import java.util.Random;

public class MinMaxDiff {

    private static int[] fillArray(int capacity) {
        int[] array = new int[capacity];
        for (int i = 0; i < array.length; i++) {
            array[i] = new Random().nextInt() / 1_000_000;
            System.out.print(array[i] + " ");
        }
        return array;
    }

    private static int diffMinMax(int[] array) {
        int min = array[0];
        int max = array[1];
        for (int i = 0; i < array.length; i++) {
            if (array[i + 1] > array[i]) {
                max = array[i + 1];
            }
            if (array[i + 1] < array[i]) {
                min = array[i + 1];
            }
        }
        System.out.println("min = " + min);
        System.out.println("max = " + max);
        return max - min;
    }

    public static void main(String[] args) {
        int[] arr = fillArray(10);

        int result = diffMinMax(arr);

        System.out.println(result);
    }
}
