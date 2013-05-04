namespace ReganRyanSoftwareEngineering {

    public class TimeSlot {

        private int startHour;

        private int endHour;

        private bool accessPermission;

        public TimeSlot(int startHour, int endHour, bool accessPermission) {
            this.startHour = startHour;
            this.endHour = endHour;
            this.accessPermission = accessPermission;
        }

        public int StartHour {
            get { return startHour; }
        }

        public int EndHour {
            get { return endHour; }
        }

        public void GrantAccess() {
            accessPermission = true;
        }

        public void RevokeAccess() {
            accessPermission = false;
        }

        public bool ReadAccessPermission() {
            return accessPermission;
        }

        public override string ToString() {
            return accessPermission + "";
        }

    }

}
