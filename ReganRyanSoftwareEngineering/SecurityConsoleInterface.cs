using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ReganRyanSoftwareEngineering {

    public partial class SecurityConsoleInterface : Form {

        private static SecurityConsoleInterface instance = new SecurityConsoleInterface();

        public static SecurityConsoleInterface Instance {
            get { return instance; }
        }

        private CardReaderInstallation cri;

        private List<string> notifications;

        private SecurityConsoleInterface() {
            InitializeComponent();
            notifications = new List<string>();
            cri = CardReaderInstallation.Instance;
        }

        private void CardReaderSelectionList_SelectedIndexChanged(object sender, EventArgs e) {
            showCurrentCardReaderInfo();
        }

        private void ReactivateCardReaderButton_Click(object sender, EventArgs e) {
            CardReader cr;
            String name = (String)CardReaderSelectionList.SelectedItem; //.getName();
            cr = cri.GetCardReader(name);
            cr.ActiveMode();

        }

        public void DisplayNotification(string msg) {
            notifications.Insert(0,msg);
            EventListBox.DataSource = new List<string>();
            EventListBox.DataSource = notifications;
            MessageBox.Show(msg);
        }

        private void showCurrentCardReaderInfo() {
            CardReader selected = cri.GetCardReader(CardReaderSelectionList.SelectedItem.ToString());
            ReaderNameLabel.Text = selected.getName();
            ReaderStatusLabel.Text = selected.IsActive() ? "Active" : "Inactive";
            ReaderNetworkAddressLabel.Text = selected.GetNetWorkAddress();
            ReaderDoorLocationLabel.Text = selected.GetDoor().Number.ToString();
        }

        protected override void OnShown(EventArgs e) {
            base.OnShown(e);
            Dictionary<String, CardReader> dict = cri.CardReaders;
            CardReaderSelectionList.DataSource = (List<String>)dict.Keys.ToList();
            EventListBox.DataSource = notifications;
            showCurrentCardReaderInfo();
        }

        protected override void OnFormClosing(FormClosingEventArgs e) {
            e.Cancel = true;
            this.Hide();
        }

    }
}
