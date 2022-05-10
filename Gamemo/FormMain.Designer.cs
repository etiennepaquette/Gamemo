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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.listBoxGames = new System.Windows.Forms.ListBox();
            this.btnDeleteGame = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBoxGameMemo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnGameAchievements = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItemAddNewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxGames
            // 
            this.listBoxGames.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxGames.FormattingEnabled = true;
            this.listBoxGames.ItemHeight = 20;
            this.listBoxGames.Location = new System.Drawing.Point(12, 70);
            this.listBoxGames.Name = "listBoxGames";
            this.listBoxGames.Size = new System.Drawing.Size(186, 284);
            this.listBoxGames.TabIndex = 1;
            this.listBoxGames.SelectedIndexChanged += new System.EventHandler(this.listBoxGames_SelectedIndexChanged);
            // 
            // btnDeleteGame
            // 
            this.btnDeleteGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteGame.Location = new System.Drawing.Point(12, 360);
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
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Games";
            // 
            // TxtBoxGameMemo
            // 
            this.TxtBoxGameMemo.AcceptsReturn = true;
            this.TxtBoxGameMemo.AcceptsTab = true;
            this.TxtBoxGameMemo.Enabled = false;
            this.TxtBoxGameMemo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBoxGameMemo.Location = new System.Drawing.Point(216, 70);
            this.TxtBoxGameMemo.Multiline = true;
            this.TxtBoxGameMemo.Name = "TxtBoxGameMemo";
            this.TxtBoxGameMemo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtBoxGameMemo.Size = new System.Drawing.Size(348, 284);
            this.TxtBoxGameMemo.TabIndex = 9;
            this.TxtBoxGameMemo.Leave += new System.EventHandler(this.TxtBoxGameMemo_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(212, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Game\'s memo";
            // 
            // BtnGameAchievements
            // 
            this.BtnGameAchievements.Enabled = false;
            this.BtnGameAchievements.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGameAchievements.Location = new System.Drawing.Point(216, 360);
            this.BtnGameAchievements.Name = "BtnGameAchievements";
            this.BtnGameAchievements.Size = new System.Drawing.Size(348, 49);
            this.BtnGameAchievements.TabIndex = 11;
            this.BtnGameAchievements.Text = "Game\'s Achievements";
            this.BtnGameAchievements.UseVisualStyleBackColor = true;
            this.BtnGameAchievements.Click += new System.EventHandler(this.BtnGameAchievements_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemAddNewGame});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(575, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItemAddNewGame
            // 
            this.ToolStripMenuItemAddNewGame.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem});
            this.ToolStripMenuItemAddNewGame.Name = "ToolStripMenuItemAddNewGame";
            this.ToolStripMenuItemAddNewGame.Size = new System.Drawing.Size(37, 20);
            this.ToolStripMenuItemAddNewGame.Text = "File";
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.testToolStripMenuItem.Text = "Add New Game";
            this.testToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItemAddNewGame_Click);
            // 
            // FormMain
            // 
            this.ClientSize = new System.Drawing.Size(575, 418);
            this.Controls.Add(this.BtnGameAchievements);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtBoxGameMemo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeleteGame);
            this.Controls.Add(this.listBoxGames);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gamemo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxGames;
        private System.Windows.Forms.Button btnDeleteGame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBoxGameMemo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnGameAchievements;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAddNewGame;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
    }
}

