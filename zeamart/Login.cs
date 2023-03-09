using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace zeamart
{
    public partial class Login : Form
    {
        private MySqlCommand cmd;
        private DataSet ds;
        private MySqlDataAdapter da;
        private MySqlDataReader rd;

        Connections koneksi = new Connections();
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void b_login_Click(object sender, EventArgs e)
        {
            MySqlConnection koneksi = Connections.getConnection();
            koneksi.Open();
            cmd = new MySqlCommand("Select * from login where username='" + t_username.Text + "' and password='" + t_password.Text + "'", koneksi);
            rd = cmd.ExecuteReader();
            rd.Read();
            if (rd.HasRows)
            {
                new Form1().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Maaf Username atau Password anda salah");
            }
        }
    }
}
