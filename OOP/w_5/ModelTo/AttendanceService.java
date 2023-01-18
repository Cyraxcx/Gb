package OOP.w_5.ModelTo;

import OOP.w_5.Present.Student;
import OOP.w_5.Present.StudentsGroup;
import java.util.List;

public class AttendanceService {

    private int attendance;
    private StudentsGroup group = new StudentsGroup();

    public void showAllAttendance() {
        StudentsGroup group1 = new StudentsGroup();
        for (Student student : group1.NewGroup()) {
            System.out.printf(student.getName() + " = " + student.attendancePercent() + '\n');

        }

    }
}
