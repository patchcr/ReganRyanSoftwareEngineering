namespace ReganRyanSoftwareEngineering {

    public class Door {

        private static int curNum = 0;

        private int number;

        private bool closeState;

        private bool lockState;

        private DoorGroup doorGroup;

        public Door(DoorGroup doorGroup) {
            this.number = curNum;
            curNum++;
            this.doorGroup = doorGroup;
            closeState = true;
        }

        public int Number {
            get { return this.number; }
        }

        public bool isClosed {
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

        public DoorGroup DoorGroup {
            get { return doorGroup; }
            set { doorGroup = value; }
        }

        public override bool Equals(object obj) {
            return (obj is Door) && number.Equals(((Door) obj).Number);
        }

        public override int GetHashCode() {
            return number;
        }

        public override string ToString() {
            return number + "";
        }

    }

}
