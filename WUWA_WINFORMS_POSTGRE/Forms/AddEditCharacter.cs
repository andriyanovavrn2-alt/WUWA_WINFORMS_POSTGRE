using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WUWA_WINFORMS_POSTGRE.Forms
{
    public partial class AddEditCharacter : Form
    {
        public int Id { get; set; }
        public string Photo { get; set; }
        public string NameChar { get; set; }
        public AddEditCharacter(int id, string name_char, string photo)
        {
            InitializeComponent();
            Id = id;
            Photo = photo;
            NameChar = name_char;
        }
    }
}
