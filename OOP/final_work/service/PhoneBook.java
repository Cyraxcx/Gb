package OOP.final_work.service;


import java.util.LinkedList;

import OOP.final_work.data.ContactMain;

public class PhoneBook{

    private LinkedList<ContactMain> lst;

    public PhoneBook() {
        this.lst = new LinkedList<>();
    }

    public LinkedList<ContactMain> getLst() {
        return lst;
    }


    @Override
    public String toString() {
        String res = "";
        for (Object elem : lst) {
            res = res + elem + "\n";
        }
           return res;
    }

}
