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
        private DBCardReaderInterface crdb;
        public CardReaderSelector()
        {
            InitializeComponent();
            crdb = DBCardReaderInterface.GetInstance();
            Dictionary<String, CardReader> dict = crdb.GetCardReadersList();
            IList<String> crli = (IList<String>)dict.Keys.ToList();
            CardReaderListBox.DataSource = crli;
 
        }
    
        private void LaunchCardReader_Click(object sender, EventArgs e)
        {
            CardReader cr;
            String name = (String)CardReaderListBox.SelectedItem; 
            cr = crdb.GetCardReader(name);
            String sdate = PickDateCalendar.SelectionStart.ToShortDateString();
            String tdate = TimePicker.Value.ToShortTimeString();
            DateTimeConverter dateC = new DateTimeConverter();
            DateTime date = (DateTime)dateC.ConvertFromString(String.Concat(sdate," ", tdate));
            CardReaderPanel crp = new CardReaderPanel(cr, date);
            crp.Show();
        }

        private void CardReaderListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            String name = (String)CardReaderListBox.SelectedItem;
            CardReader selected = crdb.GetCardReader(name);
            ReaderNameLabel.Text = selected.getName();
            ReaderStatusLabel.Text = selected.IsActive().ToString();
            ReaderNetworkAddressLabel.Text = selected.GetNetWorkAddress();
            ReaderDoorLocationLabel.Text = selected.GetDoor().GetDoorNumber().ToString();
        }

        private void PickDateCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            // Not needed
        }

        private void TimePicker_ValueChanged(object sender, EventArgs e)
        {
            // Not needed
        }
    }
}
