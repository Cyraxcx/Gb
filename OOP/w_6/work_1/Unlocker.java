package OOP.w_6.work_1;

import java.util.Scanner;

public class Unlocker {

    public static void mode() {
        System.out.println(
                "Выберите режим разблокировки:\n 1 - без пароля\n 2 - ввести PIN\n 3 - по FaceID\n 4 - по отпечатку пальца");
        Scanner scanner = new Scanner(System.in);
        int num = scanner.nextInt();

        switch (num) {
            case 1:
                WithoutPin woP = new WithoutPin();
                woP.withoutPin();
                break;
            case 2:
                WithPin wiP = new WithPin();
                wiP.withPin();
                break;
            case 3:
                FaceIdPin face = new FaceIdPin();
                face.faceIdPin("FACE");
                break;
            case 4:
                TouchPin finger = new TouchPin();
                finger.touchPin("FINGER");
                break;

        }

    };

}
