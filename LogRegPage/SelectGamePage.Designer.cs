
namespace LogRegPage
{
    partial class SelectGamePage
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
            this.FlagGame = new System.Windows.Forms.Button();
            this.SecondGame = new System.Windows.Forms.Button();
            this.UpdateAcc = new System.Windows.Forms.Button();
            this.DeleteAcc = new System.Windows.Forms.Button();
            this.MainMenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Update = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FlagGame
            // 
            this.FlagGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.FlagGame.Location = new System.Drawing.Point(82, 112);
            this.FlagGame.Name = "FlagGame";
            this.FlagGame.Size = new System.Drawing.Size(128, 37);
            this.FlagGame.TabIndex = 0;
            this.FlagGame.Text = "Flag game";
            this.FlagGame.UseVisualStyleBackColor = true;
            // 
            // SecondGame
            // 
            this.SecondGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.SecondGame.Location = new System.Drawing.Point(82, 188);
            this.SecondGame.Name = "SecondGame";
            this.SecondGame.Size = new System.Drawing.Size(128, 37);
            this.SecondGame.TabIndex = 1;
            this.SecondGame.Text = "Second Game";
            this.SecondGame.UseVisualStyleBackColor = true;
            // 
            // UpdateAcc
            // 
            this.UpdateAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.UpdateAcc.Location = new System.Drawing.Point(613, 112);
            this.UpdateAcc.Name = "UpdateAcc";
            this.UpdateAcc.Size = new System.Drawing.Size(109, 37);
            this.UpdateAcc.TabIndex = 2;
            this.UpdateAcc.Text = "Update";
            this.UpdateAcc.UseVisualStyleBackColor = true;
            this.UpdateAcc.Click += new System.EventHandler(this.UpdateAcc_Click);
            // 
            // DeleteAcc
            // 
            this.DeleteAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.8F);
            this.DeleteAcc.Location = new System.Drawing.Point(613, 188);
            this.DeleteAcc.Name = "DeleteAcc";
            this.DeleteAcc.Size = new System.Drawing.Size(109, 37);
            this.DeleteAcc.TabIndex = 3;
            this.DeleteAcc.Text = "Delete";
            this.DeleteAcc.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            this.MainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.8F);
            this.MainMenu.Location = new System.Drawing.Point(320, 293);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(159, 56);
            this.MainMenu.TabIndex = 4;
            this.MainMenu.Text = "Main Menu";
            this.MainMenu.UseVisualStyleBackColor = true;
            this.MainMenu.Click += new System.EventHandler(this.MainMenu_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(588, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 43);
            this.label1.TabIndex = 5;
            this.label1.Text = "Account Options";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(75, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 43);
            this.label2.TabIndex = 6;
            this.label2.Text = "Games";
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(347, 125);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(75, 23);
            this.Update.TabIndex = 7;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // SelectGamePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.DeleteAcc);
            this.Controls.Add(this.UpdateAcc);
            this.Controls.Add(this.SecondGame);
            this.Controls.Add(this.FlagGame);
            this.Name = "SelectGamePage";
            this.Text = "Select game page";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button FlagGame;
        private System.Windows.Forms.Button SecondGame;
        private System.Windows.Forms.Button UpdateAcc;
        private System.Windows.Forms.Button DeleteAcc;
        private System.Windows.Forms.Button MainMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Update;
    }
}