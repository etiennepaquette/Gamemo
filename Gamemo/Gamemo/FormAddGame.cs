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
    public partial class FormAddGame : Form
    {
        List<Game> ownedGames;
        FormMain formMain;

        public FormAddGame(FormMain formMain)
        {
            InitializeComponent();
            this.formMain = formMain;
        }

        private void btnAddRandomGame_Click(object sender, EventArgs e)
        {
            GameList.AddGame(textBoxGameName.Text);
            this.formMain.UpdateGameList();
        }

        private void btnFetchGameList_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This may take some times depending of the number of games in your library.");

            comboBoxGameList.Items.Clear();
            SteamManager.SetSteamUser(76561198000133291);

            ownedGames = SteamManager.GetOwnedGames();

            foreach (Game game in ownedGames) {
                comboBoxGameList.Items.Add(game.Name);
            }

            MessageBox.Show("DONE");
        }

        private void btnAddSteamGame_Click(object sender, EventArgs e)
        {
            string gameName = comboBoxGameList.SelectedItem.ToString();
            Game g = ownedGames.Find(x => x.Name == gameName);
            if (g != null) {
                GameList.AddGame(g.AppID, g.Name);
            }
            this.formMain.UpdateGameList();
        }
    }
}
