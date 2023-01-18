package OOP.w_5.ModelTo;
import OOP.w_5.Present.StudentsGroup;

public class AttendanceView {

    public void showGroup(){
        StudentsGroup group1 = new StudentsGroup();
        System.out.println(group1.NewGroup());
    }
    public void showAttendance(){
        AttendanceService attendanceService = new AttendanceService();
        attendanceService.showAllAttendance();
    }
}
