namespace basics.utils {
    public class ArrayUtils {
        public static string PrettyPrintArray(List<int> arr) {
            return $"[{string.Join(",", arr)}]";
        }
    }
}