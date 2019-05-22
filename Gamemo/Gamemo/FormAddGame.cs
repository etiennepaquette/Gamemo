using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fluxter.SteamWebAPI;
using Fluxter.SteamWebAPI.Interfaces.General.IPlayerService.GetOwnedGames;
using Fluxter.SteamWebAPI.Interfaces.General.ISteamApps.GetAppList;
using Fluxter.SteamWebAPI.Interfaces.General.ISteamUser.GetFriendList;

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
            comboBoxGameList.Items.Clear();
            SteamIdentity user = SteamIdentity.FromSteamID(76561198000133291);

            var appListResponse = SteamWebAPI.General().ISteamApps().GetAppList().GetResponse();
            List<App> appList = appListResponse.Data.Apps;

            var gameListResponse = SteamWebAPI.General().IPlayerService().GetOwnedGames(user).GetResponse();
            List<GetOwnedGamesResponseGame> gameList = gameListResponse.Data.Games;
            foreach (GetOwnedGamesResponseGame g in gameList) {
                string gameName = appList.Find(item => item.AppID == g.AppID).Name;

                if (gameName != null) {
                    comboBoxGameList.Items.Add(gameName);
                }
            }

            MessageBox.Show("DONE");
        }
    }
}
