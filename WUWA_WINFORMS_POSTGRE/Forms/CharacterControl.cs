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

namespace WUWA_WINFORMS_POSTGRE.Forms
{
    public partial class CharacterControl : UserControl
    {
        public int IdChar { get; set; }
        public string NameChar { get; set; }
        public string Picture { get; set; }

        public CharacterControl()
        {
            InitializeComponent();
        }
        public void SetChar()
        {
            pictureBox1.ImageLocation = Path.Combine(Application.StartupPath, "image") + "\\" + Picture;
            labelNameChar.Text = NameChar;
        }

        private void info_Click(object sender, EventArgs e)
        {
            AddEditCharacter addEditCharacter = new AddEditCharacter(IdChar, NameChar, Picture);
            addEditCharacter.ShowDialog();
        }
    }
}
