using System;

namespace ReganRyanSoftwareEngineering {

    public class Calendar {

        private int year;

        private TypicalWeek week;

        public Calendar(int year) {
            this.year = year;
            this.week = new TypicalWeek();
        }

        public TypicalWeek TypicalWeek {
            get { return week; }
            set { this.week = value; }
        }

        public bool ValidateDate(DateTime date) {
            return date.Year == year;
        }

        public void SaveModificationInCalendar() {
            // Do nothing as data is not persisted to database in this version
        }

        public bool ValidateAccess(DateTime date, int accessHour) {
            return week.ReadDay(date).ReadSlots()[accessHour].ReadAccessPermission();
        }

    }

}
