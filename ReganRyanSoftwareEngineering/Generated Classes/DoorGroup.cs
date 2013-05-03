using System.Collections.Generic;

namespace ReganRyanSoftwareEngineering {

    public class DoorGroup {

        private string code;

        private string description;

        public DoorGroup(string code, string description) {
            this.code = code;
            this.description = description;
        }

        public string Code {
            get { return code; }
        }

        public string Description {
            get { return description; }
        }

        public override bool Equals(object p) {
            return (p is DoorGroup) && code.Equals(((DoorGroup) p).Code);
        }

        public override int GetHashCode() {
            return code.GetHashCode();
        }

    }

}
