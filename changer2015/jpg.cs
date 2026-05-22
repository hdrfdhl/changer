using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Spire.Pdf;
using System.Drawing.Imaging;
using System.IO;
using Spire.Pdf.Graphics;

namespace changer2015
{
    public partial class jpg : Form
    {
        string asli = "";
        string hasil = "";
        public jpg()
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
                cmbto.Text = "JPG";
                label2.Visible = false;
                webBrowser1.Visible = true;
                webBrowser1.Navigate(source + "#view=Fit");
            }
            else if (ekstensi == ".jpg" || ekstensi == ".jpeg")
            {
                cmbfrom.Text = "JPG";
                cmbto.Text = "PDF";
                label2.Visible = false;
                webBrowser1.Visible = true;
                webBrowser1.Navigate(source);
            }

            btndownload.Visible = false;
            btnconvert.Text = "Convert";
        }

        private void btnpf_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Title = "Pilih File";

            openfile.Filter = "PDF Files (*.pdf)|*.pdf|JPG Files (*.jpg, *.jpeg)|*.jpg;*.jpeg|Semua File (*.*)|*.*";

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

        private void btnback_Click(object sender, EventArgs e)
        {
            main back = new changer2015.main();
            back.Show();
            this.Hide();
        }

        private void panel1_DragEnter_1(object sender, DragEventArgs e)
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

        private void btnconvert_Click(object sender, EventArgs e)
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
                    PdfDocument docpdf = new PdfDocument();
                    docpdf.LoadFromFile(asli);
                    Image bmp = docpdf.SaveAsImage(0);
                    hasil = Path.Combine(Path.GetTempPath(), "hasil_convert_" + DateTime.Now.Ticks + ".jpg");
                    bmp.Save(hasil, ImageFormat.Jpeg);
                }
                else if (cmbfrom.Text == "JPG")
                {
                    PdfDocument docpdf = new PdfDocument();
                    PdfImage img = PdfImage.FromFile(asli);

                    PdfPageBase page = docpdf.Pages.Add(new SizeF(img.Width, img.Height), new PdfMargins(0));
                    page.Canvas.DrawImage(img, 0, 0, img.Width, img.Height);

                    hasil = Path.Combine(Path.GetTempPath(), "hasil_convert_" + DateTime.Now.Ticks + ".pdf");
                    docpdf.SaveToFile(hasil);
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

        private void btndownload_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Simpan file convert";

            if (cmbto.Text == "JPG")
            {
                save.Filter = "JPEG Image (*.jpg)|*.jpg";
                save.DefaultExt = "jpg";
                save.FileName = Path.GetFileNameWithoutExtension(asli) + "_converted.jpg";
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
                    MessageBox.Show("Gagal menyimpan: " + ex.Message);
                }
            }
        }
    }
}
