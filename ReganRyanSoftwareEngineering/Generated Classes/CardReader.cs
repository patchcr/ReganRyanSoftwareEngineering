namespace ReganRyanSoftwareEngineering {

    public class CardReader {

        private string name;

        private string networkAddress;

        private int alarmTimer;

        private bool alarmState;

        private object timeKeeper;

        private object activityMode;

        public CardReader(string name, string networdAddress) {
            this.name = name;
            this.networkAddress = networdAddress;
            alarmState = false;
        }

        public void TurnAlarmTimerOn() {
            alarmState = true;
        }

        public void TurnAlarmTimerOff() {
            alarmState = false;
        }

        public void ActiveMode() {

        }

        public void StandbyMode() {

        }

        public void TurnTimeKeeperOn() {

        }

        public void TurnTimeKeeperOff() {

        }

        public void ReadCard() {

        }

        public void IdentifyPerson() {

        }

        public void EnterPassword() {

        }

        public void OpenSignal() {

        }

        public void CloseSignal() {

        }

        public void DisplayUnrecognizedCard() {

        }

        public void DisplayInvalidPassword() {

        }

        public void DisplayUnrecognizedAccess() {

        }

        public void SaveEvent() {

        }

    }

}
