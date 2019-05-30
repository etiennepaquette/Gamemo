namespace Gamemo
{
    partial class FormMain
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
            this.buttonAddGame = new System.Windows.Forms.Button();
            this.listBoxGames = new System.Windows.Forms.ListBox();
            this.btnDeleteGame = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnFetchGameList = new System.Windows.Forms.Button();
            this.comboBoxGameList = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxGameName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtBoxGameMemo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnAddSteamGame = new System.Windows.Forms.Button();
            this.BtnGameAchievements = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAddGame
            // 
            this.buttonAddGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddGame.Location = new System.Drawing.Point(92, 78);
            this.buttonAddGame.Name = "buttonAddGame";
            this.buttonAddGame.Size = new System.Drawing.Size(146, 46);
            this.buttonAddGame.TabIndex = 0;
            this.buttonAddGame.Text = "Add Game";
            this.buttonAddGame.UseVisualStyleBackColor = true;
            this.buttonAddGame.Click += new System.EventHandler(this.buttonAddGame_Click);
            // 
            // listBoxGames
            // 
            this.listBoxGames.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxGames.FormattingEnabled = true;
            this.listBoxGames.ItemHeight = 20;
            this.listBoxGames.Location = new System.Drawing.Point(12, 42);
            this.listBoxGames.Name = "listBoxGames";
            this.listBoxGames.Size = new System.Drawing.Size(186, 284);
            this.listBoxGames.TabIndex = 1;
            this.listBoxGames.SelectedIndexChanged += new System.EventHandler(this.listBoxGames_SelectedIndexChanged);
            // 
            // btnDeleteGame
            // 
            this.btnDeleteGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteGame.Location = new System.Drawing.Point(12, 332);
            this.btnDeleteGame.Name = "btnDeleteGame";
            this.btnDeleteGame.Size = new System.Drawing.Size(186, 49);
            this.btnDeleteGame.TabIndex = 5;
            this.btnDeleteGame.Text = "Delete Selected Game";
            this.btnDeleteGame.UseVisualStyleBackColor = true;
            this.btnDeleteGame.Click += new System.EventHandler(this.btnDeleteGame_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Games";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(604, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 373);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Game";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnAddSteamGame);
            this.groupBox3.Controls.Add(this.btnFetchGameList);
            this.groupBox3.Controls.Add(this.comboBoxGameList);
            this.groupBox3.Location = new System.Drawing.Point(15, 180);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(340, 183);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Steam Game";
            // 
            // btnFetchGameList
            // 
            this.btnFetchGameList.Enabled = false;
            this.btnFetchGameList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFetchGameList.Location = new System.Drawing.Point(22, 39);
            this.btnFetchGameList.Name = "btnFetchGameList";
            this.btnFetchGameList.Size = new System.Drawing.Size(303, 26);
            this.btnFetchGameList.TabIndex = 10;
            this.btnFetchGameList.Text = "Fetch Steam\'s Game List";
            this.btnFetchGameList.UseVisualStyleBackColor = true;
            this.btnFetchGameList.Click += new System.EventHandler(this.btnFetchGameList_Click);
            // 
            // comboBoxGameList
            // 
            this.comboBoxGameList.Enabled = false;
            this.comboBoxGameList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGameList.Location = new System.Drawing.Point(22, 71);
            this.comboBoxGameList.Name = "comboBoxGameList";
            this.comboBoxGameList.Size = new System.Drawing.Size(303, 28);
            this.comboBoxGameList.Sorted = true;
            this.comboBoxGameList.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxGameName);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.buttonAddGame);
            this.groupBox2.Location = new System.Drawing.Point(15, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(340, 138);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Non-steam Game";
            // 
            // textBoxGameName
            // 
            this.textBoxGameName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGameName.Location = new System.Drawing.Point(140, 40);
            this.textBoxGameName.Name = "textBoxGameName";
            this.textBoxGameName.Size = new System.Drawing.Size(185, 26);
            this.textBoxGameName.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Game name: ";
            // 
            // TxtBoxGameMemo
            // 
            this.TxtBoxGameMemo.Enabled = false;
            this.TxtBoxGameMemo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxGameMemo.Location = new System.Drawing.Point(216, 42);
            this.TxtBoxGameMemo.Multiline = true;
            this.TxtBoxGameMemo.Name = "TxtBoxGameMemo";
            this.TxtBoxGameMemo.Size = new System.Drawing.Size(348, 284);
            this.TxtBoxGameMemo.TabIndex = 9;
            this.TxtBoxGameMemo.Leave += new System.EventHandler(this.TxtBoxGameMemo_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(212, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Game\'s memo";
            // 
            // BtnAddSteamGame
            // 
            this.BtnAddSteamGame.Enabled = false;
            this.BtnAddSteamGame.Location = new System.Drawing.Point(92, 114);
            this.BtnAddSteamGame.Name = "BtnAddSteamGame";
            this.BtnAddSteamGame.Size = new System.Drawing.Size(146, 56);
            this.BtnAddSteamGame.TabIndex = 11;
            this.BtnAddSteamGame.Text = "Add Steam Game";
            this.BtnAddSteamGame.UseVisualStyleBackColor = true;
            this.BtnAddSteamGame.Click += new System.EventHandler(this.BtnAddSteamGame_Click);
            // 
            // BtnGameAchievements
            // 
            this.BtnGameAchievements.Enabled = false;
            this.BtnGameAchievements.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGameAchievements.Location = new System.Drawing.Point(216, 332);
            this.BtnGameAchievements.Name = "BtnGameAchievements";
            this.BtnGameAchievements.Size = new System.Drawing.Size(348, 49);
            this.BtnGameAchievements.TabIndex = 11;
            this.BtnGameAchievements.Text = "Game\'s Achievements";
            this.BtnGameAchievements.UseVisualStyleBackColor = true;
            this.BtnGameAchievements.Click += new System.EventHandler(this.BtnGameAchievements_Click);
            // 
            // FormMain
            // 
            this.ClientSize = new System.Drawing.Size(983, 393);
            this.Controls.Add(this.BtnGameAchievements);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtBoxGameMemo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeleteGame);
            this.Controls.Add(this.listBoxGames);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.Button buttonAddGame;
        private System.Windows.Forms.ListBox listBoxGames;
        private System.Windows.Forms.Button btnDeleteGame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnFetchGameList;
        private System.Windows.Forms.ComboBox comboBoxGameList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxGameName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtBoxGameMemo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnAddSteamGame;
        private System.Windows.Forms.Button BtnGameAchievements;
    }
}

