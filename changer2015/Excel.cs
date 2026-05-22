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
        string hasil = "";
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
                    // --- LOGIC PDF TO EXCEL (GABUNG SHEET 1) ---
                    PdfDocument docpdf = new PdfDocument();
                    docpdf.LoadFromFile(asli);

                    // Simpan excel acak-acakan dari PDF ke file temp pertama
                    string tempSpireFile = Path.Combine(Path.GetTempPath(), "raw_excel_" + DateTime.Now.Ticks + ".xlsx");
                    docpdf.SaveToFile(tempSpireFile, Spire.Pdf.FileFormat.XLSX);
                    docpdf.Close();

                    // Buka file temp tadi pake Spire.Xls buat digabungin ke Sheet 1
                    Workbook workbook = new Workbook();
                    workbook.LoadFromFile(tempSpireFile);

                    if (workbook.Worksheets.Count > 1)
                    {
                        Worksheet targetSheet = workbook.Worksheets[0]; // Sheet 1
                        for (int i = 1; i < workbook.Worksheets.Count; i++)
                        {
                            Worksheet sourceSheet = workbook.Worksheets[i];
                            int lastRowTarget = targetSheet.LastRow;
                            int lastRowSource = sourceSheet.LastRow;
                            int lastColumnSource = sourceSheet.LastColumn;

                            if (lastRowSource > 0 && lastColumnSource > 0)
                            {
                                CellRange sourceRange = sourceSheet.Range[1, 1, lastRowSource, lastColumnSource];
                                CellRange targetRange = targetSheet.Range[lastRowTarget + 1, 1];
                                sourceSheet.Copy(sourceRange, targetRange, true);
                            }
                        }

                        // Hapus sheet sisanya
                        for (int i = workbook.Worksheets.Count - 1; i >= 1; i--)
                        {
                            workbook.Worksheets.Remove(i);
                        }
                        workbook.Worksheets[0].Name = "All_Data";
                    }

                    // Path FINAL file temp Excel yang udah rapi (variabel global 'hasil' lu)
                    hasil = Path.Combine(Path.GetTempPath(), "hasil_convert_" + DateTime.Now.Ticks + ".xlsx");
                    workbook.SaveToFile(hasil, Spire.Xls.FileFormat.Version2013);
                    workbook.Dispose();

                    // Hapus file raw temp pertama biar ga menuh-menuhin disk
                    if (File.Exists(tempSpireFile)) { File.Delete(tempSpireFile); }
                }
                else if (cmbfrom.Text == "Excel")
                {
                    // --- LOGIC EXCEL TO PDF ---
                    Workbook workbook = new Workbook();
                    workbook.LoadFromFile(asli);

                    hasil = Path.Combine(Path.GetTempPath(), "hasil_convert_" + DateTime.Now.Ticks + ".pdf");
                    workbook.SaveToFile(hasil, Spire.Xls.FileFormat.PDF);
                    workbook.Dispose();
                }

                // Efek UI sesuai request lu
                MessageBox.Show("File berhasil di-convert!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnconvert.Text = "Selesai";
                btndownload.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Convert gagal: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnconvert.Text = "Convert";
            }

            btnconvert.Enabled = true;
        }

        private void btndownload_Click(object sender, EventArgs e)
        {
            // Cek takutan variabel 'hasil' nya kosong atau file temp nya kehapus
            if (string.IsNullOrEmpty(hasil) || !File.Exists(hasil))
            {
                MessageBox.Show("File hasil convert tidak ditemukan di folder Temp!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Simpan file convert";

            if (cmbto.Text == "Excel")
            {
                save.Filter = "Excel Workbook (*.xlsx)|*.xlsx";
                save.DefaultExt = "xlsx";
                save.FileName = Path.GetFileNameWithoutExtension(asli) + "_converted.xlsx";
            }
            else if (cmbto.Text == "PDF")
            {
                save.Filter = "Adobe Acrobat Document (*.pdf)|*.pdf";
                save.DefaultExt = "pdf";
                save.FileName = Path.GetFileNameWithoutExtension(asli) + "_converted.pdf";
            }

            if (save.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Copas file dari folder Temp ke folder pilihan user
                    File.Copy(hasil, save.FileName, true);
                    MessageBox.Show("Download sukses!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal menyimpan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
