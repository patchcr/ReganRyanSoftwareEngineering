namespace ReganRyanSoftwareEngineering {

    public class PersonGroup {

        private string code;

        private string description;

        public PersonGroup(string code, string description) {
            this.code = code;
            this.description = description;
        }

        public string Code {
            get { return code; }
        }

        public string Description {
            get { return description; }
        }

    }

}
