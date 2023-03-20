
namespace LogRegPage
{
    partial class Leaderboard
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
            this.NGSdataGV = new System.Windows.Forms.DataGridView();
            this.ButtonForGeneratingLeaderboard = new System.Windows.Forms.Button();
            this.GradeSelector = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Test = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScoreGameOne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScoreGameTwo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.NGSdataGV)).BeginInit();
            this.SuspendLayout();
            // 
            // NGSdataGV
            // 
            this.NGSdataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NGSdataGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserName,
            this.Grade,
            this.Test,
            this.ScoreGameOne,
            this.ScoreGameTwo});
            this.NGSdataGV.Location = new System.Drawing.Point(43, 12);
            this.NGSdataGV.Name = "NGSdataGV";
            this.NGSdataGV.RowHeadersWidth = 51;
            this.NGSdataGV.RowTemplate.Height = 24;
            this.NGSdataGV.Size = new System.Drawing.Size(570, 426);
            this.NGSdataGV.TabIndex = 2;
            this.NGSdataGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.NGSdataGV_CellContentClick);
            // 
            // ButtonForGeneratingLeaderboard
            // 
            this.ButtonForGeneratingLeaderboard.Location = new System.Drawing.Point(661, 245);
            this.ButtonForGeneratingLeaderboard.Name = "ButtonForGeneratingLeaderboard";
            this.ButtonForGeneratingLeaderboard.Size = new System.Drawing.Size(96, 23);
            this.ButtonForGeneratingLeaderboard.TabIndex = 3;
            this.ButtonForGeneratingLeaderboard.Text = "Select";
            this.ButtonForGeneratingLeaderboard.UseVisualStyleBackColor = true;
            this.ButtonForGeneratingLeaderboard.Click += new System.EventHandler(this.ButtonForGeneratingLeaderboard_Click);
            // 
            // GradeSelector
            // 
            this.GradeSelector.FormattingEnabled = true;
            this.GradeSelector.Items.AddRange(new object[] {
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
            this.GradeSelector.Location = new System.Drawing.Point(648, 123);
            this.GradeSelector.Name = "GradeSelector";
            this.GradeSelector.Size = new System.Drawing.Size(121, 24);
            this.GradeSelector.TabIndex = 4;
            this.GradeSelector.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(661, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Main Page";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(661, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Grade Lable";
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "Name";
            this.UserName.MinimumWidth = 6;
            this.UserName.Name = "UserName";
            this.UserName.Width = 125;
            // 
            // Grade
            // 
            this.Grade.DataPropertyName = "Grade";
            this.Grade.HeaderText = "Grade";
            this.Grade.MinimumWidth = 6;
            this.Grade.Name = "Grade";
            this.Grade.Width = 125;
            // 
            // Test
            // 
            this.Test.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Test.DataPropertyName = "Test";
            this.Test.HeaderText = "Test";
            this.Test.MinimumWidth = 6;
            this.Test.Name = "Test";
            this.Test.Width = 125;
            // 
            // ScoreGameOne
            // 
            this.ScoreGameOne.DataPropertyName = "ScoreGameOne";
            this.ScoreGameOne.HeaderText = "ScoreGameOne";
            this.ScoreGameOne.MinimumWidth = 6;
            this.ScoreGameOne.Name = "ScoreGameOne";
            this.ScoreGameOne.Width = 125;
            // 
            // ScoreGameTwo
            // 
            this.ScoreGameTwo.DataPropertyName = "ScoreGameTwo";
            this.ScoreGameTwo.HeaderText = "ScoreGameTwo";
            this.ScoreGameTwo.MinimumWidth = 6;
            this.ScoreGameTwo.Name = "ScoreGameTwo";
            this.ScoreGameTwo.Width = 125;
            // 
            // Leaderboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GradeSelector);
            this.Controls.Add(this.ButtonForGeneratingLeaderboard);
            this.Controls.Add(this.NGSdataGV);
            this.Name = "Leaderboard";
            this.Text = "Leaderboard";
            this.Load += new System.EventHandler(this.Leaderboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NGSdataGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView NGSdataGV;
        private System.Windows.Forms.Button ButtonForGeneratingLeaderboard;
        private System.Windows.Forms.ComboBox GradeSelector;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Test;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScoreGameOne;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScoreGameTwo;
    }
}