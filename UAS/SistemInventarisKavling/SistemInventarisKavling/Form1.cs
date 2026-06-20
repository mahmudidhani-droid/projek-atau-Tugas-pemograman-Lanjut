using System;
using System.Data;
using System.Windows.Forms;
using MySqlConnector;

namespace SistemInventarisKavling
{
    public partial class Form1 : Form
    {
        string connStr = "server=localhost;database=db_kavling;uid=root;pwd=;";
        MySqlConnection conn;

        public Form1()
        {
            InitializeComponent();

            conn = new MySqlConnection(connStr);

            txtLuas.ReadOnly = true;

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
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                string query = "SELECT * FROM kavling";

                MySqlDataAdapter da =
                    new MySqlDataAdapter(query, conn);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dgvKavling.DataSource = dt;

                dgvKavling.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;

                HitungStatistik();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
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

            txtId.Focus();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                string query = @"INSERT INTO kavling
            (id_kavling,nama_kavling,bentuk,panjang,lebar,luas,harga,status_kavling)
            VALUES
            (@id,@nama,@bentuk,@panjang,@lebar,@luas,@harga,@status)";

                MySqlCommand cmd =
                    new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", txtId.Text);
                cmd.Parameters.AddWithValue("@nama", txtNama.Text);
                cmd.Parameters.AddWithValue("@bentuk", cbBentuk.Text);
                cmd.Parameters.AddWithValue("@panjang", txtPanjang.Text);
                cmd.Parameters.AddWithValue("@lebar", txtLebar.Text);
                cmd.Parameters.AddWithValue("@luas", txtLuas.Text);
                cmd.Parameters.AddWithValue("@harga", txtHarga.Text);
                cmd.Parameters.AddWithValue("@status", cbStatus.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Data berhasil disimpan");

                LoadData();
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                string query = @"UPDATE kavling SET
            nama_kavling=@nama,
            bentuk=@bentuk,
            panjang=@panjang,
            lebar=@lebar,
            luas=@luas,
            harga=@harga,
            status_kavling=@status
            WHERE id_kavling=@id";

                MySqlCommand cmd =
                    new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", txtId.Text);
                cmd.Parameters.AddWithValue("@nama", txtNama.Text);
                cmd.Parameters.AddWithValue("@bentuk", cbBentuk.Text);
                cmd.Parameters.AddWithValue("@panjang", txtPanjang.Text);
                cmd.Parameters.AddWithValue("@lebar", txtLebar.Text);
                cmd.Parameters.AddWithValue("@luas", txtLuas.Text);
                cmd.Parameters.AddWithValue("@harga", txtHarga.Text);
                cmd.Parameters.AddWithValue("@status", cbStatus.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Data berhasil diubah");

                LoadData();
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "Hapus data ini?",
                "Konfirmasi",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                try
                {
                    conn.Open();

                    string query =
                        "DELETE FROM kavling WHERE id_kavling=@id";

                    MySqlCommand cmd =
                        new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@id", txtId.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Data berhasil dihapus");

                    LoadData();
                    ResetForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                string query = @"SELECT * FROM kavling
            WHERE id_kavling LIKE @cari
            OR nama_kavling LIKE @cari";

                MySqlDataAdapter da =
                    new MySqlDataAdapter(query, conn);

                da.SelectCommand.Parameters.AddWithValue(
                    "@cari",
                    "%" + txtCari.Text + "%");

                DataTable dt = new DataTable();

                da.Fill(dt);

                dgvKavling.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnSortLuas_Click(object sender, EventArgs e)
        {
            DataTable dt =
                (DataTable)dgvKavling.DataSource;

            dt.DefaultView.Sort = "luas DESC";
        }

        private void btnSortHarga_Click(object sender, EventArgs e)
        {
            DataTable dt =
                (DataTable)dgvKavling.DataSource;

            dt.DefaultView.Sort = "harga DESC";
        }

        private void dgvKavling_CellClick(object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row =
                    dgvKavling.Rows[e.RowIndex];

                txtId.Text =
                    row.Cells["id_kavling"].Value.ToString();

                txtNama.Text =
                    row.Cells["nama_kavling"].Value.ToString();

                cbBentuk.Text =
                    row.Cells["bentuk"].Value.ToString();

                txtPanjang.Text =
                    row.Cells["panjang"].Value.ToString();

                txtLebar.Text =
                    row.Cells["lebar"].Value.ToString();

                txtLuas.Text =
                    row.Cells["luas"].Value.ToString();

                txtHarga.Text =
                    row.Cells["harga"].Value.ToString();

                cbStatus.Text =
                    row.Cells["status_kavling"].Value.ToString();
            }
        }

        private void HitungStatistik()
        {
            int totalData = 0;
            double totalLuas = 0;
            int terjual = 0;
            int tersedia = 0;

            foreach (DataGridViewRow row in dgvKavling.Rows)
            {
                if (row.IsNewRow) continue;

                totalData++;

                totalLuas +=
                    Convert.ToDouble(row.Cells["luas"].Value);

                string status =
                    row.Cells["status_kavling"]
                    .Value.ToString();

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

        private void dgvKavling_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTotalTerjual_Click(object sender, EventArgs e)
        {
            // Intentionally left empty: label click does not need to perform any action.
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
