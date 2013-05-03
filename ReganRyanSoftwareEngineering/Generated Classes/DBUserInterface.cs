using System.Collections.Generic;

namespace ReganRyanSoftwareEngineering {

    public class DBUserInterface {

        private static DBUserInterface instance = new DBUserInterface();

        public static DBUserInterface Instance {
            get { return instance; }
        }

        private List<Person> personList;

        private DBUserInterface() {
            personList = new List<Person>();
        }

        public List<Person> PersonList {
            get { return personList; }
        }

        public bool VerifyExistence(Person p) {
            return personList.Contains(p);
        }

        public bool VerifyExistence(int personID) {
            foreach (Person p in personList) {
                if (p.ID == personID)
                    return true;
            }
            return false;
        }

        public void Save(Person p) {
            personList.Add(p);
        }

    }

}
