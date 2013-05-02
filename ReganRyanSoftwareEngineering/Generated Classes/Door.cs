namespace ReganRyanSoftwareEngineering {

    public class Door {

        private int number;

        private bool closeState;

        private bool lockState;

        private DoorGroup doorGroup;

        public Door(int number, DoorGroup doorGroup) {
            this.number = number;
            this.doorGroup = doorGroup;
        }
        public int GetDoorNumber() { return this.number; }
        public bool CloseState {
            get { return closeState; }
        }

        public bool LockState {
            get { return lockState; }
        }

        public void OpenDoor() {
            closeState = false;
        }

        public void CloseDoor() {
            closeState = true;
        }

        public void Unlock() {
            lockState = false;
        }

        public void Lock() {
            lockState = true;
        }

        public DoorGroup FindDoorGroup() {
            return doorGroup;
        }

    }

}
