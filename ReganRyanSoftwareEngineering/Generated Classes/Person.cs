using System.Collections.Generic;

namespace ReganRyanSoftwareEngineering {

    public class Person {

        private static int curCount = 1;

        private int id;

        private string firstName;

        private string lastName;

        private string password;

        private Card card;

        private HashSet<PersonGroup> personGroups;

        public Person(string firstName, string lastName,
            string password, HashSet<PersonGroup> personGroups) {

            this.id = curCount;
            curCount++;
            this.firstName = firstName;
            this.lastName = lastName;
            this.password = password;
            card = new Card();
            card.SetPersonID(ID);
            this.personGroups = personGroups;
        }

        public int ID {
            get { return id; }
        }

        public string FirstName {
            get { return firstName; }
        }

        public string LastName {
            get { return lastName; }
        }

        public Card Card {
            get { return card; }
        }

        public override bool Equals(object p) {
            return (p is Person) && ID.Equals(((Person) p).ID);
        }

        public override int GetHashCode() {
            return ID.GetHashCode();
        }

        public bool VerifyExistence() {
            return DBUserInterface.Instance.VerifyExistence(this);
        }

        public bool ValidatePassword(string pass) {
            return pass.Equals(password);
        }

        public void SaveInfo() {
            DBUserInterface.Instance.Save(this);
        }

        public void SavePassword(string password) {
            this.password = password;
        }

        public void SavePersonGroups(HashSet<PersonGroup> personGroups) {
            this.personGroups = personGroups;
        }

        public HashSet<PersonGroup> FindPersonGroups() {
            return personGroups;
        }

        public override string ToString() {
            return lastName + ", " + firstName;
        }

    }

}
