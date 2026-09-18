using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WUWA_WINFORMS_POSTGRE
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
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

        private void CharactersShow_Click(object sender, EventArgs e)
        {
            using (var db = new AppDbContext())
            {
                foreach(var character in db.Character.AsNoTracking().Include(character => character.Weapon).Include(character => character.Role).Include(character => character.Element).Include(character => character.Rarity))
                {

                }

            }
        }
    }
}
