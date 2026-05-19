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
            Form1 word = new Form1();
            word.Show();
            this.Hide();
        }
    }
}
