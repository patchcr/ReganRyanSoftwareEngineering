using System.Collections.Generic;

namespace ReganRyanSoftwareEngineering {

    public class Person {

        private int id;

        private string firstName;

        private string lastName;

        private string password;

        private Card card;

        private HashSet<PersonGroup> personGroups;

        public Person(int id, string firstName, string lastName, 
            string password, HashSet<PersonGroup> personGroups) {

            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.password = password;
            this.personGroups = personGroups;
        }

        public int ID {
            get { return id; }
        }

        public string FirstName {
            get { return firstName; }
        }

        public string LastName {
            get { return lastName;  }
        }

        public bool Equals(Person p) {
            return p.ID == ID;
        }

        public bool VerifyExistence() {
            return DBUserInterface.GetInstance().VerifyExistence(this);
        }

        public bool ValidatePassword(string pass) {
            return pass.Equals(password);
        }

        public void SaveInfo() {
            DBUserInterface.GetInstance().Save(this);
        }

        public void SavePassword(string password) {
            this.password = password;
        }

        public void SavePersonGroups(HashSet<PersonGroup> personGroups)
        {
            this.personGroups = personGroups;
        }

        public HashSet<PersonGroup> FindPersonGroups() {
            return personGroups;
        }

    }

}
