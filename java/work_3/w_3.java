package work_3;

public class w_3 {

    public static void main(String[] args) {
        int[] arr = { 1, 2, 5, 7, 3, 4, 6 };
        
        int maxNum = arr[0];

        for (int j : arr) {
            if (j > maxNum)
                maxNum = j;
        }

        System.out.println("Макс. число = " + maxNum);

        int minNum = arr[0];

        for (int j : arr) {
            if (j < minNum)
                minNum = j;
        }

        System.out.println("Мин. число = " + minNum);
        int sum = 0;

        for (int j : arr) {
            
            sum += j;
        }
        int sr_ar = sum / 2 ;
        System.out.println("Среднеарифметическое = " +sr_ar);
    }

}
