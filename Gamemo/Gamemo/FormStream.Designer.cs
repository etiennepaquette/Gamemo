namespace Gamemo
{
    partial class FormStream
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStream));
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ToolTipBG = new System.Windows.Forms.PictureBox();
            this.ToolTipDescription = new System.Windows.Forms.Label();
            this.ToolTipEdgeLeft = new System.Windows.Forms.PictureBox();
            this.ToolTipMiddle = new System.Windows.Forms.PictureBox();
            this.ToolTipEdgeRight = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ToolTipBG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToolTipEdgeLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToolTipMiddle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToolTipEdgeRight)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 20);
            this.button1.TabIndex = 0;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button1_MouseDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 20);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // ToolTipBG
            // 
            this.ToolTipBG.Image = ((System.Drawing.Image)(resources.GetObject("ToolTipBG.Image")));
            this.ToolTipBG.Location = new System.Drawing.Point(0, 216);
            this.ToolTipBG.Name = "ToolTipBG";
            this.ToolTipBG.Size = new System.Drawing.Size(512, 56);
            this.ToolTipBG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ToolTipBG.TabIndex = 2;
            this.ToolTipBG.TabStop = false;
            this.ToolTipBG.Visible = false;
            // 
            // ToolTipDescription
            // 
            this.ToolTipDescription.AutoSize = true;
            this.ToolTipDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ToolTipDescription.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolTipDescription.Location = new System.Drawing.Point(15, 12);
            this.ToolTipDescription.Name = "ToolTipDescription";
            this.ToolTipDescription.Size = new System.Drawing.Size(373, 29);
            this.ToolTipDescription.TabIndex = 3;
            this.ToolTipDescription.Text = "Testing the transparency of this label";
            this.ToolTipDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ToolTipEdgeLeft
            // 
            this.ToolTipEdgeLeft.Image = ((System.Drawing.Image)(resources.GetObject("ToolTipEdgeLeft.Image")));
            this.ToolTipEdgeLeft.Location = new System.Drawing.Point(0, 0);
            this.ToolTipEdgeLeft.Name = "ToolTipEdgeLeft";
            this.ToolTipEdgeLeft.Size = new System.Drawing.Size(28, 56);
            this.ToolTipEdgeLeft.TabIndex = 5;
            this.ToolTipEdgeLeft.TabStop = false;
            // 
            // ToolTipMiddle
            // 
            this.ToolTipMiddle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ToolTipMiddle.Image = ((System.Drawing.Image)(resources.GetObject("ToolTipMiddle.Image")));
            this.ToolTipMiddle.Location = new System.Drawing.Point(0, 0);
            this.ToolTipMiddle.Name = "ToolTipMiddle";
            this.ToolTipMiddle.Size = new System.Drawing.Size(296, 56);
            this.ToolTipMiddle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ToolTipMiddle.TabIndex = 5;
            this.ToolTipMiddle.TabStop = false;
            this.ToolTipMiddle.Visible = false;
            // 
            // ToolTipEdgeRight
            // 
            this.ToolTipEdgeRight.BackColor = System.Drawing.Color.Transparent;
            this.ToolTipEdgeRight.Image = ((System.Drawing.Image)(resources.GetObject("ToolTipEdgeRight.Image")));
            this.ToolTipEdgeRight.Location = new System.Drawing.Point(0, 0);
            this.ToolTipEdgeRight.Name = "ToolTipEdgeRight";
            this.ToolTipEdgeRight.Size = new System.Drawing.Size(28, 56);
            this.ToolTipEdgeRight.TabIndex = 6;
            this.ToolTipEdgeRight.TabStop = false;
            this.ToolTipEdgeRight.Visible = false;
            // 
            // FormStream
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(520, 525);
            this.Controls.Add(this.ToolTipDescription);
            this.Controls.Add(this.ToolTipEdgeRight);
            this.Controls.Add(this.ToolTipEdgeLeft);
            this.Controls.Add(this.ToolTipMiddle);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ToolTipBG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormStream";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "FormStream";
            this.Load += new System.EventHandler(this.FormStream_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ToolTipBG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToolTipEdgeLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToolTipMiddle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToolTipEdgeRight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ToolTipBG;
        private System.Windows.Forms.Label ToolTipDescription;
        private System.Windows.Forms.PictureBox ToolTipMiddle;
        private System.Windows.Forms.PictureBox ToolTipEdgeRight;
        private System.Windows.Forms.PictureBox ToolTipEdgeLeft;
    }
}