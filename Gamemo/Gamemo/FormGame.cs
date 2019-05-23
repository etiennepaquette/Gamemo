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
    public partial class FormGame : Form
    {
        string GameName;

        public FormGame(string gameName)
        {
            InitializeComponent();
            GameName = gameName;
            labelGameName.Text = GameName;
            textBoxGameMemo.Text = GameList.GetGameMemo(GameName);
            if (GameList.IsSteamGame(GameName)) {
                BtnAchievements.Enabled = true;
            }
        }

        private void textBoxGameMemo_LostFocus(object sender, EventArgs e)
        {
            GameList.UpdateGameMemo(GameName, textBoxGameMemo.Text);
            GameList.Save();
        }

        private void BtnAchievements_Click(object sender, EventArgs e)
        {

        }
    }
}
