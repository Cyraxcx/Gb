package OOP.w_5.Present;


import java.time.LocalDate;
import java.util.ArrayList;
import java.util.List;

public class StudentsGroup {
    private List<Student> students = new ArrayList<>();




    public List<Student> NewGroup(){
        List<Student> newGroup1 = new ArrayList<>();
        List<Journal> forPetrov = new ArrayList<>();
        forPetrov.add(new Journal(LocalDate.of(2020,1,12), true));
        forPetrov.add(new Journal(LocalDate.of(2020,1,13), true));
        forPetrov.add(new Journal(LocalDate.of(2020,1,14), false));
        newGroup1.add(new Student(1,"Petrov Ivan", forPetrov));


        List<Journal> forVoronova = new ArrayList<>();
        forVoronova.add(new Journal(LocalDate.of(2020,1,12), false));
        forVoronova.add(new Journal(LocalDate.of(2020,1,13), false));
        forVoronova.add(new Journal(LocalDate.of(2020,1,14), false));
        newGroup1.add(new Student(2,"Voronova Inna", forVoronova));

        List<Journal> forKuznecova = new ArrayList<>();
        forKuznecova.add(new Journal(LocalDate.of(2020,1,12), true));
        forKuznecova.add(new Journal(LocalDate.of(2020,1,13), true));
        forKuznecova.add(new Journal(LocalDate.of(2020,1,14), true));
        newGroup1.add(new Student(3,"Kuznecova Marina", forKuznecova));
        return newGroup1;
    }

    @Override
    public String toString() {
        return "StudentsGroup{" +
                "students=" + students +
                '}';
    }
}