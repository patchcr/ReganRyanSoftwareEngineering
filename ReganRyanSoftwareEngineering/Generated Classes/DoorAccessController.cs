using System.Collections.Generic;
using System;

namespace ReganRyanSoftwareEngineering {

    public class DoorAccessController {

        public DoorAccessController() {
            
        }

        public void PasswordValidationRequest() {

        }

        public void FindDoorGroupRequest() {

        }

        public void FindPersonGroupsRequest() {

        }

        public void AccessPermissionsValidationRequest(DateTime date, int accessHour, List<PersonGroup> personGroups, DoorGroup doorGroup) {

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
