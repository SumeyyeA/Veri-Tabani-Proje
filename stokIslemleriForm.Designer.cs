
namespace eczane
{
    partial class stokIslemleriForm
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.guncelleme = new System.Windows.Forms.Button();
            this.ekle = new System.Windows.Forms.Button();
            this.stok = new System.Windows.Forms.Button();
            this.ilacID = new System.Windows.Forms.TextBox();
            this.adet = new System.Windows.Forms.TextBox();
            this.fiyat = new System.Windows.Forms.TextBox();
            this.ilacAdi = new System.Windows.Forms.TextBox();
            this.uretimTarihi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sil = new System.Windows.Forms.Button();
            this.barkod = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(68, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(645, 264);
            this.dataGridView2.TabIndex = 15;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // guncelleme
            // 
            this.guncelleme.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.guncelleme.Location = new System.Drawing.Point(145, 382);
            this.guncelleme.Name = "guncelleme";
            this.guncelleme.Size = new System.Drawing.Size(102, 23);
            this.guncelleme.TabIndex = 14;
            this.guncelleme.Text = "Ilaç Güncelle";
            this.guncelleme.UseVisualStyleBackColor = false;
            this.guncelleme.Click += new System.EventHandler(this.guncelleme_Click);
            // 
            // ekle
            // 
            this.ekle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ekle.Location = new System.Drawing.Point(145, 351);
            this.ekle.Name = "ekle";
            this.ekle.Size = new System.Drawing.Size(110, 23);
            this.ekle.TabIndex = 13;
            this.ekle.Text = "Yeni Ilaç Ekle";
            this.ekle.UseVisualStyleBackColor = false;
            this.ekle.Click += new System.EventHandler(this.ekle_Click);
            // 
            // stok
            // 
            this.stok.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.stok.Location = new System.Drawing.Point(132, 309);
            this.stok.Name = "stok";
            this.stok.Size = new System.Drawing.Size(144, 23);
            this.stok.TabIndex = 12;
            this.stok.Text = "Stoktaki Ilaçları Görünütüle";
            this.stok.UseVisualStyleBackColor = false;
            this.stok.Click += new System.EventHandler(this.stok_Click);
            // 
            // ilacID
            // 
            this.ilacID.Location = new System.Drawing.Point(613, 292);
            this.ilacID.Name = "ilacID";
            this.ilacID.Size = new System.Drawing.Size(100, 20);
            this.ilacID.TabIndex = 16;
            // 
            // adet
            // 
            this.adet.Location = new System.Drawing.Point(613, 370);
            this.adet.Name = "adet";
            this.adet.Size = new System.Drawing.Size(100, 20);
            this.adet.TabIndex = 17;
            // 
            // fiyat
            // 
            this.fiyat.Location = new System.Drawing.Point(613, 344);
            this.fiyat.Name = "fiyat";
            this.fiyat.Size = new System.Drawing.Size(100, 20);
            this.fiyat.TabIndex = 18;
            // 
            // ilacAdi
            // 
            this.ilacAdi.Location = new System.Drawing.Point(613, 318);
            this.ilacAdi.Name = "ilacAdi";
            this.ilacAdi.Size = new System.Drawing.Size(100, 20);
            this.ilacAdi.TabIndex = 19;
            // 
            // uretimTarihi
            // 
            this.uretimTarihi.Location = new System.Drawing.Point(613, 396);
            this.uretimTarihi.Name = "uretimTarihi";
            this.uretimTarihi.Size = new System.Drawing.Size(100, 20);
            this.uretimTarihi.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(495, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "ilacID : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(495, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Adı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(495, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Fiyat :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(495, 373);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Adet  :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(495, 399);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Uretim Tarihi  :";
            // 
            // sil
            // 
            this.sil.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sil.Location = new System.Drawing.Point(157, 413);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(75, 23);
            this.sil.TabIndex = 26;
            this.sil.Text = "Ilac Sil";
            this.sil.UseVisualStyleBackColor = false;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // barkod
            // 
            this.barkod.Location = new System.Drawing.Point(613, 422);
            this.barkod.Name = "barkod";
            this.barkod.Size = new System.Drawing.Size(100, 20);
            this.barkod.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(495, 425);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Barkod  :";
            // 
            // stokIslemleriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 448);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.barkod);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uretimTarihi);
            this.Controls.Add(this.ilacAdi);
            this.Controls.Add(this.fiyat);
            this.Controls.Add(this.adet);
            this.Controls.Add(this.ilacID);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.guncelleme);
            this.Controls.Add(this.ekle);
            this.Controls.Add(this.stok);
            this.Name = "stokIslemleriForm";
            this.Text = "stokIslemleriForm";
            this.Load += new System.EventHandler(this.stokIslemleriForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button guncelleme;
        private System.Windows.Forms.Button ekle;
        private System.Windows.Forms.Button stok;
        private System.Windows.Forms.TextBox ilacID;
        private System.Windows.Forms.TextBox adet;
        private System.Windows.Forms.TextBox fiyat;
        private System.Windows.Forms.TextBox ilacAdi;
        private System.Windows.Forms.TextBox uretimTarihi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.TextBox barkod;
        private System.Windows.Forms.Label label6;
    }
}