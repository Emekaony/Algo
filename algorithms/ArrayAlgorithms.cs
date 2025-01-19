namespace basics.algorithms {
    public class ArrayAlgorithms {
        public static bool IsSubSequence(List<int> array, List<int> sequence) {
            // start at 0
            int idx = 0;
            int idx2 = "emeka".LastIndexOf('a');
            Console.WriteLine(idx2);
            for (int i = 0; i < array.Count; i++) {
                if (array[i].Equals(sequence[idx])) {
                    idx++;
                    if (idx.Equals(sequence.Count)) {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}