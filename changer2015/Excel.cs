using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Spire.Pdf;
using Spire.Xls;

namespace changer2015
{
    public partial class Excel : Form
    {
        string asli = "";
        //string hasil = "";
        public Excel()
        {
            InitializeComponent();
        }

        private void preview(string source)
        {
            asli = source;
            string ekstensi = Path.GetExtension(source).ToLower();

            if (ekstensi == ".pdf")
            {
                cmbfrom.Text = "PDF";
                cmbto.Text = "Excel";
                label2.Visible = false;
                webBrowser1.Visible = true;
                webBrowser1.Navigate(source + "#view=Fit");
            }
            else if (ekstensi == ".xls" || ekstensi == ".xlsx")
            {
                cmbfrom.Text = "Excel";
                cmbto.Text = "PDF";
                webBrowser1.Visible = false;
                label2.Text = "File Excel siap di-convert!";
                label2.Visible = true;
            }

            btndownload.Visible = false;
            btnconvert.Text = "Convert";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Title = "Pilih File";

            openfile.Filter = "PDF Files (*.pdf)|*.pdf|Excel Files (*.xlsx, *.xls)|*.xlsx;*.xls|Semua File (*.*)|*.*";

            if (openfile.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = Path.GetFileName(openfile.FileName);
                preview(openfile.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            main back = new changer2015.main();
            back.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string sw = cmbfrom.Text;
            cmbfrom.Text = cmbto.Text;
            cmbto.Text = sw;
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            string[] daftarfile = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (daftarfile.Length > 0)
            {
                textBox1.Text = Path.GetFileName(daftarfile[0]);
                preview(daftarfile[0]);
            }
        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void btnconvert_Click(object sender, EventArgs e)
        {

        }
    }
}
