namespace ReganRyanSoftwareEngineering
{
    partial class CardReaderPanel
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
            this.label1 = new System.Windows.Forms.Label();
            this.ReaderNameLabel = new System.Windows.Forms.Label();
            this.CardNumberTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SwipeButton = new System.Windows.Forms.Button();
            this.EnterCardNumBox = new System.Windows.Forms.GroupBox();
            this.EnterPasswordBox = new System.Windows.Forms.GroupBox();
            this.SubmitPasswordButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.EnterPasswordTextBox = new System.Windows.Forms.MaskedTextBox();
            this.OpenDoorBox = new System.Windows.Forms.GroupBox();
            this.DoorToggleButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DateTimeLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.EnterCardNumBox.SuspendLayout();
            this.EnterPasswordBox.SuspendLayout();
            this.OpenDoorBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Card Reader:";
            // 
            // ReaderNameLabel
            // 
            this.ReaderNameLabel.AutoSize = true;
            this.ReaderNameLabel.Location = new System.Drawing.Point(89, 0);
            this.ReaderNameLabel.Name = "ReaderNameLabel";
            this.ReaderNameLabel.Size = new System.Drawing.Size(35, 13);
            this.ReaderNameLabel.TabIndex = 1;
            this.ReaderNameLabel.Text = "Name";
            // 
            // CardNumberTextBox
            // 
            this.CardNumberTextBox.Location = new System.Drawing.Point(39, 32);
            this.CardNumberTextBox.Name = "CardNumberTextBox";
            this.CardNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.CardNumberTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter Card Number";
            // 
            // SwipeButton
            // 
            this.SwipeButton.Location = new System.Drawing.Point(45, 58);
            this.SwipeButton.Name = "SwipeButton";
            this.SwipeButton.Size = new System.Drawing.Size(75, 23);
            this.SwipeButton.TabIndex = 4;
            this.SwipeButton.Text = "SWIPE";
            this.SwipeButton.UseVisualStyleBackColor = true;
            this.SwipeButton.Click += new System.EventHandler(this.SwipeButton_Click);
            // 
            // EnterCardNumBox
            // 
            this.EnterCardNumBox.Controls.Add(this.SwipeButton);
            this.EnterCardNumBox.Controls.Add(this.label2);
            this.EnterCardNumBox.Controls.Add(this.CardNumberTextBox);
            this.EnterCardNumBox.Location = new System.Drawing.Point(27, 59);
            this.EnterCardNumBox.Name = "EnterCardNumBox";
            this.EnterCardNumBox.Size = new System.Drawing.Size(200, 100);
            this.EnterCardNumBox.TabIndex = 5;
            this.EnterCardNumBox.TabStop = false;
            // 
            // EnterPasswordBox
            // 
            this.EnterPasswordBox.Controls.Add(this.SubmitPasswordButton);
            this.EnterPasswordBox.Controls.Add(this.label3);
            this.EnterPasswordBox.Controls.Add(this.EnterPasswordTextBox);
            this.EnterPasswordBox.Location = new System.Drawing.Point(27, 166);
            this.EnterPasswordBox.Name = "EnterPasswordBox";
            this.EnterPasswordBox.Size = new System.Drawing.Size(200, 81);
            this.EnterPasswordBox.TabIndex = 6;
            this.EnterPasswordBox.TabStop = false;
            this.EnterPasswordBox.Visible = false;
            // 
            // SubmitPasswordButton
            // 
            this.SubmitPasswordButton.Location = new System.Drawing.Point(90, 41);
            this.SubmitPasswordButton.Name = "SubmitPasswordButton";
            this.SubmitPasswordButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitPasswordButton.TabIndex = 2;
            this.SubmitPasswordButton.Text = "Enter";
            this.SubmitPasswordButton.UseVisualStyleBackColor = true;
            this.SubmitPasswordButton.Click += new System.EventHandler(this.SubmitPasswordButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Enter Password";
            // 
            // EnterPasswordTextBox
            // 
            this.EnterPasswordTextBox.Location = new System.Drawing.Point(47, 41);
            this.EnterPasswordTextBox.Name = "EnterPasswordTextBox";
            this.EnterPasswordTextBox.PromptChar = ' ';
            this.EnterPasswordTextBox.Size = new System.Drawing.Size(36, 20);
            this.EnterPasswordTextBox.TabIndex = 0;
            this.EnterPasswordTextBox.UseSystemPasswordChar = true;
            this.EnterPasswordTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // OpenDoorBox
            // 
            this.OpenDoorBox.Controls.Add(this.DoorToggleButton);
            this.OpenDoorBox.Controls.Add(this.label4);
            this.OpenDoorBox.Location = new System.Drawing.Point(27, 254);
            this.OpenDoorBox.Name = "OpenDoorBox";
            this.OpenDoorBox.Size = new System.Drawing.Size(200, 100);
            this.OpenDoorBox.TabIndex = 7;
            this.OpenDoorBox.TabStop = false;
            this.OpenDoorBox.Visible = false;
            // 
            // DoorToggleButton
            // 
            this.DoorToggleButton.Location = new System.Drawing.Point(58, 63);
            this.DoorToggleButton.Name = "DoorToggleButton";
            this.DoorToggleButton.Size = new System.Drawing.Size(75, 23);
            this.DoorToggleButton.TabIndex = 1;
            this.DoorToggleButton.Text = "Open Door";
            this.DoorToggleButton.UseVisualStyleBackColor = true;
            this.DoorToggleButton.Click += new System.EventHandler(this.DoorToggleButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Door Unlocked!";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Date and Time:";
            // 
            // DateTimeLabel
            // 
            this.DateTimeLabel.AutoSize = true;
            this.DateTimeLabel.Location = new System.Drawing.Point(89, 20);
            this.DateTimeLabel.Name = "DateTimeLabel";
            this.DateTimeLabel.Size = new System.Drawing.Size(35, 13);
            this.DateTimeLabel.TabIndex = 9;
            this.DateTimeLabel.Text = "label6";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57F));
            this.tableLayoutPanel1.Controls.Add(this.DateTimeLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ReaderNameLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(27, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 41);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // CardReaderPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 388);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.OpenDoorBox);
            this.Controls.Add(this.EnterPasswordBox);
            this.Controls.Add(this.EnterCardNumBox);
            this.Name = "CardReaderPanel";
            this.Text = "CardReader";
            this.EnterCardNumBox.ResumeLayout(false);
            this.EnterCardNumBox.PerformLayout();
            this.EnterPasswordBox.ResumeLayout(false);
            this.EnterPasswordBox.PerformLayout();
            this.OpenDoorBox.ResumeLayout(false);
            this.OpenDoorBox.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ReaderNameLabel;
        private System.Windows.Forms.TextBox CardNumberTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SwipeButton;
        private System.Windows.Forms.GroupBox EnterCardNumBox;
        private System.Windows.Forms.GroupBox EnterPasswordBox;
        private System.Windows.Forms.Button SubmitPasswordButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox EnterPasswordTextBox;
        private System.Windows.Forms.GroupBox OpenDoorBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label DateTimeLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button DoorToggleButton;
    }
}