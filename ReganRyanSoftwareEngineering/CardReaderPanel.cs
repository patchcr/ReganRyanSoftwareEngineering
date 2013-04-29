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
        public CardReaderPanel()
        {
            InitializeComponent();
        }
        public CardReaderPanel(CardReader cr)
        {
            InitializeComponent();
            ReaderNameLabel.Text = cr.getName();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            // TODO: Find a real alert dialog for rejected input.
            ThreadExceptionDialog al = new ThreadExceptionDialog(new Exception("Alert, Invalid Password"));
            al.ShowDialog();
        }

        private void SubmitPasswordButton_Click(object sender, EventArgs e)
        {
            // At some point we want to show message if password was correct.
            groupBox3.Visible = true;
        }

        private void SwipeButton_Click(object sender, EventArgs e)
        {
            // If the Card Number is valid we want to show the password entry
            groupBox2.Visible = true;
        }


    }
}
