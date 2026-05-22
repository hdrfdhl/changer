namespace changer2015
{
    partial class gasah
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnback = new System.Windows.Forms.Button();
            this.btnpf = new System.Windows.Forms.Button();
            this.btndownload = new System.Windows.Forms.Button();
            this.btnprocess = new System.Windows.Forms.Button();
            this.btnhps = new System.Windows.Forms.Button();
            this.colnama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colsize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colaksi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.radiogabung = new System.Windows.Forms.RadioButton();
            this.radiopisah = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(440, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(468, 56);
            this.label3.TabIndex = 19;
            this.label3.Text = "GASAH CHANGER";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colnama,
            this.colsize,
            this.colaksi});
            this.dataGridView1.Location = new System.Drawing.Point(373, 320);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(603, 150);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(508, 285);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(96, 29);
            this.btnback.TabIndex = 22;
            this.btnback.Text = "Kembali";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnpf
            // 
            this.btnpf.Location = new System.Drawing.Point(373, 285);
            this.btnpf.Name = "btnpf";
            this.btnpf.Size = new System.Drawing.Size(96, 29);
            this.btnpf.TabIndex = 21;
            this.btnpf.Text = "Pilih File";
            this.btnpf.UseVisualStyleBackColor = true;
            this.btnpf.Click += new System.EventHandler(this.btnpf_Click);
            // 
            // btndownload
            // 
            this.btndownload.Location = new System.Drawing.Point(819, 189);
            this.btndownload.Name = "btndownload";
            this.btndownload.Size = new System.Drawing.Size(119, 29);
            this.btndownload.TabIndex = 24;
            this.btndownload.Text = "Download";
            this.btndownload.UseVisualStyleBackColor = true;
            this.btndownload.Visible = false;
            this.btndownload.Click += new System.EventHandler(this.btndownload_Click);
            // 
            // btnprocess
            // 
            this.btnprocess.Location = new System.Drawing.Point(691, 189);
            this.btnprocess.Name = "btnprocess";
            this.btnprocess.Size = new System.Drawing.Size(96, 29);
            this.btnprocess.TabIndex = 23;
            this.btnprocess.Text = "Process";
            this.btnprocess.UseVisualStyleBackColor = true;
            this.btnprocess.Click += new System.EventHandler(this.btnprocess_Click);
            // 
            // btnhps
            // 
            this.btnhps.Location = new System.Drawing.Point(857, 285);
            this.btnhps.Name = "btnhps";
            this.btnhps.Size = new System.Drawing.Size(119, 29);
            this.btnhps.TabIndex = 25;
            this.btnhps.Text = "Hapus Semua";
            this.btnhps.UseVisualStyleBackColor = true;
            this.btnhps.Click += new System.EventHandler(this.btnhps_Click);
            // 
            // colnama
            // 
            this.colnama.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colnama.HeaderText = "Nama";
            this.colnama.Name = "colnama";
            this.colnama.ReadOnly = true;
            // 
            // colsize
            // 
            this.colsize.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colsize.HeaderText = "Size";
            this.colsize.Name = "colsize";
            this.colsize.ReadOnly = true;
            this.colsize.Width = 64;
            // 
            // colaksi
            // 
            this.colaksi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colaksi.HeaderText = "Aksi";
            this.colaksi.Name = "colaksi";
            this.colaksi.ReadOnly = true;
            this.colaksi.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colaksi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colaksi.Width = 63;
            // 
            // radiogabung
            // 
            this.radiogabung.AutoSize = true;
            this.radiogabung.Location = new System.Drawing.Point(561, 177);
            this.radiogabung.Name = "radiogabung";
            this.radiogabung.Size = new System.Drawing.Size(103, 21);
            this.radiogabung.TabIndex = 26;
            this.radiogabung.TabStop = true;
            this.radiogabung.Text = "Gabungkan";
            this.radiogabung.UseVisualStyleBackColor = true;
            // 
            // radiopisah
            // 
            this.radiopisah.AutoSize = true;
            this.radiopisah.Location = new System.Drawing.Point(561, 210);
            this.radiopisah.Name = "radiopisah";
            this.radiopisah.Size = new System.Drawing.Size(87, 21);
            this.radiopisah.TabIndex = 27;
            this.radiopisah.TabStop = true;
            this.radiopisah.Text = "Pisahkan";
            this.radiopisah.UseVisualStyleBackColor = true;
            // 
            // gasah
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.radiopisah);
            this.Controls.Add(this.radiogabung);
            this.Controls.Add(this.btnhps);
            this.Controls.Add(this.btndownload);
            this.Controls.Add(this.btnprocess);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnpf);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Name = "gasah";
            this.Text = "Gabung dan Pisah PDF";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnpf;
        private System.Windows.Forms.Button btndownload;
        private System.Windows.Forms.Button btnprocess;
        private System.Windows.Forms.Button btnhps;
        private System.Windows.Forms.DataGridViewTextBoxColumn colnama;
        private System.Windows.Forms.DataGridViewTextBoxColumn colsize;
        private System.Windows.Forms.DataGridViewButtonColumn colaksi;
        private System.Windows.Forms.RadioButton radiogabung;
        private System.Windows.Forms.RadioButton radiopisah;
    }
}