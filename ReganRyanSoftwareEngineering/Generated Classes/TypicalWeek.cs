using System.Collections.Generic;
using System;

namespace ReganRyanSoftwareEngineering {

    public class TypicalWeek {

        private string code;

        private TypicalDay[] days;

        public TypicalWeek(string code) {
            days = new TypicalDay[7];
        }

        public TypicalDay ReadDay(DateTime date) {
            Console.WriteLine((int)date.DayOfWeek);
            return days[(int)date.DayOfWeek];
        }

        public void SaveModificationInWeek() {

        }

    }

}
