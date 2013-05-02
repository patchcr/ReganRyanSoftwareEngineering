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
        private DBCardReaderInterface crdb;
        public SecurityConsoleInterface()
        {
            InitializeComponent();
            crdb = new DBCardReaderInterface();
            Dictionary<String, CardReader> dict = crdb.GetCardReadersList();
            IList<String> crli = (IList<String>)dict.Keys.ToList();
            CardReaderSelectionList.DataSource = crli ;
        }

    

        private void CardReaderSelectionList_SelectedIndexChanged(object sender, EventArgs e)
        {
            CardReader selected = crdb.GetCardReader(CardReaderSelectionList.SelectedItem.ToString());
            ReaderNameLabel.Text = selected.getName();
            ReaderStatusLabel.Text = selected.IsActive().ToString();
            ReaderNetworkAddressLabel.Text = selected.GetNetWorkAddress();
            ReaderDoorLocationLabel.Text = selected.GetDoor().GetDoorNumber().ToString();
        }

        private void ReactivateCardReaderButton_Click(object sender, EventArgs e)
        {
            CardReader cr;
            String name = (String)CardReaderSelectionList.SelectedItem; //.getName();
            cr = crdb.GetCardReader(name);
            cr.ActiveMode();
            
        }

    }
}
