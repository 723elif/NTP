namespace uygulama_1
{
    partial class Form1
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
            this.dgvTelevizyon = new System.Windows.Forms.DataGridView();
            this.lblMarka = new System.Windows.Forms.Label();
            this.lblİsletimSistemi = new System.Windows.Forms.Label();
            this.lblBoyut = new System.Windows.Forms.Label();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.txtİsletimSistemi = new System.Windows.Forms.TextBox();
            this.txtBoyut = new System.Windows.Forms.TextBox();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.chkStok = new System.Windows.Forms.CheckBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelevizyon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTelevizyon
            // 
            this.dgvTelevizyon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTelevizyon.Location = new System.Drawing.Point(190, 12);
            this.dgvTelevizyon.Name = "dgvTelevizyon";
            this.dgvTelevizyon.Size = new System.Drawing.Size(450, 221);
            this.dgvTelevizyon.TabIndex = 3;
            // 
            // lblMarka
            // 
            this.lblMarka.AutoSize = true;
            this.lblMarka.Location = new System.Drawing.Point(46, 28);
            this.lblMarka.Name = "lblMarka";
            this.lblMarka.Size = new System.Drawing.Size(37, 13);
            this.lblMarka.TabIndex = 4;
            this.lblMarka.Text = "Marka";
            // 
            // lblİsletimSistemi
            // 
            this.lblİsletimSistemi.AutoSize = true;
            this.lblİsletimSistemi.Location = new System.Drawing.Point(13, 53);
            this.lblİsletimSistemi.Name = "lblİsletimSistemi";
            this.lblİsletimSistemi.Size = new System.Drawing.Size(72, 13);
            this.lblİsletimSistemi.TabIndex = 5;
            this.lblİsletimSistemi.Text = "İşletim Sistemi";
            // 
            // lblBoyut
            // 
            this.lblBoyut.AutoSize = true;
            this.lblBoyut.Location = new System.Drawing.Point(51, 80);
            this.lblBoyut.Name = "lblBoyut";
            this.lblBoyut.Size = new System.Drawing.Size(34, 13);
            this.lblBoyut.TabIndex = 6;
            this.lblBoyut.Text = "Boyut";
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Location = new System.Drawing.Point(56, 107);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(29, 13);
            this.lblFiyat.TabIndex = 7;
            this.lblFiyat.Text = "Fiyat";
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(86, 25);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(89, 20);
            this.txtMarka.TabIndex = 8;
            // 
            // txtİsletimSistemi
            // 
            this.txtİsletimSistemi.Location = new System.Drawing.Point(86, 50);
            this.txtİsletimSistemi.Name = "txtİsletimSistemi";
            this.txtİsletimSistemi.Size = new System.Drawing.Size(89, 20);
            this.txtİsletimSistemi.TabIndex = 9;
            // 
            // txtBoyut
            // 
            this.txtBoyut.Location = new System.Drawing.Point(86, 78);
            this.txtBoyut.Name = "txtBoyut";
            this.txtBoyut.Size = new System.Drawing.Size(89, 20);
            this.txtBoyut.TabIndex = 10;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(86, 104);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(89, 20);
            this.txtFiyat.TabIndex = 11;
            // 
            // chkStok
            // 
            this.chkStok.AutoSize = true;
            this.chkStok.Location = new System.Drawing.Point(91, 130);
            this.chkStok.Name = "chkStok";
            this.chkStok.Size = new System.Drawing.Size(76, 17);
            this.chkStok.TabIndex = 12;
            this.chkStok.Text = "Stokta Var";
            this.chkStok.UseVisualStyleBackColor = true;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(91, 153);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(80, 28);
            this.btnEkle.TabIndex = 13;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(91, 187);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(80, 28);
            this.btnSil.TabIndex = 14;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 265);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.chkStok);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.txtBoyut);
            this.Controls.Add(this.txtİsletimSistemi);
            this.Controls.Add(this.txtMarka);
            this.Controls.Add(this.lblFiyat);
            this.Controls.Add(this.lblBoyut);
            this.Controls.Add(this.lblİsletimSistemi);
            this.Controls.Add(this.lblMarka);
            this.Controls.Add(this.dgvTelevizyon);
            this.Name = "Form1";
            this.Text = "0,";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelevizyon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTelevizyon;
        private System.Windows.Forms.Label lblMarka;
        private System.Windows.Forms.Label lblİsletimSistemi;
        private System.Windows.Forms.Label lblBoyut;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.TextBox txtİsletimSistemi;
        private System.Windows.Forms.TextBox txtBoyut;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.CheckBox chkStok;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
    }
}

