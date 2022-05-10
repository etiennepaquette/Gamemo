using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gamemo
{
    public partial class FormMain : Form
    {
        private string ProfileName;
        private long ProfileSteamID;

        public FormMain() {
            InitializeComponent();
            LoadProfile();
            LoadGameList();
        }

        private void LoadProfile() {
            string fileName = Application.StartupPath + "/Profile.json";

            if (!File.Exists(fileName)) {
                FormProfile f = new FormProfile();
                f.ShowDialog();
            }

            List<Profile> profiles = JsonConvert.DeserializeObject<List<Profile>>(File.ReadAllText(fileName));
            // TODO: Deal with multiple profiles
            ProfileName = profiles.First<Profile>().Name;
            ProfileSteamID = profiles.First<Profile>().SteamID;
        }

        private void LoadGameList() {
            GameList.Load(ProfileName);
            UpdateGameList();
        }

        public void UpdateGameList() {
            listBoxGames.Items.Clear();
            foreach (string name in GameList.GetAllGameNames()) {
                listBoxGames.Items.Add(name);
            }
            if (listBoxGames.Items.Count > 0) {
                listBoxGames.SelectedIndex = 0;
            } else {
                TxtBoxGameMemo.Text = "";
                TxtBoxGameMemo.Enabled = false;
            }
            GameList.Save(ProfileName);
        }

        private void btnDeleteGame_Click(object sender, EventArgs e)
        {
            GameList.RemoveGame(listBoxGames.SelectedItem.ToString());
            UpdateGameList();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (listBoxGames.SelectedIndex >= 0) {
                GameList.UpdateGameMemo(listBoxGames.SelectedItem.ToString(), TxtBoxGameMemo.Text);
                GameList.Save(ProfileName);
            }
            Application.Exit();
        }

        private void listBoxGames_SelectedIndexChanged(object sender, EventArgs e)
        {
            string gameName = listBoxGames.SelectedItem.ToString();
            TxtBoxGameMemo.Enabled = true;
            TxtBoxGameMemo.Text = GameList.GetGameMemo(gameName);
            if (GameList.IsSteamGame(gameName)) {
                BtnGameAchievements.Enabled = GameList.GetAchievementsCounts(gameName) > 0 ? true : false;
            }
        }

        private void TxtBoxGameMemo_Leave(object sender, EventArgs e)
        {
            GameList.UpdateGameMemo(listBoxGames.SelectedItem.ToString(), TxtBoxGameMemo.Text);
            GameList.Save(ProfileName);
        }

        private void BtnGameAchievements_Click(object sender, EventArgs e)
        {
            FormAchievements f = new FormAchievements(listBoxGames.SelectedItem.ToString());
            f.ShowDialog();
        }

        private void ToolStripMenuItemAddNewGame_Click(object sender, EventArgs e)
        {
            FormAddNewGame f = new FormAddNewGame(ProfileSteamID);
            f.ShowDialog();
            UpdateGameList();
            listBoxGames.SelectedIndex = listBoxGames.Items.Count - 1;
        }
    }
}
