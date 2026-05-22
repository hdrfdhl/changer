namespace changer2015
{
    partial class word
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(word));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnpf = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.label3 = new System.Windows.Forms.Label();
            this.btnback = new System.Windows.Forms.Button();
            this.cmbfrom = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbto = new System.Windows.Forms.ComboBox();
            this.btnconvert = new System.Windows.Forms.Button();
            this.btndownload = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Javanese Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(625, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama File:";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(736, 219);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(313, 22);
            this.textBox1.TabIndex = 1;
            // 
            // btnpf
            // 
            this.btnpf.Location = new System.Drawing.Point(1074, 216);
            this.btnpf.Name = "btnpf";
            this.btnpf.Size = new System.Drawing.Size(96, 29);
            this.btnpf.TabIndex = 2;
            this.btnpf.Text = "Pilih File";
            this.btnpf.UseVisualStyleBackColor = true;
            this.btnpf.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.webBrowser1);
            this.panel1.Location = new System.Drawing.Point(39, 163);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(521, 521);
            this.panel1.TabIndex = 3;
            this.panel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel1_DragDrop);
            this.panel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel1_DragEnter);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(210, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Drop Here";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(521, 521);
            this.webBrowser1.TabIndex = 1;
            this.webBrowser1.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(451, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(446, 56);
            this.label3.TabIndex = 4;
            this.label3.Text = "WORD CHANGER";
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(1193, 216);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(96, 29);
            this.btnback.TabIndex = 5;
            this.btnback.Text = "Kembali";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmbfrom
            // 
            this.cmbfrom.FormattingEnabled = true;
            this.cmbfrom.Items.AddRange(new object[] {
            "PDF",
            "Word"});
            this.cmbfrom.Location = new System.Drawing.Point(736, 288);
            this.cmbfrom.Name = "cmbfrom";
            this.cmbfrom.Size = new System.Drawing.Size(168, 24);
            this.cmbfrom.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Javanese Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(662, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 38);
            this.label4.TabIndex = 7;
            this.label4.Text = "From:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Javanese Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(682, 425);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 38);
            this.label5.TabIndex = 9;
            this.label5.Text = "To:";
            // 
            // cmbto
            // 
            this.cmbto.FormattingEnabled = true;
            this.cmbto.Items.AddRange(new object[] {
            "PDF",
            "Word"});
            this.cmbto.Location = new System.Drawing.Point(736, 430);
            this.cmbto.Name = "cmbto";
            this.cmbto.Size = new System.Drawing.Size(168, 24);
            this.cmbto.TabIndex = 8;
            // 
            // btnconvert
            // 
            this.btnconvert.Location = new System.Drawing.Point(935, 358);
            this.btnconvert.Name = "btnconvert";
            this.btnconvert.Size = new System.Drawing.Size(96, 29);
            this.btnconvert.TabIndex = 10;
            this.btnconvert.Text = "Convert";
            this.btnconvert.UseVisualStyleBackColor = true;
            this.btnconvert.Click += new System.EventHandler(this.button3_Click);
            // 
            // btndownload
            // 
            this.btndownload.Location = new System.Drawing.Point(758, 497);
            this.btndownload.Name = "btndownload";
            this.btndownload.Size = new System.Drawing.Size(119, 29);
            this.btndownload.TabIndex = 11;
            this.btndownload.Text = "Download";
            this.btndownload.UseVisualStyleBackColor = true;
            this.btndownload.Visible = false;
            this.btndownload.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(794, 347);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(921, 288);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 29);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // word
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btndownload);
            this.Controls.Add(this.btnconvert);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbfrom);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnpf);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "word";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDF to Word";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnpf;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.ComboBox cmbfrom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbto;
        private System.Windows.Forms.Button btnconvert;
        private System.Windows.Forms.Button btndownload;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

