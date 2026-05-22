namespace changer2015
{
    partial class main
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
            this.label1 = new System.Windows.Forms.Label();
            this.pp1 = new changer2015.pp();
            this.pj1 = new changer2015.pj();
            this.pe1 = new changer2015.pe();
            this.pw1 = new changer2015.pw();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(480, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 56);
            this.label1.TabIndex = 5;
            this.label1.Text = "PDF CHANGER";
            // 
            // pp1
            // 
            this.pp1.BackColor = System.Drawing.Color.White;
            this.pp1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pp1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pp1.Location = new System.Drawing.Point(91, 163);
            this.pp1.Name = "pp1";
            this.pp1.Size = new System.Drawing.Size(207, 223);
            this.pp1.TabIndex = 9;
            this.pp1.Click += new System.EventHandler(this.pp1_Click);
            // 
            // pj1
            // 
            this.pj1.BackColor = System.Drawing.Color.White;
            this.pj1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pj1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pj1.Location = new System.Drawing.Point(1051, 163);
            this.pj1.Name = "pj1";
            this.pj1.Size = new System.Drawing.Size(207, 223);
            this.pj1.TabIndex = 8;
            this.pj1.Click += new System.EventHandler(this.pj1_Click);
            // 
            // pe1
            // 
            this.pe1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pe1.BackColor = System.Drawing.Color.White;
            this.pe1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pe1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pe1.Location = new System.Drawing.Point(723, 163);
            this.pe1.Name = "pe1";
            this.pe1.Size = new System.Drawing.Size(207, 223);
            this.pe1.TabIndex = 7;
            this.pe1.Click += new System.EventHandler(this.pe1_Click);
            // 
            // pw1
            // 
            this.pw1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pw1.BackColor = System.Drawing.Color.White;
            this.pw1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pw1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pw1.Location = new System.Drawing.Point(407, 163);
            this.pw1.Name = "pw1";
            this.pw1.Size = new System.Drawing.Size(207, 223);
            this.pw1.TabIndex = 6;
            this.pw1.Load += new System.EventHandler(this.pw1_Load);
            this.pw1.Click += new System.EventHandler(this.pw1_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.pp1);
            this.Controls.Add(this.pj1);
            this.Controls.Add(this.pe1);
            this.Controls.Add(this.pw1);
            this.Controls.Add(this.label1);
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private pw pw1;
        private pe pe1;
        private pj pj1;
        private pp pp1;
    }
}