using System.Collections.Generic;

namespace ReganRyanSoftwareEngineering {

    public class DBUserInterface {

        private static DBUserInterface instance = new DBUserInterface();

        public static DBUserInterface GetInstance() {
            return instance;
        }

        private HashSet<Person> personList;

        private DBUserInterface() {
            personList = new HashSet<Person>();
        }

        public bool VerifyExistence(Person p) {
            return personList.Contains(p);
        }

        public void Save(Person p) {
            personList.Add(p);
        }

    }

}
