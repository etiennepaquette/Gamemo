namespace Gamemo
{
    partial class FormAddGame
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
            this.btnAddRandomGame = new System.Windows.Forms.Button();
            this.textBoxGameName = new System.Windows.Forms.TextBox();
            this.comboBoxGameList = new System.Windows.Forms.ComboBox();
            this.textBoxSteamID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFetchGameList = new System.Windows.Forms.Button();
            this.btnAddSteamGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddRandomGame
            // 
            this.btnAddRandomGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRandomGame.Location = new System.Drawing.Point(219, 12);
            this.btnAddRandomGame.Name = "btnAddRandomGame";
            this.btnAddRandomGame.Size = new System.Drawing.Size(154, 26);
            this.btnAddRandomGame.TabIndex = 1;
            this.btnAddRandomGame.Text = "Add Game";
            this.btnAddRandomGame.UseVisualStyleBackColor = true;
            this.btnAddRandomGame.Click += new System.EventHandler(this.btnAddRandomGame_Click);
            // 
            // textBoxGameName
            // 
            this.textBoxGameName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGameName.Location = new System.Drawing.Point(12, 12);
            this.textBoxGameName.Name = "textBoxGameName";
            this.textBoxGameName.Size = new System.Drawing.Size(185, 26);
            this.textBoxGameName.TabIndex = 0;
            // 
            // comboBoxGameList
            // 
            this.comboBoxGameList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGameList.FormattingEnabled = true;
            this.comboBoxGameList.Location = new System.Drawing.Point(12, 198);
            this.comboBoxGameList.Name = "comboBoxGameList";
            this.comboBoxGameList.Size = new System.Drawing.Size(361, 28);
            this.comboBoxGameList.Sorted = true;
            this.comboBoxGameList.TabIndex = 2;
            // 
            // textBoxSteamID
            // 
            this.textBoxSteamID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSteamID.Location = new System.Drawing.Point(88, 166);
            this.textBoxSteamID.Name = "textBoxSteamID";
            this.textBoxSteamID.Size = new System.Drawing.Size(100, 26);
            this.textBoxSteamID.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "SteamID";
            // 
            // btnFetchGameList
            // 
            this.btnFetchGameList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFetchGameList.Location = new System.Drawing.Point(194, 166);
            this.btnFetchGameList.Name = "btnFetchGameList";
            this.btnFetchGameList.Size = new System.Drawing.Size(179, 26);
            this.btnFetchGameList.TabIndex = 5;
            this.btnFetchGameList.Text = "Fetch Game List";
            this.btnFetchGameList.UseVisualStyleBackColor = true;
            this.btnFetchGameList.Click += new System.EventHandler(this.btnFetchGameList_Click);
            // 
            // btnAddSteamGame
            // 
            this.btnAddSteamGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSteamGame.Location = new System.Drawing.Point(12, 232);
            this.btnAddSteamGame.Name = "btnAddSteamGame";
            this.btnAddSteamGame.Size = new System.Drawing.Size(361, 29);
            this.btnAddSteamGame.TabIndex = 6;
            this.btnAddSteamGame.Text = "Add Steam Game";
            this.btnAddSteamGame.UseVisualStyleBackColor = true;
            // 
            // FormAddGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 272);
            this.Controls.Add(this.btnAddSteamGame);
            this.Controls.Add(this.btnFetchGameList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSteamID);
            this.Controls.Add(this.comboBoxGameList);
            this.Controls.Add(this.textBoxGameName);
            this.Controls.Add(this.btnAddRandomGame);
            this.Name = "FormAddGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAddGame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddRandomGame;
        private System.Windows.Forms.TextBox textBoxGameName;
        private System.Windows.Forms.ComboBox comboBoxGameList;
        private System.Windows.Forms.TextBox textBoxSteamID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFetchGameList;
        private System.Windows.Forms.Button btnAddSteamGame;
    }
}