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
            this.TableCardReaderInfo = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ReaderNameLabel = new System.Windows.Forms.Label();
            this.ReaderStatusLabel = new System.Windows.Forms.Label();
            this.ReaderNumEventsLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PickDateCalendar = new System.Windows.Forms.MonthCalendar();
            this.TimePicker = new System.Windows.Forms.DateTimePicker();
            this.LaunchCardReader = new System.Windows.Forms.Button();
            this.TableCardReaderInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // CardReaderListBox
            // 
            this.CardReaderListBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.CardReaderListBox.FormattingEnabled = true;
            this.CardReaderListBox.Location = new System.Drawing.Point(33, 55);
            this.CardReaderListBox.Name = "CardReaderListBox";
            this.CardReaderListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.CardReaderListBox.Size = new System.Drawing.Size(66, 368);
            this.CardReaderListBox.TabIndex = 0;
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
            // TableCardReaderInfo
            // 
            this.TableCardReaderInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TableCardReaderInfo.ColumnCount = 2;
            this.TableCardReaderInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.36364F));
            this.TableCardReaderInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.63636F));
            this.TableCardReaderInfo.Controls.Add(this.label4, 0, 0);
            this.TableCardReaderInfo.Controls.Add(this.label5, 0, 1);
            this.TableCardReaderInfo.Controls.Add(this.label6, 0, 2);
            this.TableCardReaderInfo.Controls.Add(this.ReaderNameLabel, 1, 0);
            this.TableCardReaderInfo.Controls.Add(this.ReaderStatusLabel, 1, 1);
            this.TableCardReaderInfo.Controls.Add(this.ReaderNumEventsLabel, 1, 2);
            this.TableCardReaderInfo.Location = new System.Drawing.Point(122, 55);
            this.TableCardReaderInfo.Name = "TableCardReaderInfo";
            this.TableCardReaderInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TableCardReaderInfo.RowCount = 3;
            this.TableCardReaderInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableCardReaderInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableCardReaderInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableCardReaderInfo.Size = new System.Drawing.Size(176, 46);
            this.TableCardReaderInfo.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Card Reader Name:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Status:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "# of Events:";
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
            this.ReaderStatusLabel.Location = new System.Drawing.Point(111, 13);
            this.ReaderStatusLabel.Name = "ReaderStatusLabel";
            this.ReaderStatusLabel.Size = new System.Drawing.Size(35, 13);
            this.ReaderStatusLabel.TabIndex = 4;
            this.ReaderStatusLabel.Text = "label8";
            // 
            // ReaderNumEventsLabel
            // 
            this.ReaderNumEventsLabel.AutoSize = true;
            this.ReaderNumEventsLabel.Location = new System.Drawing.Point(111, 26);
            this.ReaderNumEventsLabel.Name = "ReaderNumEventsLabel";
            this.ReaderNumEventsLabel.Size = new System.Drawing.Size(35, 13);
            this.ReaderNumEventsLabel.TabIndex = 5;
            this.ReaderNumEventsLabel.Text = "label9";
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
            // 
            // TimePicker
            // 
            this.TimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimePicker.Location = new System.Drawing.Point(367, 230);
            this.TimePicker.Name = "TimePicker";
            this.TimePicker.Size = new System.Drawing.Size(107, 20);
            this.TimePicker.TabIndex = 11;
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
            // CardReaderSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 526);
            this.Controls.Add(this.LaunchCardReader);
            this.Controls.Add(this.TimePicker);
            this.Controls.Add(this.PickDateCalendar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TableCardReaderInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CardReaderListBox);
            this.Name = "CardReaderSelector";
            this.Text = "CardReaderSelector";
            this.TableCardReaderInfo.ResumeLayout(false);
            this.TableCardReaderInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox CardReaderListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel TableCardReaderInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label ReaderNameLabel;
        private System.Windows.Forms.Label ReaderStatusLabel;
        private System.Windows.Forms.Label ReaderNumEventsLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MonthCalendar PickDateCalendar;
        private System.Windows.Forms.DateTimePicker TimePicker;
        private System.Windows.Forms.Button LaunchCardReader;
    }
}