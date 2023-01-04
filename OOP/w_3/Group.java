package OOP.w_3;


import java.util.*;
import java.util.List;
import java.util.ListIterator;

public class Group implements Iterable<Students>{

   private List<Students> groupStudents;

    public Group(List<Students> groupStudents) {
        this.groupStudents = groupStudents;
    }

    public int getSize(){
        return groupStudents.size();
    }

    public Students get(int index){
        return groupStudents.get(index); 
    }

    @Override
    public Iterator<Students> iterator() {
        return new GroupIterator<>(this);
    }

    
    public ListIterator<Students> listIterator(){
        return new GroupListIterator(this);
    }
        
    public Iterator<Students> descending(){
        return new ReverseIterator(this);
    }
}