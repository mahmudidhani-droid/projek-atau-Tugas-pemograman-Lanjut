using SistemInventarisKavling.Application.Interfaces;
using SistemInventarisKavling.Domain;
using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace SistemInventarisKavling
{
    public partial class Form1 : Form
    {
        private readonly IKavlingService service;

        int currentPage = 1;
        int pageSize = 5;
        bool sedangFormat = false;

        public Form1(IKavlingService service)
        {
            InitializeComponent();

            this.service = service;

            txtLuas.ReadOnly = true;

            txtHarga.KeyPress += txtHarga_KeyPress;
            txtHarga.Leave += txtHarga_Leave;
            txtHarga.TextChanged += txtHarga_TextChanged;
            txtHarga.Enter += txtHarga_Enter;

            btnSimpan.Click += btnSimpan_Click;
            btnUbah.Click += btnUbah_Click;
            btnHapus.Click += btnHapus_Click;
            btnReset.Click += btnReset_Click;
            btnCari.Click += btnCari_Click;

            btnSortLuas.Click += btnSortLuas_Click;
            btnSortHarga.Click += btnSortHarga_Click;

            dgvKavling.CellClick += dgvKavling_CellClick;

            txtPanjang.TextChanged += HitungLuas;
            txtLebar.TextChanged += HitungLuas;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbFilter.Items.Add("Semua Data");
            cbFilter.Items.Add("Status: Tersedia");
            cbFilter.Items.Add("Status: Terjual");
            cbFilter.Items.Add("Harga Tertinggi");
            cbFilter.Items.Add("Harga Terendah");

            cbFilter.SelectedIndex = 0;

            cbPageSize.Items.Add("5");
            cbPageSize.Items.Add("10");
            cbPageSize.Items.Add("15");
            cbPageSize.Items.Add("20");
            cbPageSize.Items.Add("Semua");

            cbPageSize.SelectedIndex = 0;

            lblHalaman.Text = "Halaman 1";

            LoadData();
        }

        private void LoadData()
        {
            dgvKavling.DataSource =
                service.GetAll(currentPage, pageSize);

            dgvKavling.Columns["Harga"].DefaultCellStyle.Format =
                "'Rp' #,##0";

            dgvKavling.Columns["Harga"].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleRight;

            dgvKavling.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            HitungStatistik();
        }

        private void HitungLuas(object sender, EventArgs e)
        {
            if (double.TryParse(txtPanjang.Text, out double p) &&
                double.TryParse(txtLebar.Text, out double l))
            {
                txtLuas.Text = (p * l).ToString();
            }
        }

        private void ResetForm()
        {
            txtId.Clear();
            txtNama.Clear();
            txtPanjang.Clear();
            txtLebar.Clear();
            txtLuas.Clear();
            txtHarga.Clear();
            txtCari.Clear();

            cbBentuk.SelectedIndex = -1;
            cbStatus.SelectedIndex = -1;

            dgvKavling.ClearSelection();

            txtId.Focus();
        }

        private Kavling GetDataForm()
        {
            string harga = txtHarga.Text
                .Replace("Rp", "")
                .Replace(".", "")
                .Replace(",", "")
                .Trim();

            return new Kavling
            {
                Id = txtId.Text,
                Nama = txtNama.Text,
                Bentuk = cbBentuk.Text,
                Panjang = double.Parse(txtPanjang.Text),
                Lebar = double.Parse(txtLebar.Text),
                Luas = double.Parse(txtLuas.Text),
                Harga = decimal.Parse(harga),
                Status = cbStatus.Text
            };
        }
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("ID Kavling harus diisi.");
                txtId.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNama.Text))
            {
                MessageBox.Show("Nama Kavling harus diisi.");
                txtNama.Focus();
                return;
            }

            try
            {
                service.Insert(GetDataForm());

                MessageBox.Show("Data berhasil disimpan");

                LoadData();

                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("ID Kavling harus diisi.");
                txtId.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNama.Text))
            {
                MessageBox.Show("Nama Kavling harus diisi.");
                txtNama.Focus();
                return;
            }

            try
            {
                service.Update(GetDataForm());

                MessageBox.Show("Data berhasil diubah");

                LoadData();

                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengubah data : " + ex.Message);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "Hapus data ini?",
                "Konfirmasi",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    service.Delete(txtId.Text);

                    MessageBox.Show("Data berhasil dihapus");

                    LoadData();

                    ResetForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            dgvKavling.DataSource =
                service.Search(txtCari.Text);

            HitungStatistik();
        }

        private void btnSortLuas_Click(object sender, EventArgs e)
        {
            dgvKavling.DataSource =
                service.SortLuas();

            HitungStatistik();
        }

        private void btnSortHarga_Click(object sender, EventArgs e)
        {
            dgvKavling.DataSource =
                service.SortHarga();

            HitungStatistik();
        }

        private void dgvKavling_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvKavling.Rows[e.RowIndex];

                txtId.Text = row.Cells["Id"].Value.ToString();
                txtNama.Text = row.Cells["Nama"].Value.ToString();
                cbBentuk.Text = row.Cells["Bentuk"].Value.ToString();
                txtPanjang.Text = row.Cells["Panjang"].Value.ToString();
                txtLebar.Text = row.Cells["Lebar"].Value.ToString();
                txtLuas.Text = row.Cells["Luas"].Value.ToString();
                cbStatus.Text = row.Cells["Status"].Value.ToString();

                if (row.Cells["Harga"].Value != null)
                {
                    decimal harga =
                        Convert.ToDecimal(row.Cells["Harga"].Value);

                    txtHarga.Text =
                        "Rp " + harga.ToString("N0", new CultureInfo("id-ID"));
                }
                else
                {
                    txtHarga.Clear();
                }
            }
        }

        private void HitungStatistik()
        {
            int totalData = 0;
            double totalLuas = 0;
            int tersedia = 0;
            int terjual = 0;

            foreach (DataGridViewRow row in dgvKavling.Rows)
            {
                if (row.IsNewRow)
                    continue;

                totalData++;

                totalLuas +=
                    Convert.ToDouble(row.Cells["Luas"].Value);

                string status =
                    row.Cells["Status"].Value.ToString();

                if (status == "Terjual")
                    terjual++;

                if (status == "Tersedia")
                    tersedia++;
            }

            lblTotalData.Text =
                "Total Data : " + totalData;

            lblTotalLuas.Text =
                "Total Luas : " + totalLuas;

            lblTotalTerjual.Text =
                "Total Terjual : " + terjual;

            lblTotalTersedia.Text =
                "Total Tersedia : " + tersedia;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int totalData =
                service.GetTotalData();

            int totalHalaman =
                (int)Math.Ceiling((double)totalData / pageSize);

            if (currentPage < totalHalaman)
            {
                currentPage++;

                lblHalaman.Text =
                    "Halaman " + currentPage;

                LoadData();
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;

                lblHalaman.Text =
                    "Halaman " + currentPage;

                LoadData();
            }
        }
        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentPage = 1;

            lblHalaman.Text = "Halaman 1";

            dgvKavling.DataSource =
                service.Filter(cbFilter.Text, currentPage, pageSize);

            HitungStatistik();
        }

        private void cbPageSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPageSize.Text == "Semua")
                pageSize = 999999;
            else
                pageSize = Convert.ToInt32(cbPageSize.Text);

            currentPage = 1;

            lblHalaman.Text = "Halaman 1";

            LoadData();
        }

        private void txtHarga_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtHarga_Leave(object sender, EventArgs e)
        {
            string angka = txtHarga.Text
                .Replace(".", "")
                .Replace(",", "")
                .Replace("Rp", "")
                .Trim();

            if (decimal.TryParse(angka, out decimal harga))
            {
                sedangFormat = true;

                txtHarga.Text =
                    "Rp " +
                    harga.ToString("N0", new CultureInfo("id-ID"));

                sedangFormat = false;
            }
        }

        private void txtHarga_TextChanged(object sender, EventArgs e)
        {
            if (sedangFormat)
                return;

            sedangFormat = true;

            int posisiCursor = txtHarga.SelectionStart;

            string angka = "";

            foreach (char c in txtHarga.Text)
            {
                if (char.IsDigit(c))
                    angka += c;
            }

            if (angka == "")
            {
                txtHarga.Text = "";
                sedangFormat = false;
                return;
            }

            decimal nilai = decimal.Parse(angka);

            string hasil =
                nilai.ToString("N0", new CultureInfo("id-ID"));

            int jumlahAngkaKiri = 0;

            for (int i = 0;
                 i < posisiCursor && i < txtHarga.Text.Length;
                 i++)
            {
                if (char.IsDigit(txtHarga.Text[i]))
                    jumlahAngkaKiri++;
            }

            txtHarga.Text = hasil;

            posisiCursor = 0;

            int hitung = 0;

            while (posisiCursor < txtHarga.Text.Length)
            {
                if (char.IsDigit(txtHarga.Text[posisiCursor]))
                    hitung++;

                posisiCursor++;

                if (hitung == jumlahAngkaKiri)
                    break;
            }

            txtHarga.SelectionStart = posisiCursor;

            sedangFormat = false;
        }

        private void txtHarga_Enter(object sender, EventArgs e)
        {
            txtHarga.Text =
                txtHarga.Text.Replace("Rp", "").Trim();

            txtHarga.SelectionStart =
                txtHarga.Text.Length;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void dgvKavling_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblHarga_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTotalTerjual_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}