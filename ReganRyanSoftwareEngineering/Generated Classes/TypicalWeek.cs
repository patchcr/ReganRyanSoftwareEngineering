using System.Collections.Generic;
using System;

namespace ReganRyanSoftwareEngineering {

    public class TypicalWeek {

        private TypicalDay[] days;

        public TypicalWeek() {
            days = new TypicalDay[7];
        }

        public void setTypicalDay(TypicalDay day, int index) {
            days[index] = day;
        }

        public TypicalDay ReadDay(DateTime date) {
            Console.WriteLine((int)date.DayOfWeek);
            return days[(int)date.DayOfWeek];
        }

    }

}