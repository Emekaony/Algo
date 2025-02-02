using System.Text;

namespace basics.algorithms.stringAlgorithms {
    public class Fundamentals() {
        public static bool IsUppercase(string word) {
            return word.All(char.IsUpper);
        }

        public static string Reverse(string word) {
            // just return the string if it's null or empty
            if (string.IsNullOrEmpty(word)) {
                return word;
            }

            // give stringBuilder length for optimization
            StringBuilder sb = new(word.Length);
            for (int i = word.Length - 1; i >= 0; i--) {
                sb.Append(word[i]);
            }

            // get the string from the stringBuilder
            return sb.ToString();
        }

        // given a sentence containing multiple words, return 
        // a sentence with each word reversed
        public static string ReverseEachWord(string sentence) {
            string[] stringArray = sentence.Split(" ");
            for (int i = 0; i < stringArray.Length; i++) {
                stringArray[i] = Reverse(stringArray[i]);
            }
            return string.Join(" ", stringArray);
        }
    }
}