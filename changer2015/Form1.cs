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

namespace changer2015
{
    public partial class Form1 : Form
    {
        string asli = "";
        string hasil = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void preview(string source)
        {
            asli = source;
            label2.Visible = false;
            webBrowser1.Visible = true;
            webBrowser1.Navigate(source + "#view=Fit");

            string ekstensi = Path.GetExtension(source).ToLower();
            if (ekstensi == ".pdf")
            {
                comboBox1.Text = "PDF";
                comboBox2.Text = "Word";
            }
            else if (ekstensi == ".doc" || ekstensi == ".docx")
            {
                comboBox1.Text = "Word";
                comboBox2.Text = "PDF";
            }

            button4.Visible = false;
            button3.Text = "Convert";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Title = "Pilih File";

            openfile.Filter = "PDF Files (*.pdf)|*.pdf|Word Files (*.docx, *.doc)|*.docx;*.doc|Excel Files (*.xlsx, *.xls)|*.xlsx;*.xls|Semua File (*.*)|*.*";

            if (openfile.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = Path.GetFileName(openfile.FileName);
                preview(openfile.FileName);
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

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            string[] daftarfile = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (daftarfile.Length > 0)
            {
                textBox1.Text = Path.GetFileName(daftarfile[0]);
                preview(daftarfile[0]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            main back = new changer2015.main();
            back.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Simpan file convert";
            save.Filter = "Word Document (*.docx)|*.docx";
            save.DefaultExt = "docx";

            save.FileName = Path.GetFileNameWithoutExtension(asli) + "_converted.docx";

            if (save.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.Copy(hasil, save.FileName, true);
                    MessageBox.Show("Download sukses!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal menyimpan " + ex.Message);
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string sw = comboBox1.Text;
            comboBox1.Text = comboBox2.Text;
            comboBox2.Text = sw;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (asli == "")
            {
                MessageBox.Show("Masukkan file terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            button3.Text = "Converting...";
            button3.Enabled = false;
            Application.DoEvents();

            try
            {
                PdfDocument doc = new PdfDocument();
                doc.LoadFromFile(asli);
                hasil = Path.Combine(Path.GetTempPath(), "hasil_convert_" + DateTime.Now.Ticks + ".docx");
                doc.SaveToFile(hasil, FileFormat.DOCX);
                MessageBox.Show("File berhasil di-convert!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button3.Text = "Selesai";
                button4.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Convert gagal" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                button3.Text = "Convert";
            }
            button3.Enabled = true;
        }
    }
}
