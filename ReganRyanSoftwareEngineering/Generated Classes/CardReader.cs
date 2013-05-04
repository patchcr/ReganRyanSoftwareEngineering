using System.Timers;
using System.Collections.Generic;

namespace ReganRyanSoftwareEngineering {

    public class CardReader {

        private string name;

        private string networkAddress;

        private Door door;

        private int alarmTimer;

        private bool alarmState;

        private Timer timeKeeper;

        private bool activityMode;

        private List<Event> events;

        public CardReader(string name, string networdAddress, Door door) {
            this.name = name;
            this.networkAddress = networdAddress;
            this.door = door;
            alarmTimer = 100;
            alarmState = false;
            activityMode = true;
            events = new List<Event>();
        }

        public List<Card> Cards {
            get { return DBUserInterface.Instance.CardList; }
        }

        public int AlarmTimer {
            get { return alarmTimer; }
        }

        public bool AlarmState {
            get { return alarmState; }
        }

        public string getName() {
            return this.name;
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

        public bool IsActive() {
            return activityMode;
        }

        public string GetNetWorkAddress() {
            return this.networkAddress;
        }

        public Door GetDoor() {
            return this.door;
        }

        public void TurnTimeKeeperOn() {
            timeKeeper = new Timer();
            timeKeeper.Start();
        }

        public void TurnTimeKeeperOff() {
            timeKeeper.Stop();
        }

        public void ReadCard(int cardNum, CardReaderPanel panel) {

        }

        public Person IdentifyPerson(Card c) {
            return DBUserInterface.Instance.GetPerson(c.GetPersonID());
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

        public override string ToString() {
            return name;
        }

    }

}
