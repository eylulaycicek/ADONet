namespace ADONetOrnek2
{
    partial class KategoriForm
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
            this.dgv_kategori = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_kadad = new System.Windows.Forms.TextBox();
            this.txt_tanim = new System.Windows.Forms.TextBox();
            this.btn_katekle = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_kategori)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_kategori
            // 
            this.dgv_kategori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_kategori.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_kategori.Location = new System.Drawing.Point(12, 124);
            this.dgv_kategori.Name = "dgv_kategori";
            this.dgv_kategori.RowHeadersWidth = 62;
            this.dgv_kategori.RowTemplate.Height = 28;
            this.dgv_kategori.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgv_kategori.Size = new System.Drawing.Size(865, 451);
            this.dgv_kategori.TabIndex = 0;
            this.dgv_kategori.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_kategori_CellValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kategori Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kategori Tanımı";
            // 
            // txt_kadad
            // 
            this.txt_kadad.Location = new System.Drawing.Point(109, 38);
            this.txt_kadad.Name = "txt_kadad";
            this.txt_kadad.Size = new System.Drawing.Size(100, 26);
            this.txt_kadad.TabIndex = 3;
            // 
            // txt_tanim
            // 
            this.txt_tanim.Location = new System.Drawing.Point(352, 38);
            this.txt_tanim.Name = "txt_tanim";
            this.txt_tanim.Size = new System.Drawing.Size(423, 26);
            this.txt_tanim.TabIndex = 4;
            // 
            // btn_katekle
            // 
            this.btn_katekle.Location = new System.Drawing.Point(790, 38);
            this.btn_katekle.Name = "btn_katekle";
            this.btn_katekle.Size = new System.Drawing.Size(87, 34);
            this.btn_katekle.TabIndex = 5;
            this.btn_katekle.Text = "EKLE";
            this.btn_katekle.UseVisualStyleBackColor = true;
            this.btn_katekle.Click += new System.EventHandler(this.btn_katekle_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 36);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(240, 32);
            this.silToolStripMenuItem.Text = "sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // KategoriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 615);
            this.Controls.Add(this.btn_katekle);
            this.Controls.Add(this.txt_tanim);
            this.Controls.Add(this.txt_kadad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_kategori);
            this.Name = "KategoriForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KategoriForm";
            this.Load += new System.EventHandler(this.KategoriForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_kategori)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_kategori;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_kadad;
        private System.Windows.Forms.TextBox txt_tanim;
        private System.Windows.Forms.Button btn_katekle;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
    }
}