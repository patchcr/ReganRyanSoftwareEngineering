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
    public partial class SecurityConsoleInterface : Form
    {
        public SecurityConsoleInterface()
        {
            InitializeComponent();
            //CardReaderSelectionList.DataSource = new Dictionary<string,string>();
        }

    

        private void CardReaderSelectionList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReaderNameLabel.Text = "test1";
            ReaderStatusLabel.Text = "test2";
            ReaderNumEventsLabel.Text = "test3";
        }

        private void ReactivateCardButton_Click(object sender, EventArgs e)
        {
            //TODO Reactiveate Card
        }
    }
}
