namespace ADONetOrnek2
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
            this.components = new System.ComponentModel.Container();
            this.dgv_urunler = new System.Windows.Forms.DataGridView();
            this.txt_urunad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nud_fiyat = new System.Windows.Forms.NumericUpDown();
            this.nud_stok = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_kategoriler = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sp_ekle = new System.Windows.Forms.Button();
            this.sp_sil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_urunler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_fiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_stok)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_urunler
            // 
            this.dgv_urunler.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgv_urunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_urunler.ContextMenuStrip = this.contextMenuStrip2;
            this.dgv_urunler.Location = new System.Drawing.Point(1, 93);
            this.dgv_urunler.Name = "dgv_urunler";
            this.dgv_urunler.RowHeadersWidth = 62;
            this.dgv_urunler.RowTemplate.Height = 28;
            this.dgv_urunler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_urunler.Size = new System.Drawing.Size(1247, 622);
            this.dgv_urunler.TabIndex = 0;
            this.dgv_urunler.Click += new System.EventHandler(this.dgv_urunler_Click);
            // 
            // txt_urunad
            // 
            this.txt_urunad.BackColor = System.Drawing.Color.Silver;
            this.txt_urunad.Location = new System.Drawing.Point(134, 28);
            this.txt_urunad.Name = "txt_urunad";
            this.txt_urunad.Size = new System.Drawing.Size(100, 26);
            this.txt_urunad.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(27, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "ÜRÜN ADI:";
            // 
            // nud_fiyat
            // 
            this.nud_fiyat.BackColor = System.Drawing.Color.Silver;
            this.nud_fiyat.Location = new System.Drawing.Point(345, 29);
            this.nud_fiyat.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nud_fiyat.Name = "nud_fiyat";
            this.nud_fiyat.Size = new System.Drawing.Size(120, 26);
            this.nud_fiyat.TabIndex = 4;
            // 
            // nud_stok
            // 
            this.nud_stok.BackColor = System.Drawing.Color.Silver;
            this.nud_stok.Location = new System.Drawing.Point(582, 28);
            this.nud_stok.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nud_stok.Name = "nud_stok";
            this.nud_stok.Size = new System.Drawing.Size(120, 26);
            this.nud_stok.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(270, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "FİYAT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(510, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "STOK";
            // 
            // btn_ekle
            // 
            this.btn_ekle.BackColor = System.Drawing.Color.Azure;
            this.btn_ekle.Location = new System.Drawing.Point(734, 15);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(95, 57);
            this.btn_ekle.TabIndex = 7;
            this.btn_ekle.Text = "EKLE";
            this.btn_ekle.UseVisualStyleBackColor = false;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // btn_kategoriler
            // 
            this.btn_kategoriler.BackColor = System.Drawing.Color.Azure;
            this.btn_kategoriler.Location = new System.Drawing.Point(835, 15);
            this.btn_kategoriler.Name = "btn_kategoriler";
            this.btn_kategoriler.Size = new System.Drawing.Size(107, 57);
            this.btn_kategoriler.TabIndex = 8;
            this.btn_kategoriler.Text = "Kategoriler";
            this.btn_kategoriler.UseVisualStyleBackColor = false;
            this.btn_kategoriler.Click += new System.EventHandler(this.btn_kategoriler_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.BackColor = System.Drawing.Color.Azure;
            this.btn_guncelle.Location = new System.Drawing.Point(948, 15);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(105, 57);
            this.btn_guncelle.TabIndex = 10;
            this.btn_guncelle.Text = "GÜNCELLE";
            this.btn_guncelle.UseVisualStyleBackColor = false;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(101, 36);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(100, 32);
            this.silToolStripMenuItem.Text = "sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // sp_ekle
            // 
            this.sp_ekle.BackColor = System.Drawing.Color.Azure;
            this.sp_ekle.Location = new System.Drawing.Point(1059, 15);
            this.sp_ekle.Name = "sp_ekle";
            this.sp_ekle.Size = new System.Drawing.Size(93, 57);
            this.sp_ekle.TabIndex = 13;
            this.sp_ekle.Text = "SP ile Ekle";
            this.sp_ekle.UseVisualStyleBackColor = false;
            this.sp_ekle.Click += new System.EventHandler(this.sp_ekle_Click);
            // 
            // sp_sil
            // 
            this.sp_sil.Location = new System.Drawing.Point(1158, 15);
            this.sp_sil.Name = "sp_sil";
            this.sp_sil.Size = new System.Drawing.Size(90, 57);
            this.sp_sil.TabIndex = 14;
            this.sp_sil.Text = "SP ile Sil";
            this.sp_sil.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 726);
            this.Controls.Add(this.sp_sil);
            this.Controls.Add(this.sp_ekle);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.btn_kategoriler);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nud_stok);
            this.Controls.Add(this.nud_fiyat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_urunad);
            this.Controls.Add(this.dgv_urunler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_urunler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_fiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_stok)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_urunler;
        private System.Windows.Forms.TextBox txt_urunad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nud_fiyat;
        private System.Windows.Forms.NumericUpDown nud_stok;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_kategoriler;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.Button sp_ekle;
        private System.Windows.Forms.Button sp_sil;
    }
}

