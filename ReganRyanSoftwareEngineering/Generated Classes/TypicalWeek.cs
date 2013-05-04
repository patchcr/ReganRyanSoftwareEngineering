using System.Collections.Generic;
using System;

namespace ReganRyanSoftwareEngineering {

    public class TypicalWeek {

        private TypicalDay[] days;

        public TypicalWeek() {
            days = new TypicalDay[7];
            days[0] = new TypicalDay("Sunday");
            days[1] = new TypicalDay("Monday");
            days[2] = new TypicalDay("Tuesday");
            days[3] = new TypicalDay("Wednesday");
            days[4] = new TypicalDay("Thursday");
            days[5] = new TypicalDay("Friday");
            days[6] = new TypicalDay("Saturday");
        }

        public void setTypicalDay(TypicalDay day, int index) {
            days[index] = day;
        }

        public TypicalDay ReadDay(DateTime date) {
            return days[(int)date.DayOfWeek];
        }

        public override string ToString() {
            string s = "";
            foreach (TypicalDay d in days) {
                s += d.ToString() + "\n";
            }
            return s;
        }

    }

}