using basics.algorithms;
using basics.utils;

namespace basics {
    public class Program {
        public static void Main() {
            List<int> array = [1, 2, 3, 4, 5];
            List<int> sequence = [2, 3, 4];
            bool verdict = ArrayAlgorithms.IsSubSequence(array, sequence);
            if (verdict) {
                Console.WriteLine($"{ArrayUtils.PrettyPrintArray(sequence)} is a valid subsequence of {ArrayUtils.PrettyPrintArray(array)}");
            }
        }
    }
}