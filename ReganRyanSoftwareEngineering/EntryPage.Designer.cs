namespace ReganRyanSoftwareEngineering
{
    partial class EntryPage
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
            this.SelectMainFuncLabel = new System.Windows.Forms.Label();
            this.AdminConsoleButton = new System.Windows.Forms.Button();
            this.SecurityConsoleButton = new System.Windows.Forms.Button();
            this.CardReaderSelectorButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SelectMainFuncLabel
            // 
            this.SelectMainFuncLabel.AutoSize = true;
            this.SelectMainFuncLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectMainFuncLabel.Location = new System.Drawing.Point(163, 22);
            this.SelectMainFuncLabel.Name = "SelectMainFuncLabel";
            this.SelectMainFuncLabel.Size = new System.Drawing.Size(279, 26);
            this.SelectMainFuncLabel.TabIndex = 0;
            this.SelectMainFuncLabel.Text = "Select Main Functionality";
            // 
            // AdminConsoleButton
            // 
            this.AdminConsoleButton.Location = new System.Drawing.Point(70, 110);
            this.AdminConsoleButton.Name = "AdminConsoleButton";
            this.AdminConsoleButton.Size = new System.Drawing.Size(95, 23);
            this.AdminConsoleButton.TabIndex = 1;
            this.AdminConsoleButton.Text = "Admin Console";
            this.AdminConsoleButton.UseVisualStyleBackColor = true;
            this.AdminConsoleButton.Click += new System.EventHandler(this.AdminConsoleButton_Click);
            // 
            // SecurityConsoleButton
            // 
            this.SecurityConsoleButton.Location = new System.Drawing.Point(215, 110);
            this.SecurityConsoleButton.Name = "SecurityConsoleButton";
            this.SecurityConsoleButton.Size = new System.Drawing.Size(107, 23);
            this.SecurityConsoleButton.TabIndex = 2;
            this.SecurityConsoleButton.Text = "Security Console";
            this.SecurityConsoleButton.UseVisualStyleBackColor = true;
            this.SecurityConsoleButton.Click += new System.EventHandler(this.SecurityConsoleButton_Click);
            // 
            // CardReaderSelectorButton
            // 
            this.CardReaderSelectorButton.Location = new System.Drawing.Point(366, 110);
            this.CardReaderSelectorButton.Name = "CardReaderSelectorButton";
            this.CardReaderSelectorButton.Size = new System.Drawing.Size(122, 22);
            this.CardReaderSelectorButton.TabIndex = 3;
            this.CardReaderSelectorButton.Text = "Card Reader Selector";
            this.CardReaderSelectorButton.UseVisualStyleBackColor = true;
            this.CardReaderSelectorButton.Click += new System.EventHandler(this.CardReaderSelectorButton_Click);
            // 
            // EntryPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 440);
            this.Controls.Add(this.CardReaderSelectorButton);
            this.Controls.Add(this.SecurityConsoleButton);
            this.Controls.Add(this.AdminConsoleButton);
            this.Controls.Add(this.SelectMainFuncLabel);
            this.Name = "EntryPage";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SelectMainFuncLabel;
        private System.Windows.Forms.Button AdminConsoleButton;
        private System.Windows.Forms.Button SecurityConsoleButton;
        private System.Windows.Forms.Button CardReaderSelectorButton;
    }
}