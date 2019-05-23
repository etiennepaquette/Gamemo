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
        public FormAddGame()
        {
            InitializeComponent();
        }

        private FormMain mainForm = null;
        public FormAddGame(Form callingForm) {
            mainForm = callingForm as FormMain;
            InitializeComponent();
        }

        private void btnAddRandomGame_Click(object sender, EventArgs e)
        {
            this.mainForm.AddGame(textBoxGameName.Text);
        }

        private void btnFetchGameList_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This may take some times depending of the amount of games in your library.");

            comboBoxGameList.Items.Clear();
            SteamManager.SetSteamUser(76561198000133291);

            List<Game> ownedGames = SteamManager.GetOwnedGames();

            foreach (Game game in ownedGames) {
                comboBoxGameList.Items.Add(game.Name);
            }

            MessageBox.Show("DONE");
        }

        private void btnAddSteamGame_Click(object sender, EventArgs e)
        {
            string gameName = comboBoxGameList.SelectedItem.ToString();
            this.mainForm.AddGame(gameName);
        }
    }
}
