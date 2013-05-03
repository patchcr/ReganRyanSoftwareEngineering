using System.Collections.Generic;
using System;

namespace ReganRyanSoftwareEngineering {

    public class DBCalendarInterface {

        public static DBCalendarInterface instance = new DBCalendarInterface();

        public static DBCalendarInterface Instance {
            get { return instance; }
        }

        private Dictionary<Tuple<PersonGroup, DoorGroup>, Calendar> calendars;

        public DBCalendarInterface() {
            calendars = new Dictionary<Tuple<PersonGroup, DoorGroup>, Calendar>();
        }

        public Calendar RetrieveCalendar(PersonGroup personGroup, DoorGroup doorGroup) {
            return calendars[new Tuple<PersonGroup, DoorGroup>(personGroup, doorGroup)];
        }

    }

}
