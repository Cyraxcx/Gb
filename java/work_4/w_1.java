package work_4;
import java.util.ArrayDeque;
import java.util.Deque;
import java.util.LinkedList;
//Пусть дан LinkedList с несколькими элементами. Реализуйте метод, который вернет “перевернутый” список.
public class w_1 {


    public static void main(String[] args) {
        LinkedList<String> lk = new LinkedList<>();
        lk.add("Germany");
        lk.add("France"); 
        lk.add("Great Britain"); 
        lk.add("Spain"); 
        lk.add("Italy");
        
        ArrayDeque<String> dq = new ArrayDeque<String>();
        for (int i = 0; i < lk.size(); i++) {
            dq.add(lk.remove(i));
            i--;
        }
        System.out.println(dq);
        for (int i = 0; i < dq.size(); i++) {
            lk.add(dq.removeLast());
            i--;
        }
        System.out.println(lk);
    }
}

