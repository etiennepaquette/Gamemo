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
        string fileName = String.Format(@"{0}\gameList.json", Application.StartupPath);

        public FormMain()
        {
            InitializeComponent();

            SteamManager.Init();

            if (File.Exists(fileName)) {
                LoadGameList();
            }
        }

        public void AddGame(string name) {
            GameList.AddGame(name);
            UpdateGameList();
        }

        private void LoadGameList() {
            GameList.Load(fileName);
            UpdateGameList();
        }

        private void UpdateGameList() {
            listBoxGames.Items.Clear();
            foreach (string name in GameList.GetAllGameNames()) {
                listBoxGames.Items.Add(name);
            }
        }

        private void buttonAddGame_Click(object sender, EventArgs e)
        {
            FormAddGame f = new FormAddGame(this);
            f.Show();
        }

        private void btnDeleteGame_Click(object sender, EventArgs e)
        {
            GameList.RemoveGame(listBoxGames.SelectedItem.ToString());
            textBoxGameMemo.Text = "";
            UpdateGameList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            GameList.Save(fileName);
        }

        private void listBoxGames_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!textBoxGameMemo.Enabled)
                textBoxGameMemo.Enabled = true;
            textBoxGameMemo.Text = GameList.GetGameMemo(listBoxGames.SelectedItem.ToString());
        }

        private void textBoxGameMemo_LostFocus(object sender, EventArgs e)
        {
            GameList.UpdateGameMemo(listBoxGames.SelectedItem.ToString(), textBoxGameMemo.Text);
            GameList.Save(fileName);
        }
    }
}
