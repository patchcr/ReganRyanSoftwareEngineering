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

        public CardReaderPanel() {
            InitializeComponent();
        }

        public CardReaderPanel(CardReader cr, DateTime date) {
            InitializeComponent();
            currentReader = cr;
            ReaderNameLabel.Text = cr.getName();
            // NOTE for date formating "g" was found here: http://msdn.microsoft.com/en-us/library/zdtaw1bw.aspx
            DateTimeLabel.Text = DateTime.Now.ToString("g");
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
            MessageBox.Show("Invalid Password Limit Exceeded. Card Reader now deactivated");
            SecurityConsoleInterface.Instance.Refresh();
            EnterPasswordTextBox.Text = "";
            EnterPasswordBox.Visible = false;
        }

        private void SubmitPasswordButton_Click(object sender, EventArgs e) {
            if (currentReader.EnterPassword(EnterPasswordTextBox.Text)) {
                OpenDoorBox.Visible = true;
            } else {
                if (currentReader.Attempts >= 3) {
                    DisplayExceededInvalidPasswordAttempts();
                } else {
                    DisplayInvalidPassword(currentReader.Attempts);
                }
            }
        }

        private void DoorToggleButton_Click(object sender, EventArgs e) {
            // TODO Stop the timer to avoid sending an alert to the Security Panel
            if (DoorToggleButton.Text == "Close Door") {
                DoorToggleButton.Text = "Open Door";
            } else {
                DoorToggleButton.Text = "Close Door";
            }
        }

    }

}
