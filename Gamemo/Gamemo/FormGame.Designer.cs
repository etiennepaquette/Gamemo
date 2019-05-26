namespace Gamemo
{
    partial class FormGame
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
            if (disposing && (components != null)) {
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
            this.labelGameName = new System.Windows.Forms.Label();
            this.textBoxGameMemo = new System.Windows.Forms.TextBox();
            this.BtnAchievements = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Game Name: ";
            // 
            // labelGameName
            // 
            this.labelGameName.AutoSize = true;
            this.labelGameName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGameName.Location = new System.Drawing.Point(156, 9);
            this.labelGameName.Name = "labelGameName";
            this.labelGameName.Size = new System.Drawing.Size(117, 24);
            this.labelGameName.TabIndex = 1;
            this.labelGameName.Text = "gameName";
            // 
            // textBoxGameMemo
            // 
            this.textBoxGameMemo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGameMemo.Location = new System.Drawing.Point(16, 49);
            this.textBoxGameMemo.Multiline = true;
            this.textBoxGameMemo.Name = "textBoxGameMemo";
            this.textBoxGameMemo.Size = new System.Drawing.Size(257, 234);
            this.textBoxGameMemo.TabIndex = 2;
            this.textBoxGameMemo.LostFocus += new System.EventHandler(this.textBoxGameMemo_LostFocus);
            // 
            // BtnAchievements
            // 
            this.BtnAchievements.Enabled = false;
            this.BtnAchievements.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAchievements.Location = new System.Drawing.Point(279, 49);
            this.BtnAchievements.Name = "BtnAchievements";
            this.BtnAchievements.Size = new System.Drawing.Size(142, 35);
            this.BtnAchievements.TabIndex = 0;
            this.BtnAchievements.Text = "Achievements";
            this.BtnAchievements.UseVisualStyleBackColor = true;
            this.BtnAchievements.Click += new System.EventHandler(this.BtnAchievements_Click);
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 295);
            this.Controls.Add(this.BtnAchievements);
            this.Controls.Add(this.textBoxGameMemo);
            this.Controls.Add(this.labelGameName);
            this.Controls.Add(this.label1);
            this.Name = "FormGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormGame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelGameName;
        private System.Windows.Forms.TextBox textBoxGameMemo;
        private System.Windows.Forms.Button BtnAchievements;
    }
}