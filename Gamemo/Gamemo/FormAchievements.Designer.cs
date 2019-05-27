namespace Gamemo
{
    partial class FormAchievements
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
            this.listBoxAchievements = new System.Windows.Forms.ListBox();
            this.labelAchievName = new System.Windows.Forms.Label();
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.labelAchievDesc = new System.Windows.Forms.Label();
            this.textBoxAchievMemo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxAchievements
            // 
            this.listBoxAchievements.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxAchievements.FormattingEnabled = true;
            this.listBoxAchievements.ItemHeight = 20;
            this.listBoxAchievements.Location = new System.Drawing.Point(12, 12);
            this.listBoxAchievements.Name = "listBoxAchievements";
            this.listBoxAchievements.Size = new System.Drawing.Size(184, 264);
            this.listBoxAchievements.TabIndex = 0;
            this.listBoxAchievements.SelectedIndexChanged += new System.EventHandler(this.listBoxAchievements_SelectedIndexChanged);
            // 
            // labelAchievName
            // 
            this.labelAchievName.AutoSize = true;
            this.labelAchievName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAchievName.Location = new System.Drawing.Point(272, 12);
            this.labelAchievName.Name = "labelAchievName";
            this.labelAchievName.Size = new System.Drawing.Size(106, 20);
            this.labelAchievName.TabIndex = 1;
            this.labelAchievName.Text = "achievName";
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.Location = new System.Drawing.Point(202, 12);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(64, 64);
            this.pictureBoxIcon.TabIndex = 2;
            this.pictureBoxIcon.TabStop = false;
            // 
            // labelAchievDesc
            // 
            this.labelAchievDesc.AutoSize = true;
            this.labelAchievDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAchievDesc.Location = new System.Drawing.Point(277, 32);
            this.labelAchievDesc.Name = "labelAchievDesc";
            this.labelAchievDesc.Size = new System.Drawing.Size(91, 20);
            this.labelAchievDesc.TabIndex = 3;
            this.labelAchievDesc.Text = "achievDesc";
            // 
            // textBoxAchievMemo
            // 
            this.textBoxAchievMemo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAchievMemo.Location = new System.Drawing.Point(202, 82);
            this.textBoxAchievMemo.Multiline = true;
            this.textBoxAchievMemo.Name = "textBoxAchievMemo";
            this.textBoxAchievMemo.Size = new System.Drawing.Size(464, 194);
            this.textBoxAchievMemo.TabIndex = 4;
            this.textBoxAchievMemo.LostFocus += new System.EventHandler(this.textBoxGameMemo_LostFocus);
            // 
            // FormAchievements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 288);
            this.Controls.Add(this.textBoxAchievMemo);
            this.Controls.Add(this.labelAchievDesc);
            this.Controls.Add(this.pictureBoxIcon);
            this.Controls.Add(this.labelAchievName);
            this.Controls.Add(this.listBoxAchievements);
            this.Name = "FormAchievements";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAchievements";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxAchievements;
        private System.Windows.Forms.Label labelAchievName;
        private System.Windows.Forms.PictureBox pictureBoxIcon;
        private System.Windows.Forms.Label labelAchievDesc;
        private System.Windows.Forms.TextBox textBoxAchievMemo;
    }
}