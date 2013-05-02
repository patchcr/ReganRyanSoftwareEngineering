namespace ReganRyanSoftwareEngineering
{
    partial class SecurityConsoleInterface
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.CardReaderSelectionList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ReaderNameLabel = new System.Windows.Forms.Label();
            this.ReaderStatusLabel = new System.Windows.Forms.Label();
            this.ReaderNetworkAddressLabel = new System.Windows.Forms.Label();
            this.ReactivateCardReaderButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ReaderDoorLocationLabel = new System.Windows.Forms.Label();
            this.personGroupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EventListBox = new System.Windows.Forms.ListBox();
            this.EventDisplayMultilineTextbox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personGroupBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Security Console";
            // 
            // CardReaderSelectionList
            // 
            this.CardReaderSelectionList.FormattingEnabled = true;
            this.CardReaderSelectionList.Location = new System.Drawing.Point(9, 19);
            this.CardReaderSelectionList.Name = "CardReaderSelectionList";
            this.CardReaderSelectionList.Size = new System.Drawing.Size(120, 121);
            this.CardReaderSelectionList.TabIndex = 2;
            this.CardReaderSelectionList.SelectedIndexChanged += new System.EventHandler(this.CardReaderSelectionList_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(186, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Notifications";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.36364F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.63636F));
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ReaderNameLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ReaderStatusLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ReaderNetworkAddressLabel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.ReaderDoorLocationLabel, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(144, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(176, 78);
            this.tableLayoutPanel1.TabIndex = 6;
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
            this.label5.Location = new System.Drawing.Point(65, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Status:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Network Address:";
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
            // ReactivateCardReaderButton
            // 
            this.ReactivateCardReaderButton.AutoEllipsis = true;
            this.ReactivateCardReaderButton.Location = new System.Drawing.Point(144, 117);
            this.ReactivateCardReaderButton.Name = "ReactivateCardReaderButton";
            this.ReactivateCardReaderButton.Size = new System.Drawing.Size(142, 23);
            this.ReactivateCardReaderButton.TabIndex = 7;
            this.ReactivateCardReaderButton.Text = "Reactivate Card Reader";
            this.ReactivateCardReaderButton.UseVisualStyleBackColor = true;
            this.ReactivateCardReaderButton.Click += new System.EventHandler(this.ReactivateCardReaderButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Controls.Add(this.ReactivateCardReaderButton);
            this.groupBox1.Controls.Add(this.CardReaderSelectionList);
            this.groupBox1.Location = new System.Drawing.Point(65, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 146);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Active Card Readers";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Door Location:";
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
            // personGroupBindingSource
            // 
            this.personGroupBindingSource.DataSource = typeof(ReganRyanSoftwareEngineering.PersonGroup);
            // 
            // EventListBox
            // 
            this.EventListBox.FormattingEnabled = true;
            this.EventListBox.Location = new System.Drawing.Point(65, 313);
            this.EventListBox.Name = "EventListBox";
            this.EventListBox.Size = new System.Drawing.Size(286, 121);
            this.EventListBox.TabIndex = 10;
            // 
            // EventDisplayMultilineTextbox
            // 
            this.EventDisplayMultilineTextbox.Location = new System.Drawing.Point(367, 313);
            this.EventDisplayMultilineTextbox.Multiline = true;
            this.EventDisplayMultilineTextbox.Name = "EventDisplayMultilineTextbox";
            this.EventDisplayMultilineTextbox.Size = new System.Drawing.Size(100, 121);
            this.EventDisplayMultilineTextbox.TabIndex = 11;
            // 
            // SecurityConsoleInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 477);
            this.Controls.Add(this.EventDisplayMultilineTextbox);
            this.Controls.Add(this.EventListBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SecurityConsoleInterface";
            this.Text = "SecurityConsoleInterface";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.personGroupBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox CardReaderSelectionList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label ReaderNameLabel;
        private System.Windows.Forms.Label ReaderStatusLabel;
        private System.Windows.Forms.Label ReaderNetworkAddressLabel;
        private System.Windows.Forms.Button ReactivateCardReaderButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource personGroupBindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ReaderDoorLocationLabel;
        private System.Windows.Forms.ListBox EventListBox;
        private System.Windows.Forms.TextBox EventDisplayMultilineTextbox;
    }
}