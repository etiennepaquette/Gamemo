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
        private const int ImageSize = 64;
        private const int ImageByRow = 32;
        private const int TopOffset = 20;
        private const int PROGRESS_BAR_MAX_SIZE = 500;
        private List<Achievement> AchievementsList;
        private int NbAchieved = 0;

        public FormStream() { }

        public FormStream(List<Achievement> achievementsList)
        {
            AchievementsList = achievementsList;
            NbAchieved = achievementsList.Where(x => x.Achieved).Count();

            InitializeComponent();
            CreatePictureBoxes();
            UpdateAchievementsProgress();
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
                pictureBox.ImageLocation = ach.Achieved ? ach.Icon : ach.IconGray;
                pictureBox.Name = ach.Icon; // Name used to store the completed icon image
                pictureBox.Tag = ach;
                pictureBox.Click += new EventHandler(pictureBox_Click);
                pictureBox.MouseHover += new EventHandler(pictureBox_MouseHover);
                pictureBox.MouseLeave += new EventHandler(pictureBox_MouseLeave);
                this.Controls.Add(pictureBox);
                i++;
            }

            int nbRows = (int)Math.Ceiling(AchievementsList.Count / (double)ImageByRow);
            this.Size = new Size(ImageSize * ImageByRow + 500, ImageSize * nbRows + TopOffset + 200);
        }

        // Events
        private void pictureBox_Click(object sender, System.EventArgs e)
        {
            var pBox = (PictureBox)sender;
            var achievement = (Achievement)pBox.Tag;

            if (pBox.ImageLocation == achievement.Icon)
            {
                pBox.ImageLocation = achievement.IconGray;
                NbAchieved--;
            }
            else
            {
                pBox.ImageLocation = achievement.Icon;
                NbAchieved++;
            }

            UpdateAchievementsProgress();
        }

        private void UpdateAchievementsProgress()
        {
            AchievementLabel.Text = $"Achievement Progress : {NbAchieved:0#}/{AchievementsList.Count()}";
            ProgressBarFilling.Size = new Size(NbAchieved * PROGRESS_BAR_MAX_SIZE / AchievementsList.Count(), ProgressBarFilling.Size.Height);
        }

        private void pictureBox_MouseHover(object sender, System.EventArgs e)
        {
            var pBox = (PictureBox)sender;
            var achievement = (Achievement)pBox.Tag;
            var toolTipText = $"[{achievement.GlobalPercentage}%] {achievement.Name}";

            if (achievement.Description.Length > 0)
            {
                toolTipText += $": { achievement.Description} ";
            }

            ToolTipDescription.Text = toolTipText;

            ToolTipMiddle.Size = new Size((int)(toolTipText.Length * ToolTipDescription.Font.Size * 3 / 5), ToolTipMiddle.Size.Height);

            var toolTipLocation = new Point(pBox.Location.X + (ImageSize * 3 / 4), pBox.Location.Y + (ImageSize - 10));

            // Outside of bounds
            if (toolTipLocation.X + ToolTipEdgeLeft.Width + ToolTipMiddle.Width + ToolTipEdgeRight.Width > this.Width)
            {
                toolTipLocation.X = pBox.Location.X - ToolTipMiddle.Width;
            }

            ToolTipMiddle.Location = toolTipLocation;
            ToolTipEdgeRight.Location = new Point(ToolTipMiddle.Location.X + ToolTipMiddle.Size.Width - 10, ToolTipMiddle.Location.Y);
            ToolTipMiddle.Visible = true;
            ToolTipEdgeRight.BringToFront();
            ToolTipEdgeRight.Visible = true;
        }

        private void pictureBox_MouseLeave(object sender, System.EventArgs e)
        {
            ToolTipMiddle.Visible = false;
            ToolTipEdgeRight.Visible = false;
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

        private void FormStream_Load(object sender, EventArgs e)
        {
            ToolTipDescription.Parent = ToolTipMiddle;
            ToolTipEdgeLeft.Parent = ToolTipMiddle;
            ToolTipDescription.BackColor = Color.Transparent;
        }
    }
}
