package codechallenge;

public class PrintingMultiples {

    public static void printMultiples(int A, int X) {
        if (A == 0 || A < 0 || X == 0 || X < 0)  {
            System.out.println("Please pass the valid input for A " + A + " and X as " + X);
        } else {
            int i = 2;
            int Number = A;
            while (Number <= X) {
                System.out.print(Number + "\t");
                Number = A * i;
                i++;
            }
            System.out.println();
        }
    }
}