using System;

namespace ReganRyanSoftwareEngineering {

    public class Calendar {

        private int year;

        private TypicalWeek week;

        public Calendar(int year, TypicalWeek week) {
            this.year = year;
            this.week = week;
        }

        public TypicalWeek getTypicalWeek()
        {
            return this.week;
        }

        public void ModifyTypicalWeek(TypicalWeek week) {
            this.week = week;
        }

        public void ValidateDate(DateTime date) {
            
        }

        public void SaveModificationInCalendar() {

        }

        public bool ValidateAccess(DateTime date, int accessHour) {
            return week.ReadDay(date).ReadSlots()[accessHour].ReadAccessPermission();
        }

    }

}
