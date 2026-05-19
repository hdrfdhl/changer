using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace changer2015
{
    public partial class pe : UserControl
    {
        public pe()
        {
            InitializeComponent();
            pictureBox1.Click += (s, e) => this.OnClick(e);
            label1.Click += (s, e) => this.OnClick(e);
        }
    }
}
