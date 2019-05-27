using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gamemo
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            SteamManager.Init();
        
            LoadGameList();
        }

        private void LoadGameList() {
            GameList.Load();
            UpdateGameList();
        }

        public void UpdateGameList() {
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
            UpdateGameList();
            BtnMemo.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            GameList.Save();
        }

        private void BtnMemo_Click(object sender, EventArgs e)
        {
            FormGame f = new FormGame(listBoxGames.SelectedItem.ToString());
            f.Show();
        }

        private void listBoxGames_SelectedIndexChanged(object sender, EventArgs e)
        {
            BtnMemo.Enabled = true;
        }
    }
}
