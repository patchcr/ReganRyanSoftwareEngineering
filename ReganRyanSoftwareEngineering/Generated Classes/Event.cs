namespace ReganRyanSoftwareEngineering {

    public class Event {

        private static int curNum = 0;

        private int number;

        private string description;

        public Event(string description) {
            this.number = curNum;
            curNum++;
            this.description = description;
        }

        public string Description {
            get { return description; }
        }

    }

}
