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
    }
}
