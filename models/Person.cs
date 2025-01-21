
namespace basics.models {
    // this is called the primary constructor!!!!!
    public class Person(string fname, string lname) {
        // make these private
        private readonly string firstName = fname;
        private readonly string lastName = lname;

        // computed property not a method!
        public string FullName {
            get => $"{firstName} {lastName}";
        }
    }
}