using System.Collections.Generic;
using System;

namespace ReganRyanSoftwareEngineering {

    public class DoorAccessController {

        private List<Door> doors;

        public DoorAccessController() {
            doors = new List<Door>();
        }

        public void PasswordValidationRequest() {

        }

        public void FindDoorGroupRequest() {

        }

        public void FindPersonGroupsRequest() {

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
            return DBCalendarInterface.GetInstance().RetrieveCalendar(personGroup, doorGroup);
        }

        public void DoorUnlockRequest() {

        }

        public void DoorLockRequest() {

        }

        public void DoorOpenRequest() {

        }

        public void DoorCloseRequest() {

        }

    }

}
