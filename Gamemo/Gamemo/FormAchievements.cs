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
    public partial class FormAchievements : Form
    {
        private string GameName;
        private List<Achievement> achievementsList;

        public FormAchievements(string gameName)
        {
            InitializeComponent();
            GameName = gameName;
            achievementsList = GameList.GetAchievements(GameName);
            ShowAchievList();
        }

        private void ShowAchievList() {
            listBoxAchievements.Items.Clear();
            foreach (Achievement a in achievementsList) {
                listBoxAchievements.Items.Add(a.Name);
                if (a.Memo != null && a.Memo != "") {
                    
                }
            }
            listBoxAchievements.SelectedIndex = 0;
        }

        private void listBoxAchievements_SelectedIndexChanged(object sender, EventArgs e){
            int listIndex = listBoxAchievements.SelectedIndex;
            if (listIndex >= 0) {
                labelAchievName.Text = achievementsList.ElementAt(listIndex).Name + " (Global Percent: " + achievementsList.ElementAt(listIndex).GlobalPercentage + "%)";
                labelAchievDesc.Text = achievementsList.ElementAt(listIndex).Description;
                pictureBoxIcon.ImageLocation = achievementsList.ElementAt(listIndex).Icon;
                textBoxAchievMemo.Text = achievementsList.ElementAt(listIndex).Memo;
            }
        }

        private void textBoxGameMemo_LostFocus(object sender, EventArgs e)
        {
            int listIndex = listBoxAchievements.SelectedIndex;
            achievementsList.ElementAt(listIndex).Memo = textBoxAchievMemo.Text;
            GameList.UpdateGameAchiev(GameName, achievementsList);
            GameList.Save("Daisuke");
        }

        private void BtnDeleteAchieve_Click(object sender, EventArgs e)
        {
            int index = listBoxAchievements.SelectedIndex;
            string achieveName = listBoxAchievements.SelectedItem.ToString();
            GameList.DeleteAchieve(GameName, achieveName);
            ShowAchievList();
            listBoxAchievements.SelectedIndex = index - 1;
        }

        private void listBoxAchievements_DrawItem(object sender, DrawItemEventArgs e)
        {
            Brush myBrush = Brushes.Black;
            string achieveName = listBoxAchievements.Items[e.Index].ToString();
            if (GameList.DoesAchieveGotMemo(GameName, achieveName)) {
                myBrush = Brushes.YellowGreen;
            }

            e.DrawBackground();
            e.Graphics.DrawString(listBoxAchievements.Items[e.Index].ToString(), listBoxAchievements.Font, myBrush, e.Bounds);
            /*foreach (ListBox.ObjectCollection i in listBoxAchievements.Items) {

            }*/
        }
    }
}
