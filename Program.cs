using basics.algorithms.stringAlgorithms;

namespace basics {
    public class Program() {
        public static void Main() {
            string word = "emeka";
            string sentence = "emeka is an engineer";
            string reversedWord = Fundamentals.Reverse(word);
            string reversedSentence = Fundamentals.ReverseEachWord(sentence);
            Console.WriteLine(reversedWord);
            Console.WriteLine(reversedSentence);
        }
    }
}