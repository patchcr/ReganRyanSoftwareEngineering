using System.Collections.Generic;
using System;

namespace ReganRyanSoftwareEngineering {

    public class DoorAccessController {

        private static DoorAccessController instance = new DoorAccessController();

        public static DoorAccessController Instance {
            get { return instance; }
        }

        private List<DoorGroup> doorGroups;

        private List<Door> doors;

        private List<PersonGroup> personGroups;

        public DoorAccessController() {
            doorGroups = new List<DoorGroup>();
            doors = new List<Door>();
            personGroups = new List<PersonGroup>();
        }

        public List<Door> Doors {
            get { return doors; }
        }

        public void CreateDoor(DoorGroup dg) {
            doors.Add(new Door(dg));
        }

        public bool PasswordValidationRequest(string pass) {
            return true;
        }

        public List<DoorGroup> FindDoorGroupRequest() {
            return doorGroups;
        }

        public List<Door> FindDoorsByGroup(DoorGroup dg) {
            List<Door> list = new List<Door>();
            foreach (Door d in doors) {
                if (d.FindDoorGroup().Equals(dg)) {
                    list.Add(d);
                }
            }
            return list;
        }

        public List<PersonGroup> FindPersonGroupsRequest() {
            return personGroups;
        }

        public List<Person> FindPeopleByGroup(PersonGroup pg) {
            List<Person> list = new List<Person>();
            foreach (Person p in DBUserInterface.Instance.PersonList) {

            }
            return list;
        }

        public bool AccessPermissionsValidationRequest(DateTime date, int accessHour, List<PersonGroup> personGroups, DoorGroup doorGroup) {
            foreach (PersonGroup pg in personGroups) {
                if (GetCalendar(pg, doorGroup).ValidateAccess(date, accessHour)) {
                    return true;
                }
            }
            return false;
        }

        public Calendar GetCalendar(PersonGroup personGroup, DoorGroup doorGroup) {
            return DBCalendarInterface.Instance.RetrieveCalendar(personGroup, doorGroup);
        }

        public bool ValidateCard(int cardNum) {
            foreach (Person p in DBUserInterface.Instance.PersonList) {
                if (p.Card.GetCardNumber() == cardNum) {
                    return true;
                }
            }
            return false;
        }

    }

}
