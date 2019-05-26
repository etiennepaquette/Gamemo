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
            foreach (Achievement a in achievementsList) {
                listBoxAchievements.Items.Add(a.Name);
            }
        }

        private void listBoxAchievements_SelectedIndexChanged(object sender, EventArgs e){
            int listIndex = listBoxAchievements.SelectedIndex;
            labelAchievName.Text = achievementsList.ElementAt(listIndex).Name;
            labelAchievDesc.Text = achievementsList.ElementAt(listIndex).Description;
            pictureBoxIcon.ImageLocation = achievementsList.ElementAt(listIndex).Icon;
        }
    }
}
