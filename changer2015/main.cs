using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace changer2015
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void pw1_Load(object sender, EventArgs e)
        {

        }

        private void pw1_Click(object sender, EventArgs e)
        {
            word word = new word();
            word.Show();
            this.Hide();
        }

        private void pp1_Click(object sender, EventArgs e)
        {
            gasah gasah = new gasah();
            gasah.Show();
            this.Hide();
        }

        private void pe1_Click(object sender, EventArgs e)
        {
            Excel excel = new Excel();
            excel.Show();
            this.Hide();
        }

        private void pj1_Click(object sender, EventArgs e)
        {
            jpg jpg = new jpg();
            jpg.Show();
            this.Hide();
        }
    }
}
