namespace ReganRyanSoftwareEngineering {

    public class Event {

        private int number;

        private string description;

        public Event(string description) {
            this.description = description;
        }

        public string Description {
            get { return description; }
        }

    }

}
