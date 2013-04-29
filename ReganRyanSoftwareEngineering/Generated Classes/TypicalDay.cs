using System.Collections.Generic;

namespace ReganRyanSoftwareEngineering {

    public class TypicalDay {

        private string name;

        public TimeSlot[] timeSlots;

        public TypicalDay(string name) {
            this.name = name;
            timeSlots = new TimeSlot[24];
        }

        public string Name {
            get { return name; }
        }

        public TimeSlot[] ReadSlots() {
            return timeSlots;
        }

    }

}
