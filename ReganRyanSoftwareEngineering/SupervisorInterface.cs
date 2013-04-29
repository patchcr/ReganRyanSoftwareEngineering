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
    public partial class SupervisorInterface : Form
    {
        public SupervisorInterface()
        {
            InitializeComponent();
        }

        private void SupervisorInterface_Load(object sender, EventArgs e) {

        }

        private void CreateNewUserButton_MouseClick(object sender, MouseEventArgs e)
        {
            groupBox3.Visible = true;
        }

        private void savePasswordButton_MouseClick(object sender, MouseEventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void UserGroupSelectSubmit_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
        }

        private void ReactivateCardButton_Click(object sender, EventArgs e)
        {

        }

        private void UpdateTypicalWeekButton_Click(object sender, EventArgs e)
        {

        }

        private void CreateUserButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;

        }

    }
}
