
namespace LogRegPage
{
    partial class Register
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.Password = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.createAcc = new System.Windows.Forms.LinkLabel();
            this.AccountType = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cnfPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gradeSelector = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(144, 190);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 17);
            this.linkLabel1.TabIndex = 17;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(482, 113);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(121, 22);
            this.Password.TabIndex = 16;
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(482, 60);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(121, 22);
            this.Username.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(223, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Account Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Username";
            // 
            // createAcc
            // 
            this.createAcc.AutoSize = true;
            this.createAcc.Location = new System.Drawing.Point(363, 360);
            this.createAcc.Name = "createAcc";
            this.createAcc.Size = new System.Drawing.Size(130, 17);
            this.createAcc.TabIndex = 11;
            this.createAcc.TabStop = true;
            this.createAcc.Text = "Back to Login page";
            this.createAcc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.createAcc_LinkClicked);
            // 
            // AccountType
            // 
            this.AccountType.FormattingEnabled = true;
            this.AccountType.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.AccountType.Location = new System.Drawing.Point(482, 249);
            this.AccountType.Name = "AccountType";
            this.AccountType.Size = new System.Drawing.Size(121, 24);
            this.AccountType.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(528, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cnfPassword
            // 
            this.cnfPassword.Location = new System.Drawing.Point(482, 164);
            this.cnfPassword.Name = "cnfPassword";
            this.cnfPassword.Size = new System.Drawing.Size(121, 22);
            this.cnfPassword.TabIndex = 19;
            this.cnfPassword.TextChanged += new System.EventHandler(this.cnfPassword_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(223, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Confirm Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(223, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Grade";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // gradeSelector
            // 
            this.gradeSelector.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.gradeSelector.FormattingEnabled = true;
            this.gradeSelector.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.gradeSelector.Location = new System.Drawing.Point(482, 208);
            this.gradeSelector.Name = "gradeSelector";
            this.gradeSelector.Size = new System.Drawing.Size(121, 24);
            this.gradeSelector.TabIndex = 22;
            this.gradeSelector.SelectedIndexChanged += new System.EventHandler(this.gradeSelector_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(226, 321);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "Main menu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.gradeSelector);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cnfPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.createAcc);
            this.Controls.Add(this.AccountType);
            this.Controls.Add(this.button1);
            this.Name = "Register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel createAcc;
        private System.Windows.Forms.ComboBox AccountType;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox cnfPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox gradeSelector;
        private System.Windows.Forms.Button button2;
    }
}