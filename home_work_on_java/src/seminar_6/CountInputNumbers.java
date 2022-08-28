/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
 */
package seminar_6;

import java.util.Scanner;

public class CountInputNumbers {
    static int countOfNumbers() {
        int count = 0;
        Scanner scanner = new Scanner(System.in);
        System.out.println("Enter number. For exit, enter any key and confirm");
        while (scanner.hasNextInt()) {
            int num = scanner.nextInt();
            if (num > 0) {
                System.out.println("You entered is: " + num);
                count++;
            }
        }
        scanner.close();
        return count;
    }

    public static void main(String[] args) {
        int result = countOfNumbers();
        System.out.println("amount of entered numbers" + result);
    }
}
