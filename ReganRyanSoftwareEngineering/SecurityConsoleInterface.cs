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

        private CardReaderInstallation cri;

        public SecurityConsoleInterface() {
            InitializeComponent();
            cri = CardReaderInstallation.Instance;
            Dictionary<String, CardReader> dict = cri.CardReaders;
            IList<String> crli = (IList<String>)dict.Keys.ToList();
            CardReaderSelectionList.DataSource = crli;
        }

        private void CardReaderSelectionList_SelectedIndexChanged(object sender, EventArgs e) {
            CardReader selected = cri.GetCardReader(CardReaderSelectionList.SelectedItem.ToString());
            ReaderNameLabel.Text = selected.getName();
            ReaderStatusLabel.Text = selected.IsActive() ? "Active" : "Inactive";
            ReaderNetworkAddressLabel.Text = selected.GetNetWorkAddress();
            ReaderDoorLocationLabel.Text = selected.GetDoor().Number.ToString();
        }

        private void ReactivateCardReaderButton_Click(object sender, EventArgs e) {
            CardReader cr;
            String name = (String)CardReaderSelectionList.SelectedItem; //.getName();
            cr = cri.GetCardReader(name);
            cr.ActiveMode();

        }

    }
}
