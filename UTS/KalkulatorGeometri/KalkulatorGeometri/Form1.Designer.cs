namespace KalkulatorGeometri
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.ComboBox cmbBangun;

        private System.Windows.Forms.Label lblSisi;
        private System.Windows.Forms.Label lblPanjang;
        private System.Windows.Forms.Label lblLebar;
        private System.Windows.Forms.Label lblTinggi;
        private System.Windows.Forms.Label lblJari;

        private System.Windows.Forms.TextBox txtSisi;
        private System.Windows.Forms.TextBox txtPanjang;
        private System.Windows.Forms.TextBox txtLebar;
        private System.Windows.Forms.TextBox txtTinggi;
        private System.Windows.Forms.TextBox txtJari;

        private System.Windows.Forms.Button btnHitung;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSorting;
        private System.Windows.Forms.Button btnKeluar;

        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.GroupBox grpHasil;

        private System.Windows.Forms.Label lblLuasText;
        private System.Windows.Forms.Label lblKelilingText;
        private System.Windows.Forms.Label lblVolumeText;

        private System.Windows.Forms.Label lblLuas;
        private System.Windows.Forms.Label lblKeliling;
        private System.Windows.Forms.Label lblVolume;

        private System.Windows.Forms.ListBox lstRiwayat;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblJudul = new System.Windows.Forms.Label();
            this.cmbBangun = new System.Windows.Forms.ComboBox();
            this.lblSisi = new System.Windows.Forms.Label();
            this.lblPanjang = new System.Windows.Forms.Label();
            this.lblLebar = new System.Windows.Forms.Label();
            this.lblTinggi = new System.Windows.Forms.Label();
            this.lblJari = new System.Windows.Forms.Label();
            this.txtSisi = new System.Windows.Forms.TextBox();
            this.txtPanjang = new System.Windows.Forms.TextBox();
            this.txtLebar = new System.Windows.Forms.TextBox();
            this.txtTinggi = new System.Windows.Forms.TextBox();
            this.txtJari = new System.Windows.Forms.TextBox();
            this.btnHitung = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSorting = new System.Windows.Forms.Button();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.lblBangun = new System.Windows.Forms.Label();
            this.grpHasil = new System.Windows.Forms.GroupBox();
            this.lblLuasText = new System.Windows.Forms.Label();
            this.lblKelilingText = new System.Windows.Forms.Label();
            this.lblVolumeText = new System.Windows.Forms.Label();
            this.lblLuas = new System.Windows.Forms.Label();
            this.lblKeliling = new System.Windows.Forms.Label();
            this.lblVolume = new System.Windows.Forms.Label();
            this.lstRiwayat = new System.Windows.Forms.ListBox();
            this.grpInput.SuspendLayout();
            this.grpHasil.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblJudul
            // 
            this.lblJudul.AutoSize = true;
            this.lblJudul.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblJudul.Location = new System.Drawing.Point(250, 20);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(370, 41);
            this.lblJudul.TabIndex = 0;
            this.lblJudul.Text = "KALKULATOR GEOMETRI";
            // 
            // cmbBangun
            // 
            this.cmbBangun.Items.AddRange(new object[] {
            "Persegi",
            "Persegi Panjang",
            "Lingkaran",
            "Segitiga",
            "Kubus",
            "Balok",
            "Tabung"});
            this.cmbBangun.Location = new System.Drawing.Point(140, 30);
            this.cmbBangun.Name = "cmbBangun";
            this.cmbBangun.Size = new System.Drawing.Size(180, 24);
            this.cmbBangun.TabIndex = 1;
            // 
            // lblSisi
            // 
            this.lblSisi.Location = new System.Drawing.Point(20, 70);
            this.lblSisi.Name = "lblSisi";
            this.lblSisi.Size = new System.Drawing.Size(100, 23);
            this.lblSisi.TabIndex = 2;
            this.lblSisi.Text = "Sisi";
            // 
            // lblPanjang
            // 
            this.lblPanjang.Location = new System.Drawing.Point(20, 110);
            this.lblPanjang.Name = "lblPanjang";
            this.lblPanjang.Size = new System.Drawing.Size(100, 23);
            this.lblPanjang.TabIndex = 3;
            this.lblPanjang.Text = "Panjang";
            // 
            // lblLebar
            // 
            this.lblLebar.Location = new System.Drawing.Point(20, 150);
            this.lblLebar.Name = "lblLebar";
            this.lblLebar.Size = new System.Drawing.Size(100, 23);
            this.lblLebar.TabIndex = 4;
            this.lblLebar.Text = "Lebar";
            // 
            // lblTinggi
            // 
            this.lblTinggi.Location = new System.Drawing.Point(20, 190);
            this.lblTinggi.Name = "lblTinggi";
            this.lblTinggi.Size = new System.Drawing.Size(100, 23);
            this.lblTinggi.TabIndex = 5;
            this.lblTinggi.Text = "Tinggi";
            // 
            // lblJari
            // 
            this.lblJari.Location = new System.Drawing.Point(20, 230);
            this.lblJari.Name = "lblJari";
            this.lblJari.Size = new System.Drawing.Size(100, 23);
            this.lblJari.TabIndex = 6;
            this.lblJari.Text = "Jari-jari";
            // 
            // txtSisi
            // 
            this.txtSisi.Location = new System.Drawing.Point(140, 70);
            this.txtSisi.Name = "txtSisi";
            this.txtSisi.Size = new System.Drawing.Size(100, 22);
            this.txtSisi.TabIndex = 7;
            // 
            // txtPanjang
            // 
            this.txtPanjang.Location = new System.Drawing.Point(140, 110);
            this.txtPanjang.Name = "txtPanjang";
            this.txtPanjang.Size = new System.Drawing.Size(100, 22);
            this.txtPanjang.TabIndex = 8;
            // 
            // txtLebar
            // 
            this.txtLebar.Location = new System.Drawing.Point(140, 150);
            this.txtLebar.Name = "txtLebar";
            this.txtLebar.Size = new System.Drawing.Size(100, 22);
            this.txtLebar.TabIndex = 9;
            // 
            // txtTinggi
            // 
            this.txtTinggi.Location = new System.Drawing.Point(140, 190);
            this.txtTinggi.Name = "txtTinggi";
            this.txtTinggi.Size = new System.Drawing.Size(100, 22);
            this.txtTinggi.TabIndex = 10;
            // 
            // txtJari
            // 
            this.txtJari.Location = new System.Drawing.Point(140, 230);
            this.txtJari.Name = "txtJari";
            this.txtJari.Size = new System.Drawing.Size(100, 22);
            this.txtJari.TabIndex = 11;
            // 
            // btnHitung
            //
            this.btnHitung.Location = new System.Drawing.Point(20, 400);
            this.btnHitung.Name = "btnHitung";
            this.btnHitung.Size = new System.Drawing.Size(75, 23);
            this.btnHitung.TabIndex = 2;
            this.btnHitung.Text = "Hitung";
            this.btnHitung.Click += new System.EventHandler(this.btnHitung_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(120, 400);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSorting
            // 
            this.btnSorting.Location = new System.Drawing.Point(220, 400);
            this.btnSorting.Name = "btnSorting";
            this.btnSorting.Size = new System.Drawing.Size(75, 23);
            this.btnSorting.TabIndex = 4;
            this.btnSorting.Text = "Sorting";
            this.btnSorting.Click += new System.EventHandler(this.btnSorting_Click);
            // 
            // btnKeluar
            // 
            this.btnKeluar.Location = new System.Drawing.Point(320, 400);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(75, 23);
            this.btnKeluar.TabIndex = 5;
            this.btnKeluar.Text = "Keluar";
            this.btnKeluar.Click += new System.EventHandler(this.btnKeluar_Click);
            // 
            // grpInput
            // 
            this.grpInput.Controls.Add(this.lblBangun);
            this.grpInput.Controls.Add(this.cmbBangun);
            this.grpInput.Controls.Add(this.lblSisi);
            this.grpInput.Controls.Add(this.lblPanjang);
            this.grpInput.Controls.Add(this.lblLebar);
            this.grpInput.Controls.Add(this.lblTinggi);
            this.grpInput.Controls.Add(this.lblJari);
            this.grpInput.Controls.Add(this.txtSisi);
            this.grpInput.Controls.Add(this.txtPanjang);
            this.grpInput.Controls.Add(this.txtLebar);
            this.grpInput.Controls.Add(this.txtTinggi);
            this.grpInput.Controls.Add(this.txtJari);
            this.grpInput.Location = new System.Drawing.Point(20, 80);
            this.grpInput.Name = "grpInput";
            this.grpInput.Size = new System.Drawing.Size(350, 300);
            this.grpInput.TabIndex = 1;
            this.grpInput.TabStop = false;
            this.grpInput.Text = "Input Data";
            // 
            // lblBangun
            // 
            this.lblBangun.Location = new System.Drawing.Point(20, 30);
            this.lblBangun.Name = "lblBangun";
            this.lblBangun.Size = new System.Drawing.Size(100, 23);
            this.lblBangun.TabIndex = 0;
            this.lblBangun.Text = "Bangun";
            // 
            // grpHasil
            // 
            this.grpHasil.Controls.Add(this.lblLuasText);
            this.grpHasil.Controls.Add(this.lblKelilingText);
            this.grpHasil.Controls.Add(this.lblVolumeText);
            this.grpHasil.Controls.Add(this.lblLuas);
            this.grpHasil.Controls.Add(this.lblKeliling);
            this.grpHasil.Controls.Add(this.lblVolume);
            this.grpHasil.Location = new System.Drawing.Point(400, 80);
            this.grpHasil.Name = "grpHasil";
            this.grpHasil.Size = new System.Drawing.Size(300, 200);
            this.grpHasil.TabIndex = 6;
            this.grpHasil.TabStop = false;
            this.grpHasil.Text = "Hasil";
            // 
            // lblLuasText
            // 
            this.lblLuasText.Location = new System.Drawing.Point(20, 40);
            this.lblLuasText.Name = "lblLuasText";
            this.lblLuasText.Size = new System.Drawing.Size(100, 23);
            this.lblLuasText.TabIndex = 0;
            this.lblLuasText.Text = "Luas";
            // 
            // lblKelilingText
            // 
            this.lblKelilingText.Location = new System.Drawing.Point(20, 80);
            this.lblKelilingText.Name = "lblKelilingText";
            this.lblKelilingText.Size = new System.Drawing.Size(100, 23);
            this.lblKelilingText.TabIndex = 1;
            this.lblKelilingText.Text = "Keliling";
            // 
            // lblVolumeText
            // 
            this.lblVolumeText.Location = new System.Drawing.Point(20, 120);
            this.lblVolumeText.Name = "lblVolumeText";
            this.lblVolumeText.Size = new System.Drawing.Size(100, 23);
            this.lblVolumeText.TabIndex = 2;
            this.lblVolumeText.Text = "Volume";
            // 
            // lblLuas
            // 
            this.lblLuas.Location = new System.Drawing.Point(120, 40);
            this.lblLuas.Name = "lblLuas";
            this.lblLuas.Size = new System.Drawing.Size(100, 23);
            this.lblLuas.TabIndex = 3;
            this.lblLuas.Text = "0";
            // 
            // lblKeliling
            // 
            this.lblKeliling.Location = new System.Drawing.Point(120, 80);
            this.lblKeliling.Name = "lblKeliling";
            this.lblKeliling.Size = new System.Drawing.Size(100, 23);
            this.lblKeliling.TabIndex = 4;
            this.lblKeliling.Text = "0";
            // 
            // lblVolume
            // 
            this.lblVolume.Location = new System.Drawing.Point(120, 120);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(100, 23);
            this.lblVolume.TabIndex = 5;
            this.lblVolume.Text = "0";
            // 
            // lstRiwayat
            // 
            this.lstRiwayat.ItemHeight = 16;
            this.lstRiwayat.Location = new System.Drawing.Point(400, 320);
            this.lstRiwayat.Name = "lstRiwayat";
            this.lstRiwayat.Size = new System.Drawing.Size(500, 228);
            this.lstRiwayat.TabIndex = 7;
            this.lstRiwayat.SelectedIndexChanged += new System.EventHandler(this.lstRiwayat_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.lblJudul);
            this.Controls.Add(this.grpInput);
            this.Controls.Add(this.btnHitung);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSorting);
            this.Controls.Add(this.btnKeluar);
            this.Controls.Add(this.grpHasil);
            this.Controls.Add(this.lstRiwayat);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kalkulator Geometri";
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            this.grpHasil.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblBangun;
    }
}