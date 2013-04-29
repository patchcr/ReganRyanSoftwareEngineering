using System.Collections.Generic;

namespace ReganRyanSoftwareEngineering {

    public class TypicalDay {

        private string name;

        public TimeSlot[] timeSlots;

        public TypicalDay() {
            timeSlots = new TimeSlot[24];
        }

        public TimeSlot[] ReadSlots() {
            return timeSlots;
        }

    }

}
