package work_1;
//Вывести все простые числа от 1 до 1000

import java.util.Scanner;
public class w_3 {
    public static void main(String[] args) {
        System.out.println("Введите положительное число: ");
        Scanner in = new Scanner(System.in);
        int input = in.nextInt();
        boolean b = true;
        for (int P = 2; P <= input; P++) {
            for (int i = 2; i < P; i++) {
                if (P % i == 0) {
                    b = false;
                    break;
                }
            }
            if (b) System.out.println(P);
            else b = true;
        }
    } 
}
