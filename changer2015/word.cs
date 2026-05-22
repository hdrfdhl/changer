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
using Spire.Doc;

namespace changer2015
{
    public partial class word : Form
    {
        string asli = "";
        string hasil = "";
        public word()
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
                cmbto.Text = "Word";
                label2.Visible = false;
                webBrowser1.Visible = true;
                webBrowser1.Navigate(source + "#view=Fit");
            }
            else if (ekstensi == ".doc" || ekstensi == ".docx")
            {
                cmbfrom.Text = "Word";
                cmbto.Text = "PDF";
                webBrowser1.Visible = false;
                label2.Text = "File Word siap di-convert!";
                label2.Visible = true;
            }

            btndownload.Visible = false;
            btnconvert.Text = "Convert";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Title = "Pilih File";

            openfile.Filter = "PDF Files (*.pdf)|*.pdf|Word Files (*.docx, *.doc)|*.docx;*.doc|Semua File (*.*)|*.*";

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

        private void button3_Click(object sender, EventArgs e)
        {
            if (asli == "")
            {
                MessageBox.Show("Masukkan file terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            btnconvert.Text = "Converting...";
            btnconvert.Enabled = false;
            Application.DoEvents();

            try
            {
                if (cmbfrom.Text == "PDF")
                {
                    Spire.Pdf.PdfDocument docpdf = new Spire.Pdf.PdfDocument();
                    docpdf.LoadFromFile(asli);
                    hasil = Path.Combine(Path.GetTempPath(), "hasil_convert_" + DateTime.Now.Ticks + ".docx");
                    docpdf.SaveToFile(hasil, Spire.Pdf.FileFormat.DOCX);
                }
                else if (cmbfrom.Text == "Word")
                {
                    Spire.Doc.Document docword = new Spire.Doc.Document();
                    docword.LoadFromFile(asli);
                    hasil = Path.Combine(Path.GetTempPath(), "hasil_convert_" + DateTime.Now.Ticks + ".pdf");
                    docword.SaveToFile(hasil, Spire.Doc.FileFormat.PDF);
                }

                MessageBox.Show("File berhasil di-convert!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnconvert.Text = "Selesai";
                btndownload.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Convert gagal" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnconvert.Text = "Convert";
            }
            btnconvert.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Simpan file convert";

            if (cmbto.Text == "Word")
            {
                save.Filter = "Word Document (*.docx)|*.docx";
                save.DefaultExt = "docx";
                save.FileName = Path.GetFileNameWithoutExtension(asli) + "_converted.docx";
            }
            else
            {
                save.Filter = "Adobe Acrobat Document (*.pdf)|*.pdf";
                save.DefaultExt = "pdf";
                save.FileName = Path.GetFileNameWithoutExtension(asli) + "_converted.pdf";
            }

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
            string sw = cmbfrom.Text;
            cmbfrom.Text = cmbto.Text;
            cmbto.Text = sw;
        }

    }
}
