package seminar_1.task_3;

import java.util.Random;

/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет

*/
public class EvenNum {
    public static void main(String[] args) {
        Random random = new Random();
        int num1 = random.nextInt(1000);
        System.out.println(num1);

        if (num1 % 2 == 0)
            System.out.println("num -> even");
        else
            System.out.println("num -> odd");
    }
}
