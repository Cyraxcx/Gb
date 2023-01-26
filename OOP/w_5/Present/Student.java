package OOP.w_5.Present;
import java.util.ArrayList;
import java.util.List;


import java.util.ArrayList;
import java.util.List;

public class Student {
    private int id;
    private String name;

    private List<Journal> attendance = new ArrayList<>();

    public String getName() {
        return name;
    }

    public Student(int id, String name, List<Journal> attendance) {
        this.id = id;
        this.name = name;
        this.attendance = attendance;
    }
    public float attendancePercent(){
        float percent = 0;
        float count = 0;
        float allDay = 0;
        for (Journal each: attendance
        ) { allDay ++;
            if (each.isAttendanceStudent()) count ++;

        }
        percent = count/allDay * 100;
        
        return percent;
    }




    public List<Journal> getAll(){
        List<Journal> copy = new ArrayList<>();
        for (Journal student: attendance
        ) {
            copy.add(student);
        }
        return copy;
    }

    @Override
    public String toString() {
        return "\n Student{" +
                "id=" + id +
                ", name='" + name + '\'' +
                ", attendanse=" + attendance;
    }
}