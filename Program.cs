namespace basics {
    public class Program() {
        public static void Main() {
            string word = "emeka";
            string sentence = "emeka is an engineer";
            string reversedWord = algorithms.stringAlgorithms.Fundamentals.Reverse(word);
            string reversedSentence = algorithms.stringAlgorithms.Fundamentals.ReverseEachWord(sentence);
            Console.WriteLine(reversedWord);
            Console.WriteLine(reversedSentence);
            algorithms.arrayAlgorithms.Fundamentals.TT();
        }
    }
}