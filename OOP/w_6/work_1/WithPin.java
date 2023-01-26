package OOP.w_6.work_1;

import java.util.Scanner;

public class WithPin extends Unlocker {

    public static void withPin() {
        System.out.println("Введите PIN");
        Scanner scanner = new Scanner(System.in);
        int number = scanner.nextInt();
        if (number >= 1000 & number < 9999)
            System.out.println("Ваш телефон разблокирован");
        else
            System.out.println("Введите 4х значный пинкод");
    }
}
