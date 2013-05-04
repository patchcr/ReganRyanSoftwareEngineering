using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ReganRyanSoftwareEngineering
{
    public partial class CardReaderPanel : Form
    {
        private CardReader currentReader;
        private DateTime currentTime;
        private DoorAccessController dac;
        
        public CardReaderPanel()
        {
            InitializeComponent();
        }
        public CardReaderPanel(CardReader cr, DateTime date)
        {
            InitializeComponent();
            dac = DoorAccessController.Instance;
            currentReader = cr;
            currentTime = date;
            ReaderNameLabel.Text = cr.getName();
            // NOTE for date formating "g" was found here: http://msdn.microsoft.com/en-us/library/zdtaw1bw.aspx
            DateTimeLabel.Text = date.ToString("g");
        }

        private void SwipeButton_Click(object sender, EventArgs e)
        {
            // TODO We should convert this CardNumberTextBox to a masked field or test that the Text does not contain anything but numbers.
            if (dac.ValidateCard(Int32.Parse(CardNumberTextBox.Text)))
            {
                groupBox2.Visible = true;
            }
            else
            {
                MessageBox.Show("Invalid Card Number. Please try again");
            }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MessageBox.Show("Invalid Password Entry. The password must be 4 numbers. No other characters are allowed.");
        }

        private void SubmitPasswordButton_Click(object sender, EventArgs e)
        {
            // TODO Logic for checking to see if the password was correct.  All we have is the cardNumber and password. So some reverse lookup is needed.
            // TODO We need to start a timer if the door is unlocked successfully. 
            groupBox3.Visible = true;
        }

        private void DoorToggleButton_Click(object sender, EventArgs e)
        {
            // TODO Stop the timer to avoid sending an alert to the Security Panel
            if (DoorToggleButton.Text == "Close Door")
            {
                DoorToggleButton.Text = "Open Door";
            }
            else
            {
                DoorToggleButton.Text = "Close Door";
            }
        }

        


    }
}
