
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.createAcc = new System.Windows.Forms.LinkLabel();
            this.cnfPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gradeSelector = new System.Windows.Forms.ComboBox();
            this.registerBnt = new System.Windows.Forms.Button();
            this.MainPage = new System.Windows.Forms.Button();
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
            this.Password.Location = new System.Drawing.Point(482, 145);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(121, 22);
            this.Password.TabIndex = 16;
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(482, 92);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(121, 22);
            this.Username.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 92);
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
            // cnfPassword
            // 
            this.cnfPassword.Location = new System.Drawing.Point(482, 196);
            this.cnfPassword.Name = "cnfPassword";
            this.cnfPassword.Size = new System.Drawing.Size(121, 22);
            this.cnfPassword.TabIndex = 19;
            this.cnfPassword.TextChanged += new System.EventHandler(this.cnfPassword_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(223, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Confirm Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(223, 243);
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
            this.gradeSelector.Location = new System.Drawing.Point(482, 240);
            this.gradeSelector.Name = "gradeSelector";
            this.gradeSelector.Size = new System.Drawing.Size(121, 24);
            this.gradeSelector.TabIndex = 22;
            this.gradeSelector.SelectedIndexChanged += new System.EventHandler(this.gradeSelector_SelectedIndexChanged);
            // 
            // registerBnt
            // 
            this.registerBnt.Location = new System.Drawing.Point(532, 321);
            this.registerBnt.Name = "registerBnt";
            this.registerBnt.Size = new System.Drawing.Size(75, 23);
            this.registerBnt.TabIndex = 24;
            this.registerBnt.Text = "Register";
            this.registerBnt.UseVisualStyleBackColor = true;
            this.registerBnt.Click += new System.EventHandler(this.registerBnt_Click);
            // 
            // MainPage
            // 
            this.MainPage.Location = new System.Drawing.Point(226, 321);
            this.MainPage.Name = "MainPage";
            this.MainPage.Size = new System.Drawing.Size(91, 23);
            this.MainPage.TabIndex = 25;
            this.MainPage.Text = "Main menu";
            this.MainPage.UseVisualStyleBackColor = true;
            this.MainPage.Click += new System.EventHandler(this.MainPage_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainPage);
            this.Controls.Add(this.registerBnt);
            this.Controls.Add(this.gradeSelector);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cnfPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.createAcc);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel createAcc;
        private System.Windows.Forms.TextBox cnfPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox gradeSelector;
        private System.Windows.Forms.Button registerBnt;
        private System.Windows.Forms.Button MainPage;
    }
}