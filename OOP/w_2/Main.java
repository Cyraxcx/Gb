package OOP.w_2;

import java.util.Arrays;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

public class Main {
    
    public static void main(String[] args) {
        JsonWriteFile enter = new JsonWriteFile();
        enter.writer();
        XmlWriteFile enter1 = new XmlWriteFile();
        enter1.writer();
        TxtWriteFile enter2 = new TxtWriteFile();
        enter2.writer();
}
}