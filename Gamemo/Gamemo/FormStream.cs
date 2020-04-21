using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gamemo
{
    public partial class FormStream : Form
    {
        private const int ImageSize = 32;
        private const int ImageByRow = 32;
        private const int TopOffset = 20;
        private List<Achievement> AchievementsList;
        private Label DescriptionLabel;
        private Label DescriptionLabelShadow;

        public FormStream() { }

        public FormStream(List<Achievement> achievementsList)
        {
            AchievementsList = achievementsList;
            InitializeComponent();
            CreateDescriptionLabel();
            CreatePictureBoxes();
        }

        private void CreatePictureBoxes()
        {
            var size = new Size(ImageSize, ImageSize);
            int i = 0;
            foreach (var ach in AchievementsList) {
                var pictureBox = new PictureBox();
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.Size = size;
                pictureBox.Location = new Point((i % ImageByRow) * ImageSize, 
                                                (i / ImageByRow) * ImageSize + TopOffset);
                pictureBox.ImageLocation = ach.IconGray;
                pictureBox.Name = ach.Icon; // Name used to store the completed icon image
                pictureBox.Tag = ach;
                pictureBox.Click += new EventHandler(pictureBox_Click);
                pictureBox.MouseHover += new EventHandler(pictureBox_MouseHover);
                this.Controls.Add(pictureBox);
                i++;
            }
            int nbRows = (int)Math.Ceiling(AchievementsList.Count / (double)ImageByRow);
            this.Size = new Size(ImageSize * ImageByRow, ImageSize * nbRows + TopOffset);
        }

        private void CreateDescriptionLabel()
        {
            DescriptionLabelShadow = new Label();
            DescriptionLabelShadow.Size = new Size(ImageSize * ImageByRow, 35);
            DescriptionLabelShadow.Font = new Font("Calibri", 16);
            DescriptionLabelShadow.BackColor = Color.Black;
            DescriptionLabelShadow.BorderStyle = BorderStyle.FixedSingle;
            DescriptionLabelShadow.Location = new Point(
                AchievementsList.Count % ImageByRow * ImageSize + 4, 
                ImageSize * (int)Math.Ceiling(AchievementsList.Count / (double)ImageByRow) - 7);

            DescriptionLabel = new Label();
            DescriptionLabel.Size = DescriptionLabelShadow.Size;
            DescriptionLabel.Font = DescriptionLabelShadow.Font;
            DescriptionLabel.ForeColor = Color.Red;
            DescriptionLabel.BorderStyle = BorderStyle.FixedSingle;
            DescriptionLabel.Location = new Point(DescriptionLabelShadow.Location.X - 4, DescriptionLabelShadow.Location.Y - 4);

            this.Controls.Add(DescriptionLabel);
            this.Controls.Add(DescriptionLabelShadow);
        }

        // Events
        private void pictureBox_Click(object sender, System.EventArgs e)
        {
            var pBox = (PictureBox)sender;
            var achievement = (Achievement)pBox.Tag;

            pBox.ImageLocation = pBox.ImageLocation == achievement.Icon ? achievement.IconGray : achievement.Icon;
        }

        private void pictureBox_MouseHover(object sender, System.EventArgs e)
        {
            var pBox = (PictureBox)sender;
            var achievement = (Achievement)pBox.Tag;

            DescriptionLabel.Text = $"[{achievement.GlobalPercentage}%] {achievement.Name}: {achievement.Description}";
        }


        // Window control
        int mouseX = 0;
        int mouseY = 0;
        bool mouseDown;

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown) {
                mouseX = MousePosition.X - 200;
                mouseY = MousePosition.Y - 40;

                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}
