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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SubmitPasswordButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.EnterPasswordTextBox = new System.Windows.Forms.MaskedTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Card Reader";
            // 
            // ReaderNameLabel
            // 
            this.ReaderNameLabel.AutoSize = true;
            this.ReaderNameLabel.Location = new System.Drawing.Point(118, 22);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SwipeButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.CardNumberTextBox);
            this.groupBox1.Location = new System.Drawing.Point(27, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SubmitPasswordButton);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.EnterPasswordTextBox);
            this.groupBox2.Location = new System.Drawing.Point(27, 166);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 81);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Visible = false;
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
            this.EnterPasswordTextBox.Mask = "0000";
            this.EnterPasswordTextBox.Name = "EnterPasswordTextBox";
            this.EnterPasswordTextBox.PromptChar = ' ';
            this.EnterPasswordTextBox.Size = new System.Drawing.Size(36, 20);
            this.EnterPasswordTextBox.TabIndex = 0;
            this.EnterPasswordTextBox.UseSystemPasswordChar = true;
            this.EnterPasswordTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(27, 254);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Visible = false;
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
            // CardReaderPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 388);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ReaderNameLabel);
            this.Controls.Add(this.label1);
            this.Name = "CardReaderPanel";
            this.Text = "CardReader";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ReaderNameLabel;
        private System.Windows.Forms.TextBox CardNumberTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SwipeButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button SubmitPasswordButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox EnterPasswordTextBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
    }
}