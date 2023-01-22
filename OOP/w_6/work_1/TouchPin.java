package HW5.Task1;

public class TouchPin extends Unlocker {
    public static String touchPin(String finger) {
        System.out.println("Отпечаток пальца распознан, телефон разблокирован");
        return finger;
    }
}
