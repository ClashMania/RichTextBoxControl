using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RichTextBoxControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrisi_Click(object sender, EventArgs e)
        {
            rtxtbox.Clear();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            rtxtbox.SaveFile(@"C:TempProba.rtf");
        }

        private void btnCitaj_Click(object sender, EventArgs e)
        {
            rtxtbox.LoadFile(@"C:TempProba.rtf");
        }
    }
}
