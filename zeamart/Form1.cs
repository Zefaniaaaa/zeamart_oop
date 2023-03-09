using MySql.Data.MySqlClient;
using System.Data;
using System.IO;

namespace zeamart
{
    public partial class Form1 : Form
    {
        int i = 0;

        MySqlConnection koneksi = Connections.getConnection();
        DataTable dataTable = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        public DataTable getDataBuah()
        {
            dataTable.Reset();
            dataTable = new DataTable();
            using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM buah", koneksi))
            {
                koneksi.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                dataTable.Load(reader);
            }
            return dataTable;
        }

        public void filldataTable()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.RowTemplate.Height = 200;
            dataGridView1.DataSource = getDataBuah();
            Column1.DataPropertyName = "id";
            Column2.DataPropertyName = "nama";
            Column3.DataPropertyName = "berat";
            Column4.DataPropertyName = "kadaluarsa";
            Column5.DataPropertyName = "harga";
            Column6.DataPropertyName = "stok";
            Column7.DataPropertyName = "gambar";
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            filldataTable();
        }

        public void resetIncrement()
        {
            MySqlScript script = new MySqlScript(koneksi, "SET @id :=0; Update buah SET id = @id := (@id+1); " +
                "ALTER TABLE buah AUTO_INCREMENT = 1;");
            script.Execute();
        }

        public void searchData(string ValueToFind)
        {
            string searchQuery = "SELECT * FROM buah WHERE CONCAT (nama, berat, kadaluarsa, harga, stok) LIKE '%" + ValueToFind + "%'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(searchQuery, koneksi);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void b_save_Click(object sender, EventArgs e)
        {
            // Convert image to byte array
            byte[] imageData;
            using (MemoryStream ms = new MemoryStream())
            {
                p_image.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                imageData = ms.ToArray();
            }
            MySqlCommand cmd;

            try
            {
                resetIncrement();

                cmd = koneksi.CreateCommand();
                cmd.CommandText = "insert into buah(nama, berat, kadaluarsa, harga, stok, gambar) VALUE (@nama, @berat, @kadaluarsa, @harga, @stok, @image)";
                cmd.Parameters.AddWithValue("@nama", t_nama.Text);
                cmd.Parameters.AddWithValue("@berat", t_berat.Text);
                cmd.Parameters.AddWithValue("@kadaluarsa", t_kadaluarsa.Text);
                cmd.Parameters.AddWithValue("@harga", t_harga.Text);
                cmd.Parameters.AddWithValue("@stok", t_stok.Text);
                cmd.Parameters.AddWithValue("@image", imageData);

                cmd.ExecuteNonQuery();
                koneksi.Close();
                dataTable.Clear();
                filldataTable();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error karena = " + ex);
            }
        }

        private void b_browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openimage = new OpenFileDialog();
            if (openimage.ShowDialog() == DialogResult.OK)
            {
                p_image.Image = new Bitmap(openimage.FileName);
                p_image.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void b_edit_Click(object sender, EventArgs e)
        {
            // Convert image to byte array
            MemoryStream ms = new MemoryStream();
            p_image.Image.Save(ms, p_image.Image.RawFormat);
            byte[] img = ms.ToArray();

            MySqlCommand cmd;
            // mengecek apakah ada field yang kosong
            if ((t_id.Text == string.Empty || t_nama.Text == string.Empty || t_berat.Text == string.Empty || t_kadaluarsa.Text == string.Empty || t_harga.Text == string.Empty || t_stok.Text == string.Empty))
            {
                MessageBox.Show("Tolong Isi Semua Field!", "CRUD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                cmd = koneksi.CreateCommand();
                cmd.CommandText = "UPDATE buah set nama=@nama,berat=@berat,kadaluarsa=@kadaluarsa,harga=@harga,stok=@stok,gambar=@image where id=@id";
                cmd.Parameters.AddWithValue("@id", t_id.Text);
                cmd.Parameters.AddWithValue("@nama", t_nama.Text);
                cmd.Parameters.AddWithValue("@berat", t_berat.Text);
                cmd.Parameters.AddWithValue("@kadaluarsa", t_kadaluarsa.Text);
                cmd.Parameters.AddWithValue("@harga", t_harga.Text);
                cmd.Parameters.AddWithValue("@stok", t_stok.Text);
                cmd.Parameters.AddWithValue("@image", img);
                cmd.ExecuteNonQuery();
                //
                i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Data Berhasil Diupdate!", "CRUD", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Data Gagal Diupdate!", "CRUD", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                koneksi.Close();
                filldataTable();
            }
        }

        private void b_delete_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd;
            cmd = koneksi.CreateCommand();
            cmd.CommandText = "DELETE FROM buah WHERE id=@id";
            cmd.Parameters.AddWithValue("@id", t_id.Text);
            i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                MessageBox.Show("Data Berhasil Dihapus!", "CRUD", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data Gagal Dihapus!", "CRUD", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            koneksi.Close();
            resetIncrement();
            filldataTable();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentCell.RowIndex.ToString());
            t_id.Text = dataGridView1.Rows[id].Cells[0].Value.ToString();
            t_nama.Text = dataGridView1.Rows[id].Cells[1].Value.ToString();
            t_berat.Text = dataGridView1.Rows[id].Cells[2].Value.ToString();
            t_kadaluarsa.Text = dataGridView1.Rows[id].Cells[3].Value.ToString();
            t_harga.Text = dataGridView1.Rows[id].Cells[4].Value.ToString();
            t_stok.Text = dataGridView1.Rows[id].Cells[5].Value.ToString();

            Byte[] img = (Byte[])dataGridView1.CurrentRow.Cells[6].Value;
            MemoryStream ms = new MemoryStream(img);
            p_image.Image = Image.FromStream(ms);
        }

        private void t_search_TextChanged(object sender, EventArgs e)
        {
            searchData(t_search.Text);
        }
    }
}