namespace SistemInventarisKavling
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dgvKavling;

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
            this.dgvKavling = new System.Windows.Forms.DataGridView();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCari = new System.Windows.Forms.Button();
            this.btnSortLuas = new System.Windows.Forms.Button();
            this.btnSortHarga = new System.Windows.Forms.Button();
            this.lblCari = new System.Windows.Forms.Label();
            this.lblJudul = new System.Windows.Forms.Label();
            this.lblTotalData = new System.Windows.Forms.Label();
            this.lblTotalTersedia = new System.Windows.Forms.Label();
            this.lblTotalLuas = new System.Windows.Forms.Label();
            this.lblTotalTerjual = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtHarga = new System.Windows.Forms.TextBox();
            this.txtLuas = new System.Windows.Forms.TextBox();
            this.txtLebar = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtPanjang = new System.Windows.Forms.TextBox();
            this.cbBentuk = new System.Windows.Forms.ComboBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblNama = new System.Windows.Forms.Label();
            this.lblBentuk = new System.Windows.Forms.Label();
            this.lblPanjang = new System.Windows.Forms.Label();
            this.lblLebar = new System.Windows.Forms.Label();
            this.lblLuas = new System.Windows.Forms.Label();
            this.lblHarga = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKavling)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvKavling
            // 
            this.dgvKavling.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKavling.Location = new System.Drawing.Point(484, 119);
            this.dgvKavling.Name = "dgvKavling";
            this.dgvKavling.RowHeadersWidth = 51;
            this.dgvKavling.RowTemplate.Height = 24;
            this.dgvKavling.Size = new System.Drawing.Size(554, 315);
            this.dgvKavling.TabIndex = 0;
            this.dgvKavling.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKavling_CellContentClick);
            // 
            // txtCari
            // 
            this.txtCari.Location = new System.Drawing.Point(124, 518);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(200, 22);
            this.txtCari.TabIndex = 3;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(49, 471);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 23);
            this.btnSimpan.TabIndex = 10;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            // 
            // btnUbah
            // 
            this.btnUbah.Location = new System.Drawing.Point(149, 471);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(75, 23);
            this.btnUbah.TabIndex = 11;
            this.btnUbah.Text = "Ubah";
            this.btnUbah.UseVisualStyleBackColor = true;
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(249, 471);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(75, 23);
            this.btnHapus.TabIndex = 12;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(349, 471);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnCari
            // 
            this.btnCari.Location = new System.Drawing.Point(344, 518);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(75, 23);
            this.btnCari.TabIndex = 14;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = true;
            // 
            // btnSortLuas
            // 
            this.btnSortLuas.Location = new System.Drawing.Point(124, 560);
            this.btnSortLuas.Name = "btnSortLuas";
            this.btnSortLuas.Size = new System.Drawing.Size(75, 23);
            this.btnSortLuas.TabIndex = 15;
            this.btnSortLuas.Text = "Sort Luas";
            this.btnSortLuas.UseVisualStyleBackColor = true;
            // 
            // btnSortHarga
            // 
            this.btnSortHarga.Location = new System.Drawing.Point(239, 560);
            this.btnSortHarga.Name = "btnSortHarga";
            this.btnSortHarga.Size = new System.Drawing.Size(85, 23);
            this.btnSortHarga.TabIndex = 16;
            this.btnSortHarga.Text = "Sort Harga";
            this.btnSortHarga.UseVisualStyleBackColor = true;
            // 
            // lblCari
            // 
            this.lblCari.AutoSize = true;
            this.lblCari.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCari.Location = new System.Drawing.Point(63, 520);
            this.lblCari.Name = "lblCari";
            this.lblCari.Size = new System.Drawing.Size(40, 23);
            this.lblCari.TabIndex = 25;
            this.lblCari.Text = "Cari";
            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJudul.Location = new System.Drawing.Point(300, 10);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(542, 38);
            this.lblJudul.TabIndex = 26;
            this.lblJudul.Text = "SISTEM INVENTARIS LAHAN / KAVLING";
            // 
            // lblTotalData
            // 
            this.lblTotalData.AutoSize = true;
            this.lblTotalData.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalData.Location = new System.Drawing.Point(484, 507);
            this.lblTotalData.Name = "lblTotalData";
            this.lblTotalData.Size = new System.Drawing.Size(117, 23);
            this.lblTotalData.TabIndex = 27;
            this.lblTotalData.Text = "Total Data : 0";
            // 
            // lblTotalTersedia
            // 
            this.lblTotalTersedia.AutoSize = true;
            this.lblTotalTersedia.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTersedia.Location = new System.Drawing.Point(874, 511);
            this.lblTotalTersedia.Name = "lblTotalTersedia";
            this.lblTotalTersedia.Size = new System.Drawing.Size(144, 23);
            this.lblTotalTersedia.TabIndex = 28;
            this.lblTotalTersedia.Text = "Total Tersedia : 0";
            // 
            // lblTotalLuas
            // 
            this.lblTotalLuas.AutoSize = true;
            this.lblTotalLuas.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalLuas.Location = new System.Drawing.Point(874, 471);
            this.lblTotalLuas.Name = "lblTotalLuas";
            this.lblTotalLuas.Size = new System.Drawing.Size(114, 23);
            this.lblTotalLuas.TabIndex = 29;
            this.lblTotalLuas.Text = "Total Luas : 0";
            // 
            // lblTotalTerjual
            // 
            this.lblTotalTerjual.AutoSize = true;
            this.lblTotalTerjual.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTerjual.Location = new System.Drawing.Point(484, 471);
            this.lblTotalTerjual.Name = "lblTotalTerjual";
            this.lblTotalTerjual.Size = new System.Drawing.Size(132, 23);
            this.lblTotalTerjual.TabIndex = 30;
            this.lblTotalTerjual.Text = "Total Terjual : 0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(479, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 28);
            this.label1.TabIndex = 31;
            this.label1.Text = "DATA KAVLING";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(137, 27);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(250, 22);
            this.txtId.TabIndex = 1;
            // 
            // txtHarga
            // 
            this.txtHarga.Location = new System.Drawing.Point(137, 267);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.Size = new System.Drawing.Size(250, 22);
            this.txtHarga.TabIndex = 2;
            // 
            // txtLuas
            // 
            this.txtLuas.Location = new System.Drawing.Point(137, 227);
            this.txtLuas.Name = "txtLuas";
            this.txtLuas.Size = new System.Drawing.Size(250, 22);
            this.txtLuas.TabIndex = 4;
            // 
            // txtLebar
            // 
            this.txtLebar.Location = new System.Drawing.Point(137, 187);
            this.txtLebar.Name = "txtLebar";
            this.txtLebar.Size = new System.Drawing.Size(250, 22);
            this.txtLebar.TabIndex = 5;
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(137, 67);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(250, 22);
            this.txtNama.TabIndex = 6;
            this.txtNama.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtPanjang
            // 
            this.txtPanjang.Location = new System.Drawing.Point(137, 147);
            this.txtPanjang.Name = "txtPanjang";
            this.txtPanjang.Size = new System.Drawing.Size(250, 22);
            this.txtPanjang.TabIndex = 7;
            this.txtPanjang.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // cbBentuk
            // 
            this.cbBentuk.FormattingEnabled = true;
            this.cbBentuk.Items.AddRange(new object[] {
            "Persegi",
            "Persegi Panjang"});
            this.cbBentuk.Location = new System.Drawing.Point(137, 107);
            this.cbBentuk.Name = "cbBentuk";
            this.cbBentuk.Size = new System.Drawing.Size(250, 24);
            this.cbBentuk.TabIndex = 8;
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Tersedia",
            "Terjual"});
            this.cbStatus.Location = new System.Drawing.Point(137, 307);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(250, 24);
            this.cbStatus.TabIndex = 9;
            // 
            // lblId
            // 
            this.lblId.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(17, 27);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(100, 20);
            this.lblId.TabIndex = 17;
            this.lblId.Text = "ID Kavling";
            this.lblId.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNama
            // 
            this.lblNama.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNama.Location = new System.Drawing.Point(17, 67);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(100, 20);
            this.lblNama.TabIndex = 18;
            this.lblNama.Text = "Nama Kavling";
            // 
            // lblBentuk
            // 
            this.lblBentuk.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBentuk.Location = new System.Drawing.Point(17, 107);
            this.lblBentuk.Name = "lblBentuk";
            this.lblBentuk.Size = new System.Drawing.Size(100, 20);
            this.lblBentuk.TabIndex = 19;
            this.lblBentuk.Text = "Bentuk";
            // 
            // lblPanjang
            // 
            this.lblPanjang.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPanjang.Location = new System.Drawing.Point(17, 147);
            this.lblPanjang.Name = "lblPanjang";
            this.lblPanjang.Size = new System.Drawing.Size(100, 20);
            this.lblPanjang.TabIndex = 20;
            this.lblPanjang.Text = "Panjang";
            // 
            // lblLebar
            // 
            this.lblLebar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLebar.Location = new System.Drawing.Point(17, 187);
            this.lblLebar.Name = "lblLebar";
            this.lblLebar.Size = new System.Drawing.Size(100, 20);
            this.lblLebar.TabIndex = 21;
            this.lblLebar.Text = "Lebar";
            // 
            // lblLuas
            // 
            this.lblLuas.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLuas.Location = new System.Drawing.Point(17, 227);
            this.lblLuas.Name = "lblLuas";
            this.lblLuas.Size = new System.Drawing.Size(100, 20);
            this.lblLuas.TabIndex = 22;
            this.lblLuas.Text = "Luas";
            // 
            // lblHarga
            // 
            this.lblHarga.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHarga.Location = new System.Drawing.Point(17, 267);
            this.lblHarga.Name = "lblHarga";
            this.lblHarga.Size = new System.Drawing.Size(100, 20);
            this.lblHarga.TabIndex = 23;
            this.lblHarga.Text = "Harga";
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(17, 307);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(100, 20);
            this.lblStatus.TabIndex = 24;
            this.lblStatus.Text = "Status";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblStatus);
            this.groupBox1.Controls.Add(this.lblHarga);
            this.groupBox1.Controls.Add(this.lblLuas);
            this.groupBox1.Controls.Add(this.lblLebar);
            this.groupBox1.Controls.Add(this.lblPanjang);
            this.groupBox1.Controls.Add(this.lblBentuk);
            this.groupBox1.Controls.Add(this.lblNama);
            this.groupBox1.Controls.Add(this.lblId);
            this.groupBox1.Controls.Add(this.cbStatus);
            this.groupBox1.Controls.Add(this.cbBentuk);
            this.groupBox1.Controls.Add(this.txtPanjang);
            this.groupBox1.Controls.Add(this.txtNama);
            this.groupBox1.Controls.Add(this.txtLebar);
            this.groupBox1.Controls.Add(this.txtLuas);
            this.groupBox1.Controls.Add(this.txtHarga);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Location = new System.Drawing.Point(12, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 346);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 719);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTotalTerjual);
            this.Controls.Add(this.lblTotalLuas);
            this.Controls.Add(this.lblTotalTersedia);
            this.Controls.Add(this.lblTotalData);
            this.Controls.Add(this.lblJudul);
            this.Controls.Add(this.lblCari);
            this.Controls.Add(this.btnSortHarga);
            this.Controls.Add(this.btnSortLuas);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnUbah);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.txtCari);
            this.Controls.Add(this.dgvKavling);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKavling)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.Button btnSortLuas;
        private System.Windows.Forms.Button btnSortHarga;
        private System.Windows.Forms.Label lblCari;
        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.Label lblTotalData;
        private System.Windows.Forms.Label lblTotalTersedia;
        private System.Windows.Forms.Label lblTotalLuas;
        private System.Windows.Forms.Label lblTotalTerjual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtHarga;
        private System.Windows.Forms.TextBox txtLuas;
        private System.Windows.Forms.TextBox txtLebar;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtPanjang;
        private System.Windows.Forms.ComboBox cbBentuk;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Label lblBentuk;
        private System.Windows.Forms.Label lblPanjang;
        private System.Windows.Forms.Label lblLebar;
        private System.Windows.Forms.Label lblLuas;
        private System.Windows.Forms.Label lblHarga;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

