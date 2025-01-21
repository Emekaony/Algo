using basics.models;

namespace basics {
    public class Program {
        public static void Main() {
            Person pp = new("Nnaemeka", "Onyeokoro");
            Console.WriteLine(pp.FullName);
        }
    }
}