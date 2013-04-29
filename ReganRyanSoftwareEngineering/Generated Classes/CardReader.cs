using System.Timers;

namespace ReganRyanSoftwareEngineering {

    public class CardReader {

        private string name;

        private string networkAddress;

        private Door door;

        private int alarmTimer;

        private bool alarmState;

        private Timer timeKeeper;

        private bool activityMode;

        public CardReader(string name, string networdAddress, Door door) {
            this.name = name;
            this.networkAddress = networdAddress;
            this.door = door;
            alarmState = false;
        }

        public void TurnAlarmTimerOn() {
            alarmState = true;
        }

        public void TurnAlarmTimerOff() {
            alarmState = false;
        }

        public void ActiveMode() {
            activityMode = true;
        }

        public void StandbyMode() {
            activityMode = false;
        }

        public void TurnTimeKeeperOn() {
            timeKeeper = new Timer();
            timeKeeper.Start();
        }

        public void TurnTimeKeeperOff() {
            timeKeeper.Stop();
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
