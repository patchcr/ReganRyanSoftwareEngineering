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
        private DoorAccessController dac;

        public SupervisorInterface()
        {
            InitializeComponent();
            dac = DoorAccessController.Instance;

            ExistingDoorsList.DataSource = dac.Doors;
            ExistingUserListBox.DataSource = DBUserInterface.Instance.PersonList;
            ListSelectDoorGroup.DataSource = ExistDoorGroupsList.DataSource = dac.DoorGroups;
            ListSelectUserGroup2.DataSource = ExistingUserGroupsListBox.DataSource = dac.PersonGroups;
            ListSelectUserGroup.DataSource = dac.PersonGroups;
        }

        private void SupervisorInterface_Load(object sender, EventArgs e) {
            
        }

        /************************
         * Create New User Tab *
         * *********************/
        private void CreateNewUserButton_MouseClick(object sender, MouseEventArgs e)
        {
            personCreated = new Person(FirstNameEntry.Text, LastNameEntry.Text, "", null);
            Step2GroupBox.Visible = true;
        }
        private void savePasswordButton_MouseClick(object sender, MouseEventArgs e)
        {
            personCreated.SavePassword(EnterPasswordMaskedText.Text);
            Step3GroupBox.Visible = true;
        }
        private void UserGroupSelectSubmit_Click(object sender, EventArgs e)
        {
            // TODO Convert the ListSelectUserGroup.SelectedItems list collection to a HashSet somehow.
            personCreated.SavePersonGroups(new HashSet<PersonGroup>());

            // Setting up Step 4.
            FirstNameLabel.Text = personCreated.FirstName;
            LastNameLabel.Text = personCreated.LastName;
            PersonIDLabel.Text = personCreated.ID.ToString();
            CardIDLabel.Text = personCreated.Card.GetCardNumber().ToString();
            UserGroupsLabel.Text = personCreated.FindPersonGroups().ToString();
            PasswordLabel.Text = personCreated.ValidatePassword(EnterPasswordMaskedText.Text).ToString();
            Step4GroupBox.Visible = true;
        }
        private void ConfirmInfoPrintCard_Click(object sender, EventArgs e)
        {
            DBUserInterface dbui = DBUserInterface.Instance;
            dbui.Save(personCreated);
            MessageBox.Show("New User Successfully Created. Card is Printing.");
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            // TODO reset functionality
        }

        /***********************
         * Update Calendar Tab *
         * *********************/
        private void ListSelectUserGroup2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListSelectDoorGroup_SelectedIndexChanged_1(sender, e);
        }
        private void ListSelectDoorGroup_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            PersonGroup usergroup = (PersonGroup)ListSelectUserGroup2.SelectedItem;
            DoorGroup doorgroup = (DoorGroup)ListSelectDoorGroup.SelectedItem;
            if (usergroup != null)
            { // MAJOR HACK
                DoorAccessController dac = DoorAccessController.Instance;
                Calendar cal = dac.GetCalendar(usergroup, doorgroup);
                TypicalWeek week = cal.TypicalWeek;
                CheckBox check;
                for (int i = 0; i < 7; i++)
                {
                    // 4/28/2013 is a Sunday
                    TypicalDay dayOfWeek = week.ReadDay(new DateTime(2013, 4, 21 + i));
                    TimeSlot[] ts = dayOfWeek.timeSlots;
                    for (int j = 0; j < 24; j++)
                    {
                        check = (CheckBox)this.tableLayoutPanel1.Controls.Container.GetControlFromPosition(i + 1, j);
                        check.Checked = ts[j].ReadAccessPermission();
                        // TODO get the checked state to save to the checkbox!
                        //this.tableLayoutPanel1.Controls.Container.GetControlFromPosition(i + 1, j).Controls.Cast<CheckBox>() = check;
                        
                    }
                }
            }
        }
        private void UpdateTypicalWeekButton_Click(object sender, EventArgs e)
        {
            PersonGroup usergroup = (PersonGroup)ListSelectUserGroup2.SelectedItem;
            DoorGroup doorgroup = (DoorGroup)ListSelectDoorGroup.SelectedItem;
            DoorAccessController dac = DoorAccessController.Instance;
            Calendar cal = dac.GetCalendar(usergroup, doorgroup);
            TypicalWeek week = cal.TypicalWeek;
            CheckBox check;
            for (int i = 0; i < 7; i++)
            {
                // 4/28/2013 is a Sunday
                TypicalDay dayOfWeek = week.ReadDay(new DateTime(2013, 4, 21+i));
                TimeSlot[] ts = dayOfWeek.TimeSlots;
                for (int j = 0; j < 24; j++)
                {
                    check = (CheckBox)this.tableLayoutPanel1.Controls.Container.GetControlFromPosition(i+1, j);
                    if (check.Checked)
                    {
                        ts[j].GrantAccess();
                    }
                    else
                    {
                        ts[j].RevokeAccess();
                    }
                }
                dayOfWeek.TimeSlots = ts;
                
                week.setTypicalDay(dayOfWeek, i);
            }
            //Console.WriteLine(week);
            cal.TypicalWeek = week;
            dac.SaveCalendar(usergroup, doorgroup, cal);
        }

        /*******************
         * Door Groups Tab *
         * *****************/
        private void DoorGroups_Layout(object sender, LayoutEventArgs e)
        {
            // TODO Use this function to populate the list boxes.
            // I think this gets called before initialization which is a bad idea.

        }

        private void ExistDoorGroupsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            DoorGroup selected = (DoorGroup)ExistDoorGroupsList.SelectedItem;
            DoorMembersListBox.DataSource = dac.FindDoorsByGroup(selected);
        }

        private void EditDoorGroupButton_Click(object sender, EventArgs e)
        {
            EditDoorGroupBox.Visible = true;
            NameOfDoorGroupNameTextbox.Text = ExistDoorGroupsList.SelectedItem.ToString();
            // TODO set the ExistingDoorsList selected items to the members
        }

        private void SaveEditedDoorGroupButton_Click(object sender, EventArgs e)
        {
            // TODO Save edited door state back to the dac
            // This should be able to handle both edited and NEW door groups
        }

        private void CreateNewDoorGroupButton_Click(object sender, EventArgs e)
        {
            NameOfDoorGroupNameTextbox.Text = "";
            ExistingDoorsList.SelectedIndex = 0;
        }
        
        /********************
         * User Groups Tab *
         * *****************/

        private void CreateUserButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;

        }

        private void EditUserGroupButton_Click(object sender, EventArgs e)
        {
            EditUserGroupBox.Visible = true;
            NameOfUserGroupTextbox.Text = ExistingUserGroupsListBox.SelectedItem.ToString();
            // TODO set the ExistingUserListBox selected items to the members.
        }
        private void SaveUserGroupButton_Click(object sender, EventArgs e)
        {
            // TODO save edited user group back to the dac
        }

        private void CreateNewUserGroupButton_Click(object sender, EventArgs e)
        {
            NameOfUserGroupTextbox.Text = "";
            ExistingUserListBox.SelectedIndex = 0;
        }


        /*************************
         * Edit Card Readers Tab *
         * ***********************/














        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditDoorGroupBox.Visible = true;
        }

        private void ReactivateCardButton_Click(object sender, EventArgs e)
        {

        }

        private void ListSelectDoorGroup_SelectedIndexChanged(object sender, EventArgs e) {

        }

        

        

        

        

        

        

        

        

       
        





 
    }
}
