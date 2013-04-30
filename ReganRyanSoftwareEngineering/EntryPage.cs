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
    public partial class EntryPage : Form
    {
        public CardReaderInstallation cri;
        public EntryPage()
        {
            InitializeComponent();
            cri = new CardReaderInstallation();
        }
        private void AdminConsoleButton_Click(object sender, EventArgs e)
        {
            SupervisorInterface si = new SupervisorInterface();
            si.Show();
        }

        private void SecurityConsoleButton_Click(object sender, EventArgs e)
        {
            SecurityConsoleInterface sc = new SecurityConsoleInterface();
            sc.Show();
        }

        private void CardReaderSelectorButton_Click(object sender, EventArgs e)
        {
            CardReaderSelector crs = new CardReaderSelector();
            crs.Show();
        }
    }
}
