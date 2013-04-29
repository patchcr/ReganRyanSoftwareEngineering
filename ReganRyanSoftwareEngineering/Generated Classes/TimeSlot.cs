namespace ReganRyanSoftwareEngineering {

    public class TimeSlot {

        private int startHour;

        private int endHour;

        private bool accessPermission;

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

    }

}
