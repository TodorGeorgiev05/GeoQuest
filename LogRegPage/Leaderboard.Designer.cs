
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
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButtonForGeneratingLeaderboard = new System.Windows.Forms.Button();
            this.GradeSelector = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.NGSdataGV)).BeginInit();
            this.SuspendLayout();
            // 
            // NGSdataGV
            // 
            this.NGSdataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NGSdataGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserName,
            this.Grade,
            this.Score});
            this.NGSdataGV.Location = new System.Drawing.Point(27, 12);
            this.NGSdataGV.Name = "NGSdataGV";
            this.NGSdataGV.RowHeadersWidth = 51;
            this.NGSdataGV.RowTemplate.Height = 24;
            this.NGSdataGV.Size = new System.Drawing.Size(570, 426);
            this.NGSdataGV.TabIndex = 2;
            this.NGSdataGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.NGSdataGV_CellContentClick);
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
            // Score
            // 
            this.Score.DataPropertyName = "Score";
            this.Score.HeaderText = "Score";
            this.Score.MinimumWidth = 6;
            this.Score.Name = "Score";
            this.Score.Width = 125;
            // 
            // ButtonForGeneratingLeaderboard
            // 
            this.ButtonForGeneratingLeaderboard.Location = new System.Drawing.Point(669, 246);
            this.ButtonForGeneratingLeaderboard.Name = "ButtonForGeneratingLeaderboard";
            this.ButtonForGeneratingLeaderboard.Size = new System.Drawing.Size(75, 23);
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
            // Leaderboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GradeSelector);
            this.Controls.Add(this.ButtonForGeneratingLeaderboard);
            this.Controls.Add(this.NGSdataGV);
            this.Name = "Leaderboard";
            this.Text = "Leaderboard";
            ((System.ComponentModel.ISupportInitialize)(this.NGSdataGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView NGSdataGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Score;
        private System.Windows.Forms.Button ButtonForGeneratingLeaderboard;
        private System.Windows.Forms.ComboBox GradeSelector;
    }
}