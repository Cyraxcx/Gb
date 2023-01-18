package OOP.w_5.Present;


import java.time.LocalDate;

public class Journal {
    private LocalDate date;
    private boolean attendanceStudent;


    public Journal(LocalDate date, boolean attendanceStudent) {
        this.date = date;
        this.attendanceStudent = attendanceStudent;

    }

    public boolean isAttendanceStudent() {
        return attendanceStudent;
    }

    @Override
    public String toString() {
        return "Journal{" +
                "date=" + date +
                ", attendanceStudent=" + attendanceStudent +
                '}';
    }
}