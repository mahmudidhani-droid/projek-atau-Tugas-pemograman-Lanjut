using System.Drawing;
using System.Windows.Forms;

namespace SearchingSortingApp
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
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.colNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNilai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnBubble = new System.Windows.Forms.Button();
            this.btnSelection = new System.Windows.Forms.Button();
            this.btnInsertion = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.lblLangkah = new System.Windows.Forms.Label();
            this.lblKeterangan = new System.Windows.Forms.Label();
            this.lblPerbandingan = new System.Windows.Forms.Label();
            this.lblPertukaran = new System.Windows.Forms.Label();
            this.btnAuto = new System.Windows.Forms.Button();
            this.dgvPerbandingan = new System.Windows.Forms.DataGridView();
            this.Algoritma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Perbandingan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pertukaran = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCounting = new System.Windows.Forms.Button();
            this.btnBinary = new System.Windows.Forms.Button();
            this.btnTabel = new System.Windows.Forms.Button();
            this.btnSequential = new System.Windows.Forms.Button();
            this.trackSpeed = new System.Windows.Forms.TrackBar();
            this.lblSpeed = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerbandingan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNo,
            this.colNama,
            this.colNilai});
            this.dgvData.Location = new System.Drawing.Point(9, 10);
            this.dgvData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersVisible = false;
            this.dgvData.RowHeadersWidth = 51;
            this.dgvData.RowTemplate.Height = 24;
            this.dgvData.Size = new System.Drawing.Size(208, 203);
            this.dgvData.TabIndex = 0;
            this.dgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellContentClick);
            // 
            // colNo
            // 
            this.colNo.HeaderText = "No";
            this.colNo.MinimumWidth = 6;
            this.colNo.Name = "colNo";
            this.colNo.ReadOnly = true;
            this.colNo.Width = 40;
            // 
            // colNama
            // 
            this.colNama.HeaderText = "Nama";
            this.colNama.MaxInputLength = 3276;
            this.colNama.MinimumWidth = 6;
            this.colNama.Name = "colNama";
            this.colNama.ReadOnly = true;
            this.colNama.Width = 125;
            // 
            // colNilai
            // 
            this.colNilai.FillWeight = 400F;
            this.colNilai.HeaderText = "Nilai";
            this.colNilai.MinimumWidth = 6;
            this.colNilai.Name = "colNilai";
            this.colNilai.ReadOnly = true;
            this.colNilai.Width = 60;
            // 
            // txtCari
            // 
            this.txtCari.Location = new System.Drawing.Point(256, 292);
            this.txtCari.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCari.Multiline = true;
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(132, 28);
            this.txtCari.TabIndex = 1;
            this.txtCari.TextChanged += new System.EventHandler(this.txtCari_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(401, 292);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(64, 28);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "cari";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnBubble
            // 
            this.btnBubble.Location = new System.Drawing.Point(238, 193);
            this.btnBubble.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBubble.Name = "btnBubble";
            this.btnBubble.Size = new System.Drawing.Size(63, 25);
            this.btnBubble.TabIndex = 3;
            this.btnBubble.Text = "Bubble";
            this.btnBubble.UseVisualStyleBackColor = true;
            this.btnBubble.Click += new System.EventHandler(this.btnBubble_Click);
            // 
            // btnSelection
            // 
            this.btnSelection.Location = new System.Drawing.Point(326, 193);
            this.btnSelection.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSelection.Name = "btnSelection";
            this.btnSelection.Size = new System.Drawing.Size(70, 25);
            this.btnSelection.TabIndex = 4;
            this.btnSelection.Text = "Selection";
            this.btnSelection.UseVisualStyleBackColor = true;
            this.btnSelection.Click += new System.EventHandler(this.btnSelection_Click);
            // 
            // btnInsertion
            // 
            this.btnInsertion.Location = new System.Drawing.Point(410, 193);
            this.btnInsertion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInsertion.Name = "btnInsertion";
            this.btnInsertion.Size = new System.Drawing.Size(64, 20);
            this.btnInsertion.TabIndex = 5;
            this.btnInsertion.Text = "Insertion";
            this.btnInsertion.UseVisualStyleBackColor = true;
            this.btnInsertion.Click += new System.EventHandler(this.btnInsertion_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(12, 245);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(63, 24);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(163, 246);
            this.btnPrev.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(70, 24);
            this.btnPrev.TabIndex = 7;
            this.btnPrev.Text = "Prev";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // lblLangkah
            // 
            this.lblLangkah.AutoSize = true;
            this.lblLangkah.Location = new System.Drawing.Point(22, 218);
            this.lblLangkah.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLangkah.Name = "lblLangkah";
            this.lblLangkah.Size = new System.Drawing.Size(49, 13);
            this.lblLangkah.TabIndex = 8;
            this.lblLangkah.Text = "Langkah";
            this.lblLangkah.Click += new System.EventHandler(this.lblLangkah_Click);
            // 
            // lblKeterangan
            // 
            this.lblKeterangan.AutoSize = true;
            this.lblKeterangan.Location = new System.Drawing.Point(32, 302);
            this.lblKeterangan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKeterangan.Name = "lblKeterangan";
            this.lblKeterangan.Size = new System.Drawing.Size(62, 13);
            this.lblKeterangan.TabIndex = 9;
            this.lblKeterangan.Text = "Keterangan";
            // 
            // lblPerbandingan
            // 
            this.lblPerbandingan.AutoSize = true;
            this.lblPerbandingan.Location = new System.Drawing.Point(32, 328);
            this.lblPerbandingan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPerbandingan.Name = "lblPerbandingan";
            this.lblPerbandingan.Size = new System.Drawing.Size(76, 13);
            this.lblPerbandingan.TabIndex = 15;
            this.lblPerbandingan.Text = "Perbandingan:";
            this.lblPerbandingan.Click += new System.EventHandler(this.lblPerbandingan_Click);
            // 
            // lblPertukaran
            // 
            this.lblPertukaran.AutoSize = true;
            this.lblPertukaran.Location = new System.Drawing.Point(32, 350);
            this.lblPertukaran.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPertukaran.Name = "lblPertukaran";
            this.lblPertukaran.Size = new System.Drawing.Size(62, 13);
            this.lblPertukaran.TabIndex = 16;
            this.lblPertukaran.Text = "Pertukaran:";
            this.lblPertukaran.Click += new System.EventHandler(this.lblPertukaran_Click);
            // 
            // btnAuto
            // 
            this.btnAuto.Location = new System.Drawing.Point(80, 246);
            this.btnAuto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(70, 24);
            this.btnAuto.TabIndex = 10;
            this.btnAuto.Text = "Auto";
            this.btnAuto.UseVisualStyleBackColor = true;
            this.btnAuto.Click += new System.EventHandler(this.btnAuto_Click);
            // 
            // dgvPerbandingan
            // 
            this.dgvPerbandingan.AllowUserToAddRows = false;
            this.dgvPerbandingan.AllowUserToDeleteRows = false;
            this.dgvPerbandingan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPerbandingan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Algoritma,
            this.Perbandingan,
            this.Pertukaran});
            this.dgvPerbandingan.Location = new System.Drawing.Point(238, 20);
            this.dgvPerbandingan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvPerbandingan.Name = "dgvPerbandingan";
            this.dgvPerbandingan.ReadOnly = true;
            this.dgvPerbandingan.RowHeadersVisible = false;
            this.dgvPerbandingan.RowHeadersWidth = 51;
            this.dgvPerbandingan.RowTemplate.Height = 24;
            this.dgvPerbandingan.Size = new System.Drawing.Size(253, 155);
            this.dgvPerbandingan.TabIndex = 11;
            this.dgvPerbandingan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Algoritma
            // 
            this.Algoritma.HeaderText = "Algoritma";
            this.Algoritma.MinimumWidth = 6;
            this.Algoritma.Name = "Algoritma";
            this.Algoritma.ReadOnly = true;
            this.Algoritma.Width = 120;
            // 
            // Perbandingan
            // 
            this.Perbandingan.HeaderText = "Perbandingan";
            this.Perbandingan.MinimumWidth = 6;
            this.Perbandingan.Name = "Perbandingan";
            this.Perbandingan.ReadOnly = true;
            this.Perbandingan.Width = 125;
            // 
            // Pertukaran
            // 
            this.Pertukaran.HeaderText = "Pertukaran";
            this.Pertukaran.MinimumWidth = 6;
            this.Pertukaran.Name = "Pertukaran";
            this.Pertukaran.ReadOnly = true;
            this.Pertukaran.Width = 125;
            // 
            // btnCounting
            // 
            this.btnCounting.Location = new System.Drawing.Point(374, 223);
            this.btnCounting.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCounting.Name = "btnCounting";
            this.btnCounting.Size = new System.Drawing.Size(63, 21);
            this.btnCounting.TabIndex = 12;
            this.btnCounting.Text = "Counting";
            this.btnCounting.UseVisualStyleBackColor = true;
            this.btnCounting.Click += new System.EventHandler(this.btnCounting_Click);
            // 
            // btnBinary
            // 
            this.btnBinary.Location = new System.Drawing.Point(318, 267);
            this.btnBinary.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBinary.Name = "btnBinary";
            this.btnBinary.Size = new System.Drawing.Size(70, 21);
            this.btnBinary.TabIndex = 13;
            this.btnBinary.Text = "Binary";
            this.btnBinary.UseVisualStyleBackColor = true;
            this.btnBinary.Click += new System.EventHandler(this.btnBinary_Click);
            // 
            // btnTabel
            // 
            this.btnTabel.Location = new System.Drawing.Point(272, 223);
            this.btnTabel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTabel.Name = "btnTabel";
            this.btnTabel.Size = new System.Drawing.Size(64, 21);
            this.btnTabel.TabIndex = 14;
            this.btnTabel.Text = "Tabel";
            this.btnTabel.UseVisualStyleBackColor = true;
            this.btnTabel.Click += new System.EventHandler(this.btnTabel_Click);
            // 
            // btnSequential
            // 
            this.btnSequential.Location = new System.Drawing.Point(251, 267);
            this.btnSequential.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSequential.Name = "btnSequential";
            this.btnSequential.Size = new System.Drawing.Size(63, 20);
            this.btnSequential.TabIndex = 17;
            this.btnSequential.Text = "Sequential";
            this.btnSequential.UseVisualStyleBackColor = true;
            this.btnSequential.Click += new System.EventHandler(this.btnSequential_Click);
            // 
            // trackSpeed
            // 
            this.trackSpeed.Location = new System.Drawing.Point(256, 338);
            this.trackSpeed.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trackSpeed.Minimum = 1;
            this.trackSpeed.Name = "trackSpeed";
            this.trackSpeed.Size = new System.Drawing.Size(140, 45);
            this.trackSpeed.TabIndex = 18;
            this.trackSpeed.Value = 5;
            this.trackSpeed.Scroll += new System.EventHandler(this.trackSpeed_Scroll);
            // 
            // lblSpeed
            // 
            this.lblSpeed.Location = new System.Drawing.Point(283, 322);
            this.lblSpeed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(75, 19);
            this.lblSpeed.TabIndex = 19;
            this.lblSpeed.Text = "Kecepatan: 5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 394);
            this.Controls.Add(this.btnSequential);
            this.Controls.Add(this.btnTabel);
            this.Controls.Add(this.btnBinary);
            this.Controls.Add(this.btnCounting);
            this.Controls.Add(this.dgvPerbandingan);
            this.Controls.Add(this.btnAuto);
            this.Controls.Add(this.lblKeterangan);
            this.Controls.Add(this.lblPerbandingan);
            this.Controls.Add(this.lblPertukaran);
            this.Controls.Add(this.lblLangkah);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnInsertion);
            this.Controls.Add(this.btnSelection);
            this.Controls.Add(this.btnBubble);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtCari);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.trackSpeed);
            this.Controls.Add(this.lblSpeed);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerbandingan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TrackBar trackSpeed;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnBubble;
        private System.Windows.Forms.Button btnSelection;
        private System.Windows.Forms.Button btnInsertion;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Label lblLangkah;
        private System.Windows.Forms.Label lblKeterangan;
        private System.Windows.Forms.Button btnAuto;
        private System.Windows.Forms.Label lblPerbandingan;
        private System.Windows.Forms.Label lblPertukaran;
        private System.Windows.Forms.DataGridView dgvPerbandingan;
        private System.Windows.Forms.Button btnCounting;
        private System.Windows.Forms.Button btnBinary;
        private System.Windows.Forms.Button btnTabel;
        private Button btnSequential;
        private DataGridViewTextBoxColumn colNo;
        private DataGridViewTextBoxColumn colNama;
        private DataGridViewTextBoxColumn colNilai;
        private DataGridViewTextBoxColumn Algoritma;
        private DataGridViewTextBoxColumn Perbandingan;
        private DataGridViewTextBoxColumn Pertukaran;
#endregion
    }
}

