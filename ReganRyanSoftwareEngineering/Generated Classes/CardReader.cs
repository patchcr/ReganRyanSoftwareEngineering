using System.Timers;
using System.Collections.Generic;
using System;

namespace ReganRyanSoftwareEngineering {

    public class CardReader {

        private string name;

        private string networkAddress;

        private Door door;

        private Timer alarmTimer;

        private double alarmTimeOut;

        private bool alarmState;

        private Timer timeKeeper;

        private double timeKeeperTimeOut;

        private bool activityMode;

        private List<Event> events;

        private Person curPerson;

        private int attempts;

        private CardReaderPanel panel;

        public CardReader(string name, string networdAddress, Door door) {
            this.name = name;
            this.networkAddress = networdAddress;
            this.door = door;
            alarmTimeOut = 10000;
            timeKeeperTimeOut = 10000;
            alarmState = false;
            activityMode = true;
            events = new List<Event>();
        }

        public List<Card> Cards {
            get { return DBUserInterface.Instance.CardList; }
        }

        //public int AlarmTimer {
       //     get { return alarmTimer; }
        //}

        public bool AlarmState {
            get { return alarmState; }
        }

        public string getName() {
            return this.name;
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

        public void TurnAlarmTimerOn(CardReaderPanel panel)
        {
            alarmTimer = new Timer(alarmTimeOut);
            alarmTimer.Elapsed += new ElapsedEventHandler(OnAlarmTimeOut);
            alarmTimer.Start();
            this.panel = panel;
        }

        public void TurnAlarmTimerOff()
        {
            alarmTimer.Stop();
        }

        private void OnAlarmTimeOut(object source, ElapsedEventArgs e)
        {
            alarmState = true;
            this.StandbyMode();
            this.panel.DisplayAlarmAlert();
            alarmTimer.Stop();
        }

        public void TurnTimeKeeperOn(CardReaderPanel panel) {
            timeKeeper = new Timer(timeKeeperTimeOut);
            timeKeeper.Elapsed += new ElapsedEventHandler(OnTimeKeeperTimeOut);
            timeKeeper.Start();
            this.panel = panel;
        }

        private void OnTimeKeeperTimeOut(object source, ElapsedEventArgs e)
        {
            this.GetDoor().Lock();
            this.panel.DisplayDoorRelocking();
            timeKeeper.Stop();
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
                door.Unlock();
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
