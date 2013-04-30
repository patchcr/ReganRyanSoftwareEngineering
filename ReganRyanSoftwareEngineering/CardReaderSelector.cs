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
    public partial class CardReaderSelector : Form
    {
        CardReaderInstallation crit;
        public CardReaderSelector()
        {
            InitializeComponent();
        }
        public void sendCardReaders(CardReaderInstallation cri)
        {
            this.crit = cri;
        }

        private void LaunchCardReader_Click(object sender, EventArgs e)
        {
            CardReaderInstallation crit = new CardReaderInstallation();
            CardReaderPanel crp = new CardReaderPanel(crit.getCardReaderbyID("1234"));
            crp.Show();
        }
    }
}
