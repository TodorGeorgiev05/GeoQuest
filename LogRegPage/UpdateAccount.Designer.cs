
namespace LogRegPage
{
    partial class UpdateAccount
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
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.GradeSelect = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.UpdateAccDGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.UpdateAccDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(289, 287);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(75, 23);
            this.UpdateBtn.TabIndex = 0;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // GradeSelect
            // 
            this.GradeSelect.FormattingEnabled = true;
            this.GradeSelect.Items.AddRange(new object[] {
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
            this.GradeSelect.Location = new System.Drawing.Point(213, 207);
            this.GradeSelect.Name = "GradeSelect";
            this.GradeSelect.Size = new System.Drawing.Size(151, 24);
            this.GradeSelect.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Grade";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(213, 154);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(151, 22);
            this.Password.TabIndex = 4;
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(213, 104);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(151, 22);
            this.Username.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Username";
            // 
            // UpdateAccDGV
            // 
            this.UpdateAccDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UpdateAccDGV.Location = new System.Drawing.Point(399, 104);
            this.UpdateAccDGV.Name = "UpdateAccDGV";
            this.UpdateAccDGV.RowHeadersWidth = 51;
            this.UpdateAccDGV.RowTemplate.Height = 24;
            this.UpdateAccDGV.Size = new System.Drawing.Size(344, 206);
            this.UpdateAccDGV.TabIndex = 7;
            // 
            // UpdateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UpdateAccDGV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GradeSelect);
            this.Controls.Add(this.UpdateBtn);
            this.Name = "UpdateAccount";
            this.Text = "Update Account";
            this.Load += new System.EventHandler(this.UpdateAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UpdateAccDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.ComboBox GradeSelect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView UpdateAccDGV;
    }
}