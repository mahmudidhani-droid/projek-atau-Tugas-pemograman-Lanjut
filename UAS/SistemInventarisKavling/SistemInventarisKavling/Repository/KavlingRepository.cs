using MySqlConnector;
using SistemInventarisKavling.Data;
using SistemInventarisKavling.Domain;
using System;
using System.Collections.Generic;
using System.Data;

namespace SistemInventarisKavling.Repository
{
    public class KavlingRepository : IKavlingRepository
    {
        private readonly DbConnection db = new DbConnection();

        public List<Kavling> GetAll()
        {
            List<Kavling> list = new List<Kavling>();

            using (var conn = db.GetConnection())
            {
                conn.Open();

                string query = "SELECT * FROM kavling";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                MySqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    list.Add(new Kavling
                    {
                        Id = rd["id_kavling"].ToString(),
                        Nama = rd["nama_kavling"].ToString(),
                        Bentuk = rd["bentuk"].ToString(),
                        Panjang = Convert.ToDouble(rd["panjang"]),
                        Lebar = Convert.ToDouble(rd["lebar"]),
                        Luas = Convert.ToDouble(rd["luas"]),
                        Harga = Convert.ToDecimal(rd["harga"]),
                        Status = rd["status_kavling"].ToString()
                    });
                }
            }

            return list;
        }

        public Kavling GetById(string id)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();

                string query =
                    "SELECT * FROM kavling WHERE id_kavling=@id";

                MySqlCommand cmd =
                    new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", id);

                MySqlDataReader rd =
                    cmd.ExecuteReader();

                if (rd.Read())
                {
                    return new Kavling
                    {
                        Id = rd["id_kavling"].ToString(),
                        Nama = rd["nama_kavling"].ToString(),
                        Bentuk = rd["bentuk"].ToString(),
                        Panjang = System.Convert.ToDouble(rd["panjang"]),
                        Lebar = System.Convert.ToDouble(rd["lebar"]),
                        Luas = System.Convert.ToDouble(rd["luas"]),
                        Harga = System.Convert.ToDecimal(rd["harga"]),
                        Status = rd["status_kavling"].ToString()
                    };
                }
            }

            return null;
        }

        public void Insert(Kavling k)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();

                string query = @"INSERT INTO kavling
(id_kavling,nama_kavling,bentuk,panjang,lebar,luas,harga,status_kavling)
VALUES
(@id,@nama,@bentuk,@panjang,@lebar,@luas,@harga,@status)";

                MySqlCommand cmd =
                    new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", k.Id);
                cmd.Parameters.AddWithValue("@nama", k.Nama);
                cmd.Parameters.AddWithValue("@bentuk", k.Bentuk);
                cmd.Parameters.AddWithValue("@panjang", k.Panjang);
                cmd.Parameters.AddWithValue("@lebar", k.Lebar);
                cmd.Parameters.AddWithValue("@luas", k.Luas);
                cmd.Parameters.AddWithValue("@harga", k.Harga);
                cmd.Parameters.AddWithValue("@status", k.Status);

                cmd.ExecuteNonQuery();
            }
        }

        public void Update(Kavling k)
        {
            using (var conn = db.GetConnection())
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

                cmd.Parameters.AddWithValue("@id", k.Id);
                cmd.Parameters.AddWithValue("@nama", k.Nama);
                cmd.Parameters.AddWithValue("@bentuk", k.Bentuk);
                cmd.Parameters.AddWithValue("@panjang", k.Panjang);
                cmd.Parameters.AddWithValue("@lebar", k.Lebar);
                cmd.Parameters.AddWithValue("@luas", k.Luas);
                cmd.Parameters.AddWithValue("@harga", k.Harga);
                cmd.Parameters.AddWithValue("@status", k.Status);

                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(string id)
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();

                string query =
                    "DELETE FROM kavling WHERE id_kavling=@id";

                MySqlCommand cmd =
                    new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();
            }
        }

        public List<Kavling> Search(string keyword)
        {
            List<Kavling> list = new List<Kavling>();

            using (var conn = db.GetConnection())
            {
                conn.Open();

                string query = @"SELECT * FROM kavling
WHERE id_kavling LIKE @cari
OR nama_kavling LIKE @cari";

                MySqlCommand cmd =
                    new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@cari", "%" + keyword + "%");

                MySqlDataReader rd =
                    cmd.ExecuteReader();

                while (rd.Read())
                {
                    list.Add(new Kavling
                    {
                        Id = rd["id_kavling"].ToString(),
                        Nama = rd["nama_kavling"].ToString(),
                        Bentuk = rd["bentuk"].ToString(),
                        Panjang = System.Convert.ToDouble(rd["panjang"]),
                        Lebar = System.Convert.ToDouble(rd["lebar"]),
                        Luas = System.Convert.ToDouble(rd["luas"]),
                        Harga = System.Convert.ToDecimal(rd["harga"]),
                        Status = rd["status_kavling"].ToString()
                    });
                }
            }

            return list;
        }
        public List<Kavling> Filter(string filter, int page, int pageSize)
        {
            List<Kavling> list = new List<Kavling>();

            using (var conn = db.GetConnection())
            {
                conn.Open();

                int offset = (page - 1) * pageSize;

                string query = "SELECT * FROM kavling";

                switch (filter)
                {
                    case "Status: Tersedia":
                        query += " WHERE status_kavling='Tersedia'";
                        break;

                    case "Status: Terjual":
                        query += " WHERE status_kavling='Terjual'";
                        break;

                    case "Harga Tertinggi":
                        query += " ORDER BY harga DESC";
                        break;

                    case "Harga Terendah":
                        query += " ORDER BY harga ASC";
                        break;
                }

                query += $" LIMIT {pageSize} OFFSET {offset}";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                MySqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    list.Add(new Kavling
                    {
                        Id = rd["id_kavling"].ToString(),
                        Nama = rd["nama_kavling"].ToString(),
                        Bentuk = rd["bentuk"].ToString(),
                        Panjang = Convert.ToDouble(rd["panjang"]),
                        Lebar = Convert.ToDouble(rd["lebar"]),
                        Luas = Convert.ToDouble(rd["luas"]),
                        Harga = Convert.ToDecimal(rd["harga"]),
                        Status = rd["status_kavling"].ToString()
                    });
                }
            }

            return list;
        }
        public int GetTotalData()
        {
            using (var conn = db.GetConnection())
            {
                conn.Open();

                string query = "SELECT COUNT(*) FROM kavling";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }
        public List<Kavling> GetAll(int page, int pageSize)
        {
            List<Kavling> list = new List<Kavling>();

            using (var conn = db.GetConnection())
            {
                conn.Open();

                int offset = (page - 1) * pageSize;

                string query = $"SELECT * FROM kavling LIMIT {pageSize} OFFSET {offset}";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                MySqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    list.Add(new Kavling
                    {
                        Id = rd["id_kavling"].ToString(),
                        Nama = rd["nama_kavling"].ToString(),
                        Bentuk = rd["bentuk"].ToString(),
                        Panjang = Convert.ToDouble(rd["panjang"]),
                        Lebar = Convert.ToDouble(rd["lebar"]),
                        Luas = Convert.ToDouble(rd["luas"]),
                        Harga = Convert.ToDecimal(rd["harga"]),
                        Status = rd["status_kavling"].ToString()
                    });
                }
            }

            return list;
        }
        public List<Kavling> SortLuas()
        {
            List<Kavling> list = new List<Kavling>();

            using (var conn = db.GetConnection())
            {
                conn.Open();

                string query = "SELECT * FROM kavling ORDER BY luas DESC";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                MySqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    list.Add(new Kavling
                    {
                        Id = rd["id_kavling"].ToString(),
                        Nama = rd["nama_kavling"].ToString(),
                        Bentuk = rd["bentuk"].ToString(),
                        Panjang = Convert.ToDouble(rd["panjang"]),
                        Lebar = Convert.ToDouble(rd["lebar"]),
                        Luas = Convert.ToDouble(rd["luas"]),
                        Harga = Convert.ToDecimal(rd["harga"]),
                        Status = rd["status_kavling"].ToString()
                    });
                }
            }

            return list;
        }
        public List<Kavling> SortHarga()
        {
            List<Kavling> list = new List<Kavling>();

            using (var conn = db.GetConnection())
            {
                conn.Open();

                string query = "SELECT * FROM kavling ORDER BY harga DESC";

                MySqlCommand cmd = new MySqlCommand(query, conn);

                MySqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    list.Add(new Kavling
                    {
                        Id = rd["id_kavling"].ToString(),
                        Nama = rd["nama_kavling"].ToString(),
                        Bentuk = rd["bentuk"].ToString(),
                        Panjang = Convert.ToDouble(rd["panjang"]),
                        Lebar = Convert.ToDouble(rd["lebar"]),
                        Luas = Convert.ToDouble(rd["luas"]),
                        Harga = Convert.ToDecimal(rd["harga"]),
                        Status = rd["status_kavling"].ToString()
                    });
                }
            }

            return list;
        }
    }
}