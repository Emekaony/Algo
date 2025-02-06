using basics.oop_practice;

namespace basics {
    public class Program {
        public static void Main(string[] args) {
            Person pp = new("Emeka", "onyeokoro");
            Librarian ll = new("sal", "kieu", 22);
            pp.SayHello();
            ll.SayHello();
        }
    }
}