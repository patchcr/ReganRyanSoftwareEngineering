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
            UpdateSources();
        }

        private void UpdateSources() {
            ExistingDoorsList.DataSource = dac.Doors;

            CardReaderListBox.DataSource = CardReaderInstallation.Instance.CardReaders.Keys.ToList();

            UserMembersListBox.DataSource = ExistingUserListBox.DataSource = new List<Person>();
            UserMembersListBox.DataSource = ExistingUserListBox.DataSource = DBUserInterface.Instance.PersonList;

            ListSelectDoorGroup.DataSource = ExistDoorGroupsList.DataSource = new List<DoorGroup>();
            ListSelectDoorGroup.DataSource = ExistDoorGroupsList.DataSource = dac.DoorGroups;

            ListSelectUserGroup.DataSource = ListSelectUserGroup2.DataSource = ExistingUserGroupsListBox.DataSource = new List<PersonGroup>();
            ListSelectUserGroup.DataSource = ListSelectUserGroup2.DataSource = ExistingUserGroupsListBox.DataSource = dac.PersonGroups;
        }

        private void SupervisorInterface_Load(object sender, EventArgs e) {
            
        }

        /************************
         * Create New User Tab *
         * *********************/
        private void CreateNewUserButton_MouseClick(object sender, MouseEventArgs e)
        {
            personCreated = new Person(FirstNameEntry.Text, LastNameEntry.Text, "", null);
            if (!DBUserInterface.Instance.VerifyExistence(personCreated))
            {
                Step2GroupBox.Visible = true;
            }
            else
            {
                MessageBox.Show("This user already exists");
            }
        }
        private void savePasswordButton_MouseClick(object sender, MouseEventArgs e)
        {
            personCreated.SavePassword(EnterPasswordMaskedText.Text);
            Step3GroupBox.Visible = true;
        }
        private void UserGroupSelectSubmit_Click(object sender, EventArgs e)
        {
            HashSet<PersonGroup> groups = new HashSet<PersonGroup>();
            for (int i = 0; i < ListSelectUserGroup.Items.Count; i++) {
                if (ListSelectUserGroup.GetItemChecked(i)) {
                    groups.Add((PersonGroup) ListSelectUserGroup.Items[i]);
                }
            }
            personCreated.SavePersonGroups(groups);

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
            personCreated.SaveInfo();
            UpdateSources();
            MessageBox.Show("New User Successfully Created. Card is Printing.");
            ResetButton_Click(sender, e);
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            Step2GroupBox.Visible = Step3GroupBox.Visible = Step4GroupBox.Visible = false;
            FirstNameEntry.Text = "First Name";
            LastNameEntry.Text = "Last Name";
            EnterPasswordMaskedText.Text = "";
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
            {
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
                        ts[i].RevokeAccess();
                    }
                }
                dayOfWeek.TimeSlots = ts;
                week.setTypicalDay(dayOfWeek, i);
            }
            cal.TypicalWeek = week;
            dac.SaveCalendar(usergroup, doorgroup, cal);
            MessageBox.Show("Calendar Week Successfully Saved");
        }

        /*******************
         * Door Groups Tab *
         * *****************/
        

        private void ExistDoorGroupsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            DoorGroup selected = (DoorGroup)ExistDoorGroupsList.SelectedItem;
            List<Door> doors = dac.FindDoorsByGroup(selected);
            DoorMembersListBox.DataSource = doors;

            for (int i = 0; i < ExistingDoorsList.Items.Count; i++) {
                ExistingDoorsList.SetItemChecked(i, doors.Contains(ExistingDoorsList.Items[i]));
            } 
        }

        private void EditDoorGroupButton_Click(object sender, EventArgs e)
        {
            EditDoorGroupBox.Visible = true;
            NameOfDoorGroupNameTextbox.Text = ExistDoorGroupsList.SelectedItem.ToString();
        }

        private void SaveEditedDoorGroupButton_Click(object sender, EventArgs e)
        {
            DoorGroup selected = (DoorGroup)ExistDoorGroupsList.SelectedItem;
            selected.Code = NameOfDoorGroupNameTextbox.Text;
            for (int i = 0; i < ExistingDoorsList.Items.Count; i++) {
                Door curDoor = (Door)ExistingDoorsList.Items[i];
                if (ExistingDoorsList.GetItemChecked(i)) {
                    curDoor.DoorGroup = selected;
                } else if (curDoor.DoorGroup != null && curDoor.DoorGroup.Equals(selected)) {
                    curDoor.DoorGroup = null;
                }
            }
            UpdateSources();
            EditDoorGroupBox.Visible = false;
        }

        private void CreateNewDoorGroupButton_Click(object sender, EventArgs e)
        {
            EditDoorGroupBox.Visible = true;
            DoorGroup newGroup = new DoorGroup("New Group", "");
            dac.DoorGroups.Add(newGroup);
            UpdateSources();
            DoorMembersListBox.DataSource = dac.FindDoorsByGroup(newGroup);
            ExistDoorGroupsList.SelectedIndex = dac.DoorGroups.IndexOf(newGroup);
        }
        
        /********************
         * User Groups Tab *
         * *****************/

        private void CreateUserButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;

        }
        private void ExistingUserGroupsListBox_SelectedIndexChanged(object sender, EventArgs e) {
            PersonGroup selected = (PersonGroup)ExistingUserGroupsListBox.SelectedItem;
            List<Person> list = dac.FindPeopleByGroup(selected);
            UserMembersListBox.DataSource = list;

            for (int i = 0; i < ExistingUserListBox.Items.Count; i++) {
                ExistingUserListBox.SetItemChecked(i, list.Contains(ExistingUserListBox.Items[i]));
            }
        }
        private void EditUserGroupButton_Click(object sender, EventArgs e)
        {
            EditUserGroupBox.Visible = true;
            NameOfUserGroupTextbox.Text = ExistingUserGroupsListBox.SelectedItem.ToString();
        }
        private void SaveUserGroupButton_Click(object sender, EventArgs e)
        {
            PersonGroup selected = (PersonGroup)ExistingUserGroupsListBox.SelectedItem;
            for (int i = 0; i < ExistingUserListBox.Items.Count; i++) {
                Person curPerson = (Person) ExistingUserListBox.Items[i];
                HashSet<PersonGroup> groups = curPerson.FindPersonGroups();
                if (ExistingUserListBox.GetItemChecked(i)) {
                    groups.Add(selected);
                } else {
                    groups.Remove(selected);
                }
                curPerson.SavePersonGroups(groups);
            }
            selected.Code = NameOfUserGroupTextbox.Text;
            UpdateSources();
            EditUserGroupBox.Visible = false;
        }

        private void CreateNewUserGroupButton_Click(object sender, EventArgs e)
        {
            EditUserGroupBox.Visible = true;
            PersonGroup newGroup = new PersonGroup("New Group", "");
            dac.PersonGroups.Add(newGroup);
            UpdateSources();
            UserMembersListBox.DataSource = dac.FindPeopleByGroup(newGroup);
            ExistingUserGroupsListBox.SelectedIndex = dac.PersonGroups.IndexOf(newGroup);
        }

        private void CardReaderListBox_SelectedIndexChanged(object sender, EventArgs e) {
            UpdateCardReaderInfo();
        }

        private void UpdateCardReaderInfo() {
            CardReader cr = CardReaderInstallation.Instance.GetCardReader((string)CardReaderListBox.SelectedItem);
            ReaderNameLabel.Text = cr.getName();
            ReaderStatusLabel.Text = cr.IsActive() ? "Active" : "Inactive";
            ReaderNetworkAddressLabel.Text = cr.GetNetWorkAddress();
            ReaderDoorLocationLabel.Text = cr.GetDoor().ToString();
            ReaderAlarmTimeOut.Text = cr.AlarmTimeOut + " ms";
            ReaderUnlockedTimeOut.Text = cr.TimeKeeperTimeOut + " ms";
        }

        private void EditReaderButton_Click(object sender, EventArgs e) {
            CardReader cr = CardReaderInstallation.Instance.GetCardReader((string)CardReaderListBox.SelectedItem);
            EditCardReaderGroupBox.Visible = true;
            AlarmTimeoutTextbox.Text = cr.AlarmTimeOut + "";
            UnlockTimeoutTextbox.Text = cr.TimeKeeperTimeOut + "";
        }

        private void SaveCardReaderButton_Click(object sender, EventArgs e) {
            CardReader cr = CardReaderInstallation.Instance.GetCardReader((string)CardReaderListBox.SelectedItem);
            try {
                cr.AlarmTimeOut = Double.Parse(AlarmTimeoutTextbox.Text);
                cr.TimeKeeperTimeOut = Double.Parse(UnlockTimeoutTextbox.Text);
                UpdateCardReaderInfo();
                EditCardReaderGroupBox.Visible = false;
            } catch (FormatException ex) {
                MessageBox.Show("Invalid number entered");
            }
            
        }

    }
}
