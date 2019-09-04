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
    public partial class FormAddNewGame : Form
    {
        List<Game> ownedGames;

        public FormAddNewGame(long steamID)
        {
            InitializeComponent();
            SteamManager.Init(steamID);
            if (SteamManager.IsSteamProfile) {
                BtnFetchGameList.Enabled = true;
                comboBoxGameList.Enabled = true;
                BtnAddSteamGame.Enabled = true;
            }
        }

        private void BtnAddGame_Click(object sender, EventArgs e)
        {
            if (textBoxGameName.Text != "") {
                GameList.AddGame(textBoxGameName.Text);
                textBoxGameName.Text = "";
                this.Close();
            }
        }

        private void BtnFetchGameList_Click(object sender, EventArgs e)
        {
            ownedGames = SteamManager.GetOwnedGames();

            comboBoxGameList.Items.Clear();
            foreach (Game game in ownedGames) {
                comboBoxGameList.Items.Add(game.Name);
            }
            comboBoxGameList.SelectedIndex = 0;
        }

        private void BtnAddSteamGame_Click(object sender, EventArgs e)
        {
            string gameName = comboBoxGameList.SelectedItem.ToString();
            Game g = ownedGames.Find(x => x.Name == gameName);
            if (g != null) {
                GameList.AddSteamGame(g.AppID, g.Name);
                comboBoxGameList.SelectedIndex = -1;
            }
            this.Close();
        }
    }
}
