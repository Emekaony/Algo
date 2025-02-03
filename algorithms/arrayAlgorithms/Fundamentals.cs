namespace basics.algorithms.arrayAlgorithms {

    public class Fundamentals {

        public static void TT() {
            int[] elements = [1, 2, 0, 4];
            int foundElement = Array.FindIndex(elements, element => element == 0);
            Console.WriteLine(foundElement);
        }

    }

}