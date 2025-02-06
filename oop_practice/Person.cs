namespace basics.oop_practice {
    public class Person(string firstname, string? middlename, string lastname) {
        public string firstName = firstname;
        public string lastName = lastname;
        public string? middleName = middlename;

        public Person(string firstname, string lastname) : this(firstname, null, lastname) {
            Console.WriteLine("Called the secondary constructor with no middle name");
        }

        // if u wanna override stuff then make it virtual
        public virtual void SayHello() {
            Console.WriteLine("HIII, I am a person!");
        }

    }

    public class Librarian(string fname, string lname, int libraryNumber) : Person(fname, lname) {
        private int libnum = libraryNumber;

        public override void SayHello() {
            Console.WriteLine("I am a librarian saying hello!");
        }

        // properties
        public int LibNumber {
            get {
                return libnum;
            }

            set {
                if (value < 0) {
                    // c# even reminds you if you accidentally expose private member variable names!
                    throw new ArgumentOutOfRangeException("LibNumber", "library number must be positive!");
                }
                libnum = value;
            }
        }
    }
}