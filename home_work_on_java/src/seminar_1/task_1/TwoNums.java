package seminar_1.task_1;

import java.util.Random;

/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3

*/
public class TwoNums {
    public static void main(String[] args) {
        Random random = new Random();
        int num1 = random.nextInt(100);
        System.out.println(num1);
        int num2 = random.nextInt(100);
        System.out.println(num2);

        if (num1 > num2)
            System.out.println("num1 = " + num1 + " num2 = " + num2 + " -> max = " + num1);
        else if (num2 > num1)
            System.out.println("num1 = " + num1 + " num2 = " + num2 + " -> max = " + num2);
        else
            System.out.println("num1 = " + num1 + " num2 = " + num2 + " -> равны ");

    }
}
