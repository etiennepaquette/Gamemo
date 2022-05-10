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
        private readonly string FileName = String.Format(@"{0}\Profile.json", Application.StartupPath);
        private List<Profile> Profiles = new List<Profile>();

        public FormProfile()
        {
            InitializeComponent();
        }

        public void CreateProfile(string name, string steamID)
        {
            long id = steamID != "" ? long.Parse(steamID) : 0;
            Profiles.Add(new Profile(name, id));
            File.WriteAllText(FileName, JsonConvert.SerializeObject(Profiles, Formatting.Indented));
        }

        private void BtnCreateProfile_Click(object sender, EventArgs e){
            CreateProfile(textBoxProfileName.Text, textBoxSteamID.Text);
            this.Close();
        }
    }
}
