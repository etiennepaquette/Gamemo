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
            // FormAddGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 51);
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
    }
}