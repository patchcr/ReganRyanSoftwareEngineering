namespace ReganRyanSoftwareEngineering {

    partial class SupervisorInterface {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.PageCardCreation = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ConfirmInfoPrintCard = new System.Windows.Forms.Button();
            this.PersonInfoDisplay = new System.Windows.Forms.Label();
            this.ListSelectUserGroup = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.UserGroupSelectSubmit = new System.Windows.Forms.Button();
            this.LastNameEntry = new System.Windows.Forms.TextBox();
            this.FirstNameEntry = new System.Windows.Forms.TextBox();
            this.CreateNewUserButton = new System.Windows.Forms.Button();
            this.PageUpdateCalendar = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ReactivateCardTextbox = new System.Windows.Forms.TextBox();
            this.ReactivateCardButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.EnterPasswordMaskedText = new System.Windows.Forms.MaskedTextBox();
            this.savePasswordButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tabControl1.SuspendLayout();
            this.PageCardCreation.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(344, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Supervisor Interface";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.PageCardCreation);
            this.tabControl1.Controls.Add(this.PageUpdateCalendar);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl1.Location = new System.Drawing.Point(0, 42);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(936, 723);
            this.tabControl1.TabIndex = 1;
            // 
            // PageCardCreation
            // 
            this.PageCardCreation.Controls.Add(this.groupBox4);
            this.PageCardCreation.Controls.Add(this.groupBox3);
            this.PageCardCreation.Controls.Add(this.groupBox2);
            this.PageCardCreation.Controls.Add(this.groupBox1);
            this.PageCardCreation.Location = new System.Drawing.Point(4, 22);
            this.PageCardCreation.Name = "PageCardCreation";
            this.PageCardCreation.Padding = new System.Windows.Forms.Padding(3);
            this.PageCardCreation.Size = new System.Drawing.Size(928, 697);
            this.PageCardCreation.TabIndex = 0;
            this.PageCardCreation.Text = "New User Creation";
            this.PageCardCreation.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.richTextBox1);
            this.groupBox2.Controls.Add(this.ConfirmInfoPrintCard);
            this.groupBox2.Controls.Add(this.PersonInfoDisplay);
            this.groupBox2.Location = new System.Drawing.Point(640, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 148);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Step 4. Confirmation";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // ConfirmInfoPrintCard
            // 
            this.ConfirmInfoPrintCard.Location = new System.Drawing.Point(10, 119);
            this.ConfirmInfoPrintCard.Name = "ConfirmInfoPrintCard";
            this.ConfirmInfoPrintCard.Size = new System.Drawing.Size(99, 23);
            this.ConfirmInfoPrintCard.TabIndex = 1;
            this.ConfirmInfoPrintCard.Text = "Confirm and Print";
            this.ConfirmInfoPrintCard.UseVisualStyleBackColor = true;
            // 
            // PersonInfoDisplay
            // 
            this.PersonInfoDisplay.AutoSize = true;
            this.PersonInfoDisplay.Location = new System.Drawing.Point(6, 24);
            this.PersonInfoDisplay.Name = "PersonInfoDisplay";
            this.PersonInfoDisplay.Size = new System.Drawing.Size(75, 13);
            this.PersonInfoDisplay.TabIndex = 0;
            this.PersonInfoDisplay.Text = "Combined Info";
            this.PersonInfoDisplay.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // ListSelectUserGroup
            // 
            this.ListSelectUserGroup.FormattingEnabled = true;
            this.ListSelectUserGroup.Location = new System.Drawing.Point(8, 19);
            this.ListSelectUserGroup.Name = "ListSelectUserGroup";
            this.ListSelectUserGroup.Size = new System.Drawing.Size(120, 95);
            this.ListSelectUserGroup.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.UserGroupSelectSubmit);
            this.groupBox1.Controls.Add(this.ListSelectUserGroup);
            this.groupBox1.Location = new System.Drawing.Point(402, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 148);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Step 3 Select Groups";
            // 
            // UserGroupSelectSubmit
            // 
            this.UserGroupSelectSubmit.Location = new System.Drawing.Point(134, 19);
            this.UserGroupSelectSubmit.Name = "UserGroupSelectSubmit";
            this.UserGroupSelectSubmit.Size = new System.Drawing.Size(75, 23);
            this.UserGroupSelectSubmit.TabIndex = 1;
            this.UserGroupSelectSubmit.Text = "Submit";
            this.UserGroupSelectSubmit.UseVisualStyleBackColor = true;
            // 
            // LastNameEntry
            // 
            this.LastNameEntry.Location = new System.Drawing.Point(6, 60);
            this.LastNameEntry.Name = "LastNameEntry";
            this.LastNameEntry.Size = new System.Drawing.Size(100, 20);
            this.LastNameEntry.TabIndex = 2;
            this.LastNameEntry.Text = "Last Name";
            // 
            // FirstNameEntry
            // 
            this.FirstNameEntry.Location = new System.Drawing.Point(6, 34);
            this.FirstNameEntry.Name = "FirstNameEntry";
            this.FirstNameEntry.Size = new System.Drawing.Size(100, 20);
            this.FirstNameEntry.TabIndex = 1;
            this.FirstNameEntry.Text = "First Name";
            // 
            // CreateNewUserButton
            // 
            this.CreateNewUserButton.Location = new System.Drawing.Point(6, 86);
            this.CreateNewUserButton.Name = "CreateNewUserButton";
            this.CreateNewUserButton.Size = new System.Drawing.Size(109, 23);
            this.CreateNewUserButton.TabIndex = 0;
            this.CreateNewUserButton.Text = "Create New User";
            this.CreateNewUserButton.UseVisualStyleBackColor = true;
            // 
            // PageUpdateCalendar
            // 
            this.PageUpdateCalendar.Location = new System.Drawing.Point(4, 22);
            this.PageUpdateCalendar.Name = "PageUpdateCalendar";
            this.PageUpdateCalendar.Padding = new System.Windows.Forms.Padding(3);
            this.PageUpdateCalendar.Size = new System.Drawing.Size(928, 697);
            this.PageUpdateCalendar.TabIndex = 1;
            this.PageUpdateCalendar.Text = "Update Calendar";
            this.PageUpdateCalendar.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ReactivateCardTextbox);
            this.tabPage1.Controls.Add(this.ReactivateCardButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(928, 697);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Misc";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ReactivateCardTextbox
            // 
            this.ReactivateCardTextbox.Location = new System.Drawing.Point(26, 36);
            this.ReactivateCardTextbox.Name = "ReactivateCardTextbox";
            this.ReactivateCardTextbox.Size = new System.Drawing.Size(100, 20);
            this.ReactivateCardTextbox.TabIndex = 3;
            this.ReactivateCardTextbox.Text = "Card #";
            // 
            // ReactivateCardButton
            // 
            this.ReactivateCardButton.AutoEllipsis = true;
            this.ReactivateCardButton.Location = new System.Drawing.Point(141, 36);
            this.ReactivateCardButton.Name = "ReactivateCardButton";
            this.ReactivateCardButton.Size = new System.Drawing.Size(101, 23);
            this.ReactivateCardButton.TabIndex = 2;
            this.ReactivateCardButton.Text = "Reactivate Card";
            this.ReactivateCardButton.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.savePasswordButton);
            this.groupBox3.Controls.Add(this.EnterPasswordMaskedText);
            this.groupBox3.Location = new System.Drawing.Point(182, 37);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 148);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Step 2. Select Password";
            // 
            // EnterPasswordMaskedText
            // 
            this.EnterPasswordMaskedText.Location = new System.Drawing.Point(7, 42);
            this.EnterPasswordMaskedText.Mask = "0000";
            this.EnterPasswordMaskedText.Name = "EnterPasswordMaskedText";
            this.EnterPasswordMaskedText.Size = new System.Drawing.Size(30, 20);
            this.EnterPasswordMaskedText.TabIndex = 1;
            // 
            // savePasswordButton
            // 
            this.savePasswordButton.Location = new System.Drawing.Point(44, 42);
            this.savePasswordButton.Name = "savePasswordButton";
            this.savePasswordButton.Size = new System.Drawing.Size(100, 23);
            this.savePasswordButton.TabIndex = 2;
            this.savePasswordButton.Text = "Save Password";
            this.savePasswordButton.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(10, 40);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(151, 73);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "Display combined information from the Person so far. Includes Name, ID#, CardID#," +
                " Groups, and existence of a password.";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.FirstNameEntry);
            this.groupBox4.Controls.Add(this.CreateNewUserButton);
            this.groupBox4.Controls.Add(this.LastNameEntry);
            this.groupBox4.Location = new System.Drawing.Point(8, 37);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(168, 148);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Step 1. Create New User";
            // 
            // SupervisorInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 762);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "SupervisorInterface";
            this.Text = "SupervisorInterface";
            this.Load += new System.EventHandler(this.SupervisorInterface_Load);
            this.tabControl1.ResumeLayout(false);
            this.PageCardCreation.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage PageCardCreation;
        private System.Windows.Forms.TabPage PageUpdateCalendar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox LastNameEntry;
        private System.Windows.Forms.TextBox FirstNameEntry;
        private System.Windows.Forms.Button CreateNewUserButton;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox ReactivateCardTextbox;
        private System.Windows.Forms.Button ReactivateCardButton;
        private System.Windows.Forms.ListBox ListSelectUserGroup;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ConfirmInfoPrintCard;
        private System.Windows.Forms.Label PersonInfoDisplay;
        private System.Windows.Forms.Button UserGroupSelectSubmit;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button savePasswordButton;
        private System.Windows.Forms.MaskedTextBox EnterPasswordMaskedText;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox4;
    }

}


