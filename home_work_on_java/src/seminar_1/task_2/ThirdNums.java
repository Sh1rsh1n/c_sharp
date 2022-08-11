package seminar_1.task_2;

import java.util.Random;

/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22

*/
public class ThirdNums {
    public static void main(String[] args) {
        Random random = new Random();
        int num1 = random.nextInt(1000);
        System.out.println(num1);
        int num2 = random.nextInt(1000);
        System.out.println(num2);
        int num3 = random.nextInt(1000);
        System.out.println(num3);

        int max = num1;

        if (max < num2) max = num2;
        else if (max < num3) max = num3;

        System.out.println("максимальное число = " + max);
    }
}
