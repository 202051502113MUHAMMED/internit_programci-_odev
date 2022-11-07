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

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        MySql.Data.MySqlClient.MySqlConnection conn;

        public Form1()
        {
            InitializeComponent();

            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection();
                conn.ConnectionString = "server=127.0.0.1;uid=root;pwd=;database=gorsel_programalama";
                conn.Open();    

            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            yazarListele();
        }

        public void yazarListele()
        {

            listBox1.Items.Clear();

            string sql = "SELECT id, isim FROM yazarlar";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                listBox1.Items.Add(rdr[1]);

            }
            rdr.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO `yazarlar`(`isim`) VALUES ('"+ textBox1.Text +"')";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();

            textBox1.Text = "";

            yazarListele();
        }
    }
}
