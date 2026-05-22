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
using System.IO;

namespace changer2015
{
    public partial class gasah : Form
    {
        string hasilmerge = "";
        string hasilsplit = "";
        public gasah()
        {
            InitializeComponent();
        }

        private void gasah_Load(object sender, EventArgs e)
        {
            if (dataGridView1.Columns.Count >= 3)
            {
                dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Nama
                dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; // Size
                dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells; // Aksi
            }

            radiogabung.Checked = true;
            btndownload.Visible = false;
        }

        private void btnpf_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Pilih File PDF";
            openFile.Multiselect = true;
            openFile.Filter = "PDF Files (*.pdf)|*.pdf";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                foreach (string fileBaru in openFile.FileNames)
                {
                    bool sudahAda = false;
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.Tag != null && row.Tag.ToString() == fileBaru)
                        {
                            sudahAda = true;
                            break;
                        }
                    }

                    if (!sudahAda)
                    {
                        FileInfo infoFile = new FileInfo(fileBaru);
                        long ukuranKB = infoFile.Length / 1024;

                        int rowIndex = dataGridView1.Rows.Add(Path.GetFileName(fileBaru), ukuranKB + " KB", "X");

                        dataGridView1.Rows[rowIndex].Tag = fileBaru;
                    }
                }
                btndownload.Visible = false;
                btnprocess.Text = "Process";
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 2)
            {
                dataGridView1.Rows.RemoveAt(e.RowIndex);
                btndownload.Visible = false;
            }
        }

        private void btnhps_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            btndownload.Visible = false;
            btnprocess.Text = "Process";
        }

        private async void btnprocess_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Pilih file PDF-nya dulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            btnprocess.Text = "Processing...";
            btnprocess.Enabled = false;
            Application.DoEvents();

            try
            {
                if (radiogabung.Checked)
                {
                    if (dataGridView1.Rows.Count < 2)
                    {
                        MessageBox.Show("Minimal harus ada 2 file buat digabungin!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        ResetTombolProcess();
                        return;
                    }

                    string[] listFile = new string[dataGridView1.Rows.Count];
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        listFile[i] = dataGridView1.Rows[i].Tag.ToString();
                    }

                    PdfDocumentBase docMerge = PdfDocument.MergeFiles(listFile);
                    hasilmerge = Path.Combine(Path.GetTempPath(), "Merged_" + DateTime.Now.Ticks + ".pdf");
                    docMerge.Save(hasilmerge, FileFormat.PDF);

                    MessageBox.Show("Berhasil digabungkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (radiopisah.Checked)
                {
                    string fileToSplit = dataGridView1.Rows[0].Tag.ToString();
                    PdfDocument docSplit = new PdfDocument(fileToSplit);

                    hasilsplit = Path.Combine(Path.GetTempPath(), "Split_" + DateTime.Now.Ticks);
                    Directory.CreateDirectory(hasilsplit);

                    String pattern = Path.Combine(hasilsplit, "Page-{0}.pdf");
                    docSplit.Split(pattern, 0);

                    MessageBox.Show("Berhasil dipisahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                btnprocess.Text = "Selesai";
                btndownload.Visible = true;
                btnprocess.Enabled = true;

                await Task.Delay(2000);
                if (!this.IsDisposed)
                {
                    btnprocess.Text = "Process";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Proses gagal: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ResetTombolProcess();
            }
            btnprocess.Enabled = true;
        }

        private void ResetTombolProcess()
        {
            btnprocess.Text = "Process";
            btnprocess.Enabled = true;
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            main back = new main();
            back.Show();
            this.Hide();
        }

        private void btndownload_Click(object sender, EventArgs e)
        {
            if (radiogabung.Checked)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Title = "Simpan File Gabungan";
                save.Filter = "PDF Files (*.pdf)|*.pdf";
                save.FileName = "Hasil_Gabungan.pdf";

                if (save.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        File.Copy(hasilmerge, save.FileName, true);
                        MessageBox.Show("File berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Gagal menyimpan: " + ex.Message);
                    }
                }
            }
            else if (radiopisah.Checked)
            {
                FolderBrowserDialog folder = new FolderBrowserDialog();
                folder.Description = "Pilih folder untuk menyimpan file-file PDF yang sudah dipisah";

                if (folder.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string[] files = Directory.GetFiles(hasilsplit);
                        foreach (string file in files)
                        {
                            string destFile = Path.Combine(folder.SelectedPath, Path.GetFileName(file));
                            File.Copy(file, destFile, true);
                        }
                        MessageBox.Show("Semua file pecahan berhasil disimpan di folder tersebut!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Gagal menyimpan: " + ex.Message);
                    }
                }
            }
        }
    }
}
