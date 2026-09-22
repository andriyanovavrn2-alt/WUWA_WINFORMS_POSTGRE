using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WUWA_WINFORMS_POSTGRE.Forms;

namespace WUWA_WINFORMS_POSTGRE
{
    public partial class MainForm : Form
    {


        public MainForm()
        {
            InitializeComponent();
        }


        private void CharactersShow_Click(object sender, EventArgs e)
        {
            using (var db = AppDbContextFactory.Create())
            {
                flowLayoutPanel1.Controls.Clear();
                var characters = db.Character
                    .AsNoTracking() // только для чтения
                    .ToList();
                foreach(var character in characters)
                {
                    var card = new CharacterControl();
                    card.IdChar = character.CharacterId;
                    card.Picture = character.Photo;
                    card.SetChar();
                    flowLayoutPanel1.Controls.Add(card);
                }

            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void txt_poisk_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }

        
    }
}
