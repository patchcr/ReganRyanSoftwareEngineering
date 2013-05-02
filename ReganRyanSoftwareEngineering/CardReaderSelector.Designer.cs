namespace ReganRyanSoftwareEngineering
{
    partial class CardReaderSelector
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CardReaderListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PickDateCalendar = new System.Windows.Forms.MonthCalendar();
            this.TimePicker = new System.Windows.Forms.DateTimePicker();
            this.LaunchCardReader = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ReaderNameLabel = new System.Windows.Forms.Label();
            this.ReaderStatusLabel = new System.Windows.Forms.Label();
            this.ReaderNetworkAddressLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ReaderDoorLocationLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CardReaderListBox
            // 
            this.CardReaderListBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.CardReaderListBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CardReaderListBox.FormattingEnabled = true;
            this.CardReaderListBox.Location = new System.Drawing.Point(33, 55);
            this.CardReaderListBox.Name = "CardReaderListBox";
            this.CardReaderListBox.Size = new System.Drawing.Size(66, 368);
            this.CardReaderListBox.TabIndex = 0;
            this.CardReaderListBox.SelectedIndexChanged += new System.EventHandler(this.CardReaderListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Card Reader";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(364, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Pick Date/Time";
            // 
            // PickDateCalendar
            // 
            this.PickDateCalendar.Location = new System.Drawing.Point(367, 55);
            this.PickDateCalendar.Name = "PickDateCalendar";
            this.PickDateCalendar.ShowToday = false;
            this.PickDateCalendar.ShowWeekNumbers = true;
            this.PickDateCalendar.TabIndex = 10;
            this.PickDateCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.PickDateCalendar_DateChanged);
            // 
            // TimePicker
            // 
            this.TimePicker.CustomFormat = "hh:mm tt";
            this.TimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TimePicker.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TimePicker.Location = new System.Drawing.Point(367, 230);
            this.TimePicker.Name = "TimePicker";
            this.TimePicker.ShowUpDown = true;
            this.TimePicker.Size = new System.Drawing.Size(70, 20);
            this.TimePicker.TabIndex = 11;
            this.TimePicker.ValueChanged += new System.EventHandler(this.TimePicker_ValueChanged);
            // 
            // LaunchCardReader
            // 
            this.LaunchCardReader.Location = new System.Drawing.Point(367, 267);
            this.LaunchCardReader.Name = "LaunchCardReader";
            this.LaunchCardReader.Size = new System.Drawing.Size(114, 23);
            this.LaunchCardReader.TabIndex = 12;
            this.LaunchCardReader.Text = "Launch Card Reader";
            this.LaunchCardReader.UseVisualStyleBackColor = true;
            this.LaunchCardReader.Click += new System.EventHandler(this.LaunchCardReader_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.36364F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.63636F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ReaderNameLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ReaderStatusLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ReaderNetworkAddressLabel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.ReaderDoorLocationLabel, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(127, 55);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(176, 78);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Card Reader Name:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(65, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Status:";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Network Address:";
            // 
            // ReaderNameLabel
            // 
            this.ReaderNameLabel.AutoSize = true;
            this.ReaderNameLabel.Location = new System.Drawing.Point(111, 0);
            this.ReaderNameLabel.Name = "ReaderNameLabel";
            this.ReaderNameLabel.Size = new System.Drawing.Size(35, 13);
            this.ReaderNameLabel.TabIndex = 3;
            this.ReaderNameLabel.Text = "label7";
            // 
            // ReaderStatusLabel
            // 
            this.ReaderStatusLabel.AutoSize = true;
            this.ReaderStatusLabel.Location = new System.Drawing.Point(111, 19);
            this.ReaderStatusLabel.Name = "ReaderStatusLabel";
            this.ReaderStatusLabel.Size = new System.Drawing.Size(35, 13);
            this.ReaderStatusLabel.TabIndex = 4;
            this.ReaderStatusLabel.Text = "label8";
            // 
            // ReaderNetworkAddressLabel
            // 
            this.ReaderNetworkAddressLabel.AutoSize = true;
            this.ReaderNetworkAddressLabel.Location = new System.Drawing.Point(111, 38);
            this.ReaderNetworkAddressLabel.Name = "ReaderNetworkAddressLabel";
            this.ReaderNetworkAddressLabel.Size = new System.Drawing.Size(35, 13);
            this.ReaderNetworkAddressLabel.TabIndex = 5;
            this.ReaderNetworkAddressLabel.Text = "label9";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Door Location:";
            // 
            // ReaderDoorLocationLabel
            // 
            this.ReaderDoorLocationLabel.AutoSize = true;
            this.ReaderDoorLocationLabel.Location = new System.Drawing.Point(111, 58);
            this.ReaderDoorLocationLabel.Name = "ReaderDoorLocationLabel";
            this.ReaderDoorLocationLabel.Size = new System.Drawing.Size(35, 13);
            this.ReaderDoorLocationLabel.TabIndex = 7;
            this.ReaderDoorLocationLabel.Text = "label7";
            // 
            // CardReaderSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 526);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.LaunchCardReader);
            this.Controls.Add(this.TimePicker);
            this.Controls.Add(this.PickDateCalendar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CardReaderListBox);
            this.Name = "CardReaderSelector";
            this.Text = "CardReaderSelector";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox CardReaderListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MonthCalendar PickDateCalendar;
        private System.Windows.Forms.DateTimePicker TimePicker;
        private System.Windows.Forms.Button LaunchCardReader;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label ReaderNameLabel;
        private System.Windows.Forms.Label ReaderStatusLabel;
        private System.Windows.Forms.Label ReaderNetworkAddressLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label ReaderDoorLocationLabel;
    }
}