namespace Gamemo
{
    partial class FormAddNewGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddNewGame));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnAddSteamGame = new System.Windows.Forms.Button();
            this.BtnFetchGameList = new System.Windows.Forms.Button();
            this.comboBoxGameList = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxGameName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnAddGame = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnAddSteamGame);
            this.groupBox3.Controls.Add(this.BtnFetchGameList);
            this.groupBox3.Controls.Add(this.comboBoxGameList);
            this.groupBox3.Location = new System.Drawing.Point(18, 159);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(419, 171);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Steam Game";
            // 
            // BtnAddSteamGame
            // 
            this.BtnAddSteamGame.Enabled = false;
            this.BtnAddSteamGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddSteamGame.Location = new System.Drawing.Point(103, 117);
            this.BtnAddSteamGame.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnAddSteamGame.Name = "BtnAddSteamGame";
            this.BtnAddSteamGame.Size = new System.Drawing.Size(194, 39);
            this.BtnAddSteamGame.TabIndex = 11;
            this.BtnAddSteamGame.Text = "Add Steam Game";
            this.BtnAddSteamGame.UseVisualStyleBackColor = true;
            // 
            // BtnFetchGameList
            // 
            this.BtnFetchGameList.Enabled = false;
            this.BtnFetchGameList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFetchGameList.Location = new System.Drawing.Point(21, 29);
            this.BtnFetchGameList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnFetchGameList.Name = "BtnFetchGameList";
            this.BtnFetchGameList.Size = new System.Drawing.Size(385, 40);
            this.BtnFetchGameList.TabIndex = 10;
            this.BtnFetchGameList.Text = "Fetch Steam\'s Game List";
            this.BtnFetchGameList.UseVisualStyleBackColor = true;
            // 
            // comboBoxGameList
            // 
            this.comboBoxGameList.Enabled = false;
            this.comboBoxGameList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGameList.Location = new System.Drawing.Point(21, 79);
            this.comboBoxGameList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxGameList.Name = "comboBoxGameList";
            this.comboBoxGameList.Size = new System.Drawing.Size(385, 28);
            this.comboBoxGameList.Sorted = true;
            this.comboBoxGameList.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxGameName);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.BtnAddGame);
            this.groupBox2.Location = new System.Drawing.Point(18, 18);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(419, 120);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Non-steam Game";
            // 
            // textBoxGameName
            // 
            this.textBoxGameName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGameName.Location = new System.Drawing.Point(130, 32);
            this.textBoxGameName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxGameName.Name = "textBoxGameName";
            this.textBoxGameName.Size = new System.Drawing.Size(276, 26);
            this.textBoxGameName.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Game name: ";
            // 
            // BtnAddGame
            // 
            this.BtnAddGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddGame.Location = new System.Drawing.Point(103, 68);
            this.BtnAddGame.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnAddGame.Name = "BtnAddGame";
            this.BtnAddGame.Size = new System.Drawing.Size(194, 39);
            this.BtnAddGame.TabIndex = 0;
            this.BtnAddGame.Text = "Add Game";
            this.BtnAddGame.UseVisualStyleBackColor = true;
            this.BtnAddGame.Click += new System.EventHandler(this.BtnAddGame_Click);
            // 
            // FormAddNewGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 344);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FormAddNewGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Game";
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtnAddSteamGame;
        private System.Windows.Forms.Button BtnFetchGameList;
        private System.Windows.Forms.ComboBox comboBoxGameList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxGameName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnAddGame;
    }
}