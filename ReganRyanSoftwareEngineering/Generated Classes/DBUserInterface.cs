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
            HashSet<PersonGroup> groups = new HashSet<PersonGroup>();
            groups.Add(DoorAccessController.Instance.PersonGroups[0]);
            Save(new Person("Michael", "Regan", "1234", groups));
        }

        public List<Person> PersonList {
            get { return personList; }
        }

        public List<Card> CardList {
            get {
                List<Card> list = new List<Card>();
                foreach (Person p in personList) {
                    list.Add(p.Card);
                }
                return list;
            }
        }

        public Person GetPerson(int personId) {
            foreach (Person p in personList) {
                if (p.ID == personId)
                    return p;
            }
            return null;
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
