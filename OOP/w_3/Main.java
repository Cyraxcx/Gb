package OOP.w_3;

import java.time.LocalDate;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.*;
import java.util.List;

public class Main{
// //Класс Группа содержит в себе коллекцию Студентов. По группе можно перемещаться с помощью итератора.

// Создайте класс GroupListIterator, который позволяет перемещаться по группе в обоих направлениях. 
// Он реализует интерфейс ListIterator<Student>.
// Добавьте в Группу метод listIterator (), который позволяет начать итерацию с помощью GroupListIterator.

// Создайте класс ReverseIterator, который работает как итератор по группе в обратном направлении:
// • Он отслеживает текущую позицию в переборе
// • Он изначально выставлен на конечную позицию
// • Он движется справа налево
// Проверьте, как он работает.
    public static void main(String[] args) {
        Group listStud = new Group(Arrays.asList(
        new Students("Леонид",LocalDate.of(2001,12,14), 5.0f),
        new Students("Федор",LocalDate.of(2001,11,1), 3.0f),
        new Students("Ирина",LocalDate.of(2001,1,4), 4.0f)
        ));

        Iterator<Students> it =  listStud.descending();
        ListIterator<Students> two =  listStud.listIterator();


        for(Students stud:listStud){
            System.out.println(stud);
        }
        System.out.println();
        while(it.hasNext()){
            System.out.println(it.next());
        }
        System.out.println();
        while(two.hasPrevious()){
            System.out.println(two.previous());
        }
        System.out.println();
        while(two.hasNext()){
            System.out.println(two.next());
        }
        
}
}