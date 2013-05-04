using System.Timers;
using System.Collections.Generic;
using System;

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

        private Person curPerson;

        private int attempts;

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

        public bool ReadCard(int cardNum, CardReaderPanel panel) {
            Card c = DoorAccessController.Instance.ValidateCard(cardNum);
            if (activityMode && c != null) {
                curPerson = IdentifyPerson(c);
                attempts = 0;
                return true;
            }
            return false;
        }

        public Person IdentifyPerson(Card c) {
            return DBUserInterface.Instance.GetPerson(c.GetPersonID());
        }

        public bool ValidateAccess(DateTime date, int hour)
        {
            DoorAccessController dac = DoorAccessController.Instance;
            HashSet<PersonGroup> pgroups = curPerson.FindPersonGroups();
            List<PersonGroup> pglist = new List<PersonGroup>();
            foreach (PersonGroup pg in pgroups) { pglist.Add(pg); }
            if (dac.AccessPermissionsValidationRequest(date, hour, pglist, door.DoorGroup))
            {
                return true;
            }
            return false;
        }

        public bool EnterPassword(string pass) {
            if (attempts < 3 && curPerson.ValidatePassword(pass)) {
                return true;
            } else {
                attempts++;
                if (attempts >= 3) {
                    //StandbyMode();  We don't disable the reader for this. only the card.
                    curPerson.Card.DeactivateCard();
                    events.Add(new Event("3 Invalid Password Attempts"));
                    SecurityConsoleInterface.Instance.DisplayNotification("3 invalid password attempts");
                }
            }
            return false;
        }

        public int Attempts {
            get { return attempts; }
        }

        public void OpenSignal() {

        }

        public void CloseSignal() {

        }

        public override string ToString() {
            return name;
        }

    }

}
