package OOP.w_5.ModelTo;
import java.util.Scanner;

public class Work {
  



    public void showMe() {

        System.out.println("Выберите действие");
        System.out.println("1 - показать студентов и посещаемость");
        System.out.println("2 - отсортировать посещаемость");
        Scanner scan = new Scanner(System.in);
        int i = scan.nextInt();
        while (i < 5) {
            if (i == 1) {
                AttendanceView show = new AttendanceView();
                show.showGroup();
                show.showAttendance();
                break;
            } else if (i == 2) {

            } else if (i == 3) {

            } else if (i == 5) {
                break;
            }
        }

    }
}

