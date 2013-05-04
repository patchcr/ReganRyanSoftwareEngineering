using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ReganRyanSoftwareEngineering {

    public partial class CardReaderPanel : Form {

        private CardReader currentReader;
        private DateTime currentDate;

        public CardReaderPanel() {
            InitializeComponent();
        }

        public CardReaderPanel(CardReader cr, DateTime date) {
            InitializeComponent();
            currentReader = cr;
            currentDate = date;
            ReaderNameLabel.Text = cr.getName();
            // NOTE for date formating "g" was found here: http://msdn.microsoft.com/en-us/library/zdtaw1bw.aspx
            DateTimeLabel.Text = currentDate.ToString("g");
        }

        private void SwipeButton_Click(object sender, EventArgs e) {
            if (currentReader.IsActive()) {

                int cardNum = Int32.Parse(CardNumberTextBox.Text);
                if (currentReader.ReadCard(cardNum, this)) {
                    EnterPasswordBox.Visible = true;
                } else {
                    DisplayInvalidCard();
                }
            } else {
                MessageBox.Show("This cardreader is currently in standby mode");
            }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e) {
            MessageBox.Show("Invalid Password Entry. The password must be 4 numbers. No other characters are allowed.");
        }

        public void DisplayInvalidCard() {
            MessageBox.Show("Invalid Card Attempted.");
        }

        public void DisplayInvalidPassword(int attemptNum) {
            MessageBox.Show("Invalid Password. Attempt #" + attemptNum);
        }

        public void DisplayExceededInvalidPasswordAttempts() {
            MessageBox.Show("Invalid Password Limit Exceeded. Card now deactivated");
            SecurityConsoleInterface.Instance.Refresh();
            resetCardReaderPanel();
        }

        public void DisplayAccessNotAuthorized(){
            MessageBox.Show("Access is Not Authorized.");
        }

        public void DisplayDoorRelocking(){
            MessageBox.Show("Door Relocking Now.");
            resetCardReaderPanel();
        }

        private void SubmitPasswordButton_Click(object sender, EventArgs e) {
            int accessHour = currentDate.Hour;
            if (currentReader.EnterPassword(EnterPasswordTextBox.Text)) {
                if (currentReader.ValidateAccess(currentDate.Date, currentDate.Hour)){
                    OpenDoorBox.Visible = true;
                    currentReader.TurnTimeKeeperOn(this);
                } else {
                    DisplayAccessNotAuthorized();
                }
            } else {
                if (currentReader.Attempts >= 3) {
                    DisplayExceededInvalidPasswordAttempts();
                } else {
                    DisplayInvalidPassword(currentReader.Attempts);
                }
            }
        }

        private void DoorToggleButton_Click(object sender, EventArgs e) {

            if (currentReader.GetDoor().CloseState) 
            {   // door is closed.
                currentReader.TurnAlarmTimerOff();

                resetCardReaderPanel();
                

            } else { // User is clicking "Open Door"
                currentReader.TurnAlarmTimerOn();
                currentReader.TurnTimeKeeperOff();
                currentReader.GetDoor().OpenDoor();
                DoorToggleButton.Text = "Close Door";
            }
        }

        private void resetCardReaderPanel()
        {
            OpenDoorBox.Visible = false;
            EnterPasswordBox.Visible = false;
            EnterPasswordTextBox.Text = "";
            EnterCardNumBox.Text = "";
            DoorToggleButton.Text = "Open Door";
        }
    }

}
