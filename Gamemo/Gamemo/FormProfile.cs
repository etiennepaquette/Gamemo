using Newtonsoft.Json;
using System;
using System.Collections.Generic;
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
    public partial class FormProfile : Form
    {
        private readonly string FileName = String.Format(@"{0}\Profiles.json", Application.StartupPath);
        private List<Profile> Profiles = new List<Profile>();

        public FormProfile()
        {
            InitializeComponent();
            LoadProfiles();
        }

        public void CreateProfile(string name, string steamID)
        {
            long id = steamID != "" ? long.Parse(steamID) : 0;
            Profiles.Add(new Profile(name, id));
            File.WriteAllText(FileName, JsonConvert.SerializeObject(Profiles, Formatting.Indented));
            LoadProfiles();
        }

        public void LoadProfiles()
        {
            if (File.Exists(FileName)) {
                Profiles = JsonConvert.DeserializeObject<List<Profile>>(File.ReadAllText(FileName));
                listBoxProfileNames.Items.Clear();
                foreach (Profile p in Profiles) {
                    listBoxProfileNames.Items.Add(p.Name);
                }
                listBoxProfileNames.SelectedIndex = 0;
            }
        }

        private void BtnOpenProfile_Click(object sender, EventArgs e){
            Profile p = Profiles.Where(x => x.Name == listBoxProfileNames.SelectedItem.ToString()).First();
            this.Hide();
            FormMain f = new FormMain(p.Name, p.SteamID);
            f.Show();
        }

        private void BtnCreateProfile_Click(object sender, EventArgs e){
            CreateProfile(textBoxProfileName.Text, textBoxSteamID.Text);
        }
        
    }
}
