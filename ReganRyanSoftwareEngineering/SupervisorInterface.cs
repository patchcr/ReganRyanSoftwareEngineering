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
        private Person personCreated;

        public SupervisorInterface()
        {
            InitializeComponent();

        }

        private void SupervisorInterface_Load(object sender, EventArgs e) {
            
        }

        private void CreateNewUserButton_MouseClick(object sender, MouseEventArgs e)
        {
            Random rand = new Random(1234);
            int pid = rand.Next(100);
            personCreated = new Person(pid, FirstNameEntry.Text, LastNameEntry.Text, "", null);
            groupBox3.Visible = true;
        }

        private void savePasswordButton_MouseClick(object sender, MouseEventArgs e)
        {
            personCreated.SavePassword(EnterPasswordMaskedText.Text);
            groupBox1.Visible = true;
        }

        private void UserGroupSelectSubmit_Click(object sender, EventArgs e)
        {
            label15.Text = FirstNameEntry.Text;
            groupBox2.Visible = true;
        }

        private void ReactivateCardButton_Click(object sender, EventArgs e)
        {

        }

        private void UpdateTypicalWeekButton_Click(object sender, EventArgs e)
        {
            PersonGroup usergroup = (PersonGroup)ListSelectUserGroup2.SelectedItem;
            DoorGroup doorgroup = (DoorGroup)ListSelectDoorGroup.SelectedItem;
            DBCalendarInterface dbcal = DBCalendarInterface.GetInstance();
            Calendar cal = dbcal.RetrieveCalendar(usergroup, doorgroup);
            TypicalWeek week = cal.getTypicalWeek();
            CheckBox check;
            for (int i = 0; i < 7; i++)
            {
                // 4/28/2013 is a Sunday
                TypicalDay dayOfWeek = week.ReadDay(new DateTime(2013, 4, 28+i));
                TimeSlot[] ts = dayOfWeek.timeSlots;
                for (int j = 0; j < 24; j++)
                {
                    check = (CheckBox)this.tableLayoutPanel1.Controls.Container.GetControlFromPosition(i+1, j);
                    if (check.Checked)
                    {
                        ts[i].GrantAccess();
                    }
                    else
                    {
                        ts[i].RevokeAccess();
                    }
                }
                dayOfWeek.timeSlots = ts;
                week.setTypicalDay(dayOfWeek, i);
            }
            cal.ModifyTypicalWeek(week);
            // I think we need to send cal back to the dbCalendarInterface for storage?
        }

        private void CreateUserButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditDoorGroupBox.Visible = true;
        }

 
    }
}
