namespace Assignment11_Stroop
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.entryTab = new System.Windows.Forms.TabPage();
            this.exitBtn = new System.Windows.Forms.Button();
            this.enterBtn = new System.Windows.Forms.Button();
            this.phoneNumTxt = new System.Windows.Forms.MaskedTextBox();
            this.birthDayTxt = new System.Windows.Forms.TextBox();
            this.birthMonthTxt = new System.Windows.Forms.TextBox();
            this.lastNameTxt = new System.Windows.Forms.TextBox();
            this.firstNameTxt = new System.Windows.Forms.TextBox();
            this.birthDayLbl = new System.Windows.Forms.Label();
            this.birthMonthLbl = new System.Windows.Forms.Label();
            this.phoneNumberLbl = new System.Windows.Forms.Label();
            this.lastNameLbl = new System.Windows.Forms.Label();
            this.firstNameLbl = new System.Windows.Forms.Label();
            this.readTab = new System.Windows.Forms.TabPage();
            this.exitBtn2 = new System.Windows.Forms.Button();
            this.readBtn = new System.Windows.Forms.Button();
            this.readListBox = new System.Windows.Forms.ListBox();
            this.reminderTab = new System.Windows.Forms.TabPage();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.exitBtn3 = new System.Windows.Forms.Button();
            this.reminderBtn = new System.Windows.Forms.Button();
            this.reminderListBox = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.entryTab.SuspendLayout();
            this.readTab.SuspendLayout();
            this.reminderTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.entryTab);
            this.tabControl1.Controls.Add(this.readTab);
            this.tabControl1.Controls.Add(this.reminderTab);
            this.tabControl1.Location = new System.Drawing.Point(7, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(490, 307);
            this.tabControl1.TabIndex = 0;
            // 
            // entryTab
            // 
            this.entryTab.Controls.Add(this.exitBtn);
            this.entryTab.Controls.Add(this.enterBtn);
            this.entryTab.Controls.Add(this.phoneNumTxt);
            this.entryTab.Controls.Add(this.birthDayTxt);
            this.entryTab.Controls.Add(this.birthMonthTxt);
            this.entryTab.Controls.Add(this.lastNameTxt);
            this.entryTab.Controls.Add(this.firstNameTxt);
            this.entryTab.Controls.Add(this.birthDayLbl);
            this.entryTab.Controls.Add(this.birthMonthLbl);
            this.entryTab.Controls.Add(this.phoneNumberLbl);
            this.entryTab.Controls.Add(this.lastNameLbl);
            this.entryTab.Controls.Add(this.firstNameLbl);
            this.entryTab.Location = new System.Drawing.Point(4, 22);
            this.entryTab.Name = "entryTab";
            this.entryTab.Padding = new System.Windows.Forms.Padding(3);
            this.entryTab.Size = new System.Drawing.Size(482, 281);
            this.entryTab.TabIndex = 0;
            this.entryTab.Text = "Entry";
            this.entryTab.UseVisualStyleBackColor = true;
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(196, 203);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(100, 23);
            this.exitBtn.TabIndex = 11;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            // 
            // enterBtn
            // 
            this.enterBtn.Location = new System.Drawing.Point(24, 203);
            this.enterBtn.Name = "enterBtn";
            this.enterBtn.Size = new System.Drawing.Size(100, 23);
            this.enterBtn.TabIndex = 10;
            this.enterBtn.Text = "Enter Friend";
            this.enterBtn.UseVisualStyleBackColor = true;
            this.enterBtn.Click += new System.EventHandler(this.enterBtn_Click);
            // 
            // phoneNumTxt
            // 
            this.phoneNumTxt.Location = new System.Drawing.Point(196, 88);
            this.phoneNumTxt.Name = "phoneNumTxt";
            this.phoneNumTxt.Size = new System.Drawing.Size(100, 20);
            this.phoneNumTxt.TabIndex = 9;
            // 
            // birthDayTxt
            // 
            this.birthDayTxt.Location = new System.Drawing.Point(196, 150);
            this.birthDayTxt.Name = "birthDayTxt";
            this.birthDayTxt.Size = new System.Drawing.Size(100, 20);
            this.birthDayTxt.TabIndex = 8;
            // 
            // birthMonthTxt
            // 
            this.birthMonthTxt.Location = new System.Drawing.Point(196, 120);
            this.birthMonthTxt.Name = "birthMonthTxt";
            this.birthMonthTxt.Size = new System.Drawing.Size(100, 20);
            this.birthMonthTxt.TabIndex = 7;
            // 
            // lastNameTxt
            // 
            this.lastNameTxt.Location = new System.Drawing.Point(196, 58);
            this.lastNameTxt.Name = "lastNameTxt";
            this.lastNameTxt.Size = new System.Drawing.Size(100, 20);
            this.lastNameTxt.TabIndex = 6;
            // 
            // firstNameTxt
            // 
            this.firstNameTxt.Location = new System.Drawing.Point(196, 29);
            this.firstNameTxt.Name = "firstNameTxt";
            this.firstNameTxt.Size = new System.Drawing.Size(100, 20);
            this.firstNameTxt.TabIndex = 5;
            // 
            // birthDayLbl
            // 
            this.birthDayLbl.AutoSize = true;
            this.birthDayLbl.Location = new System.Drawing.Point(21, 150);
            this.birthDayLbl.Name = "birthDayLbl";
            this.birthDayLbl.Size = new System.Drawing.Size(50, 13);
            this.birthDayLbl.TabIndex = 4;
            this.birthDayLbl.Text = "Birth Day";
            // 
            // birthMonthLbl
            // 
            this.birthMonthLbl.AutoSize = true;
            this.birthMonthLbl.Location = new System.Drawing.Point(21, 120);
            this.birthMonthLbl.Name = "birthMonthLbl";
            this.birthMonthLbl.Size = new System.Drawing.Size(61, 13);
            this.birthMonthLbl.TabIndex = 3;
            this.birthMonthLbl.Text = "Birth Month";
            // 
            // phoneNumberLbl
            // 
            this.phoneNumberLbl.AutoSize = true;
            this.phoneNumberLbl.Location = new System.Drawing.Point(21, 88);
            this.phoneNumberLbl.Name = "phoneNumberLbl";
            this.phoneNumberLbl.Size = new System.Drawing.Size(78, 13);
            this.phoneNumberLbl.TabIndex = 2;
            this.phoneNumberLbl.Text = "Phone Number";
            // 
            // lastNameLbl
            // 
            this.lastNameLbl.AutoSize = true;
            this.lastNameLbl.Location = new System.Drawing.Point(21, 58);
            this.lastNameLbl.Name = "lastNameLbl";
            this.lastNameLbl.Size = new System.Drawing.Size(58, 13);
            this.lastNameLbl.TabIndex = 1;
            this.lastNameLbl.Text = "Last Name";
            // 
            // firstNameLbl
            // 
            this.firstNameLbl.AutoSize = true;
            this.firstNameLbl.Location = new System.Drawing.Point(21, 29);
            this.firstNameLbl.Name = "firstNameLbl";
            this.firstNameLbl.Size = new System.Drawing.Size(57, 13);
            this.firstNameLbl.TabIndex = 0;
            this.firstNameLbl.Text = "First Name";
            // 
            // readTab
            // 
            this.readTab.Controls.Add(this.exitBtn2);
            this.readTab.Controls.Add(this.readBtn);
            this.readTab.Controls.Add(this.readListBox);
            this.readTab.Location = new System.Drawing.Point(4, 22);
            this.readTab.Name = "readTab";
            this.readTab.Padding = new System.Windows.Forms.Padding(3);
            this.readTab.Size = new System.Drawing.Size(482, 281);
            this.readTab.TabIndex = 1;
            this.readTab.Text = "Read";
            this.readTab.UseVisualStyleBackColor = true;
            // 
            // exitBtn2
            // 
            this.exitBtn2.Location = new System.Drawing.Point(194, 235);
            this.exitBtn2.Name = "exitBtn2";
            this.exitBtn2.Size = new System.Drawing.Size(75, 23);
            this.exitBtn2.TabIndex = 2;
            this.exitBtn2.Text = "Exit";
            this.exitBtn2.UseVisualStyleBackColor = true;
            // 
            // readBtn
            // 
            this.readBtn.Location = new System.Drawing.Point(7, 235);
            this.readBtn.Name = "readBtn";
            this.readBtn.Size = new System.Drawing.Size(75, 23);
            this.readBtn.TabIndex = 1;
            this.readBtn.Text = "Read";
            this.readBtn.UseVisualStyleBackColor = true;
            // 
            // readListBox
            // 
            this.readListBox.FormattingEnabled = true;
            this.readListBox.Location = new System.Drawing.Point(7, 6);
            this.readListBox.Name = "readListBox";
            this.readListBox.Size = new System.Drawing.Size(469, 199);
            this.readListBox.TabIndex = 0;
            // 
            // reminderTab
            // 
            this.reminderTab.Controls.Add(this.textBox5);
            this.reminderTab.Controls.Add(this.exitBtn3);
            this.reminderTab.Controls.Add(this.reminderBtn);
            this.reminderTab.Controls.Add(this.reminderListBox);
            this.reminderTab.Location = new System.Drawing.Point(4, 22);
            this.reminderTab.Name = "reminderTab";
            this.reminderTab.Padding = new System.Windows.Forms.Padding(3);
            this.reminderTab.Size = new System.Drawing.Size(482, 281);
            this.reminderTab.TabIndex = 2;
            this.reminderTab.Text = "Reminder";
            this.reminderTab.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(32, 231);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 5;
            // 
            // exitBtn3
            // 
            this.exitBtn3.Location = new System.Drawing.Point(325, 228);
            this.exitBtn3.Name = "exitBtn3";
            this.exitBtn3.Size = new System.Drawing.Size(75, 23);
            this.exitBtn3.TabIndex = 4;
            this.exitBtn3.Text = "Exit";
            this.exitBtn3.UseVisualStyleBackColor = true;
            // 
            // reminderBtn
            // 
            this.reminderBtn.Location = new System.Drawing.Point(138, 228);
            this.reminderBtn.Name = "reminderBtn";
            this.reminderBtn.Size = new System.Drawing.Size(75, 23);
            this.reminderBtn.TabIndex = 3;
            this.reminderBtn.Text = "Reminder";
            this.reminderBtn.UseVisualStyleBackColor = true;
            // 
            // reminderListBox
            // 
            this.reminderListBox.FormattingEnabled = true;
            this.reminderListBox.Location = new System.Drawing.Point(7, 5);
            this.reminderListBox.Name = "reminderListBox";
            this.reminderListBox.Size = new System.Drawing.Size(469, 199);
            this.reminderListBox.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 320);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Friends";
            this.tabControl1.ResumeLayout(false);
            this.entryTab.ResumeLayout(false);
            this.entryTab.PerformLayout();
            this.readTab.ResumeLayout(false);
            this.reminderTab.ResumeLayout(false);
            this.reminderTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage entryTab;
        private System.Windows.Forms.MaskedTextBox phoneNumTxt;
        private System.Windows.Forms.TextBox birthDayTxt;
        private System.Windows.Forms.TextBox birthMonthTxt;
        private System.Windows.Forms.TextBox lastNameTxt;
        private System.Windows.Forms.TextBox firstNameTxt;
        private System.Windows.Forms.Label birthDayLbl;
        private System.Windows.Forms.Label birthMonthLbl;
        private System.Windows.Forms.Label phoneNumberLbl;
        private System.Windows.Forms.Label lastNameLbl;
        private System.Windows.Forms.Label firstNameLbl;
        private System.Windows.Forms.TabPage readTab;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button enterBtn;
        private System.Windows.Forms.Button exitBtn2;
        private System.Windows.Forms.Button readBtn;
        private System.Windows.Forms.ListBox readListBox;
        private System.Windows.Forms.TabPage reminderTab;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button exitBtn3;
        private System.Windows.Forms.Button reminderBtn;
        private System.Windows.Forms.ListBox reminderListBox;
    }
}

