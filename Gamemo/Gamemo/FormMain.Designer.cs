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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDeleteGame = new System.Windows.Forms.Button();
            this.BtnMemo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAddGame
            // 
            this.buttonAddGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddGame.Location = new System.Drawing.Point(12, 12);
            this.buttonAddGame.Name = "buttonAddGame";
            this.buttonAddGame.Size = new System.Drawing.Size(143, 56);
            this.buttonAddGame.TabIndex = 0;
            this.buttonAddGame.Text = "Add a Game";
            this.buttonAddGame.UseVisualStyleBackColor = true;
            this.buttonAddGame.Click += new System.EventHandler(this.buttonAddGame_Click);
            // 
            // listBoxGames
            // 
            this.listBoxGames.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxGames.FormattingEnabled = true;
            this.listBoxGames.ItemHeight = 20;
            this.listBoxGames.Location = new System.Drawing.Point(12, 87);
            this.listBoxGames.Name = "listBoxGames";
            this.listBoxGames.Size = new System.Drawing.Size(293, 284);
            this.listBoxGames.TabIndex = 1;
            this.listBoxGames.SelectedIndexChanged += new System.EventHandler(this.listBoxGames_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(313, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(140, 57);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDeleteGame
            // 
            this.btnDeleteGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteGame.Location = new System.Drawing.Point(161, 12);
            this.btnDeleteGame.Name = "btnDeleteGame";
            this.btnDeleteGame.Size = new System.Drawing.Size(144, 56);
            this.btnDeleteGame.TabIndex = 5;
            this.btnDeleteGame.Text = "Delete Game";
            this.btnDeleteGame.UseVisualStyleBackColor = true;
            this.btnDeleteGame.Click += new System.EventHandler(this.btnDeleteGame_Click);
            // 
            // BtnMemo
            // 
            this.BtnMemo.Enabled = false;
            this.BtnMemo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMemo.Location = new System.Drawing.Point(313, 87);
            this.BtnMemo.Name = "BtnMemo";
            this.BtnMemo.Size = new System.Drawing.Size(140, 284);
            this.BtnMemo.TabIndex = 6;
            this.BtnMemo.Text = "Memo";
            this.BtnMemo.UseVisualStyleBackColor = true;
            this.BtnMemo.Click += new System.EventHandler(this.BtnMemo_Click);
            // 
            // FormMain
            // 
            this.ClientSize = new System.Drawing.Size(471, 386);
            this.Controls.Add(this.BtnMemo);
            this.Controls.Add(this.btnDeleteGame);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.listBoxGames);
            this.Controls.Add(this.buttonAddGame);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion
        
        private System.Windows.Forms.Button buttonAddGame;
        private System.Windows.Forms.ListBox listBoxGames;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDeleteGame;
        private System.Windows.Forms.Button BtnMemo;
    }
}

