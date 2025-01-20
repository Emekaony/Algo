using System.Text.Json;
using basics.models;

namespace basics.dataprocc {
    public class ReadBasicJson {
        public static void ReadJson() {
            string jsonString = File.ReadAllText("data/simple_json.json");
            try {
                Person? pp = JsonSerializer.Deserialize<Person>(jsonString);
                if (pp != null) {
                    Console.WriteLine(pp.Name);
                }
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }

        }
    }
}