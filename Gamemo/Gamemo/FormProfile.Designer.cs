namespace Gamemo
{
    partial class FormProfile
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
            this.listBoxProfileNames = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnCreateProfile = new System.Windows.Forms.Button();
            this.textBoxSteamID = new System.Windows.Forms.TextBox();
            this.textBoxProfileName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnOpenProfile = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxProfileNames
            // 
            this.listBoxProfileNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxProfileNames.FormattingEnabled = true;
            this.listBoxProfileNames.ItemHeight = 20;
            this.listBoxProfileNames.Location = new System.Drawing.Point(6, 34);
            this.listBoxProfileNames.Name = "listBoxProfileNames";
            this.listBoxProfileNames.Size = new System.Drawing.Size(215, 64);
            this.listBoxProfileNames.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnCreateProfile);
            this.groupBox1.Controls.Add(this.textBoxSteamID);
            this.groupBox1.Controls.Add(this.textBoxProfileName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(260, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 159);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create Profile";
            // 
            // BtnCreateProfile
            // 
            this.BtnCreateProfile.Location = new System.Drawing.Point(111, 106);
            this.BtnCreateProfile.Name = "BtnCreateProfile";
            this.BtnCreateProfile.Size = new System.Drawing.Size(174, 39);
            this.BtnCreateProfile.TabIndex = 4;
            this.BtnCreateProfile.Text = "Create Profile";
            this.BtnCreateProfile.UseVisualStyleBackColor = true;
            this.BtnCreateProfile.Click += new System.EventHandler(this.BtnCreateProfile_Click);
            // 
            // textBoxSteamID
            // 
            this.textBoxSteamID.Location = new System.Drawing.Point(191, 67);
            this.textBoxSteamID.Name = "textBoxSteamID";
            this.textBoxSteamID.Size = new System.Drawing.Size(180, 26);
            this.textBoxSteamID.TabIndex = 3;
            // 
            // textBoxProfileName
            // 
            this.textBoxProfileName.Location = new System.Drawing.Point(191, 35);
            this.textBoxProfileName.Name = "textBoxProfileName";
            this.textBoxProfileName.Size = new System.Drawing.Size(180, 26);
            this.textBoxProfileName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Steam ID (Optional): ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name: ";
            // 
            // BtnOpenProfile
            // 
            this.BtnOpenProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOpenProfile.Location = new System.Drawing.Point(42, 104);
            this.BtnOpenProfile.Name = "BtnOpenProfile";
            this.BtnOpenProfile.Size = new System.Drawing.Size(139, 41);
            this.BtnOpenProfile.TabIndex = 1;
            this.BtnOpenProfile.Text = "Open";
            this.BtnOpenProfile.UseVisualStyleBackColor = true;
            this.BtnOpenProfile.Click += new System.EventHandler(this.BtnOpenProfile_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBoxProfileNames);
            this.groupBox2.Controls.Add(this.BtnOpenProfile);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(227, 159);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Open Profile";
            // 
            // FormProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 182);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormProfile";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxProfileNames;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnCreateProfile;
        private System.Windows.Forms.TextBox textBoxSteamID;
        private System.Windows.Forms.TextBox textBoxProfileName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnOpenProfile;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}