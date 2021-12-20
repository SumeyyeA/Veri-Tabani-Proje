using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace eczane
{
    public partial class Form1 : Form
    {
        NpgsqlConnection baglan = new NpgsqlConnection("Host=localhost;Port=5433;Username=postgres;Password=20013463;Database=EczaneOtomasyonu");
            NpgsqlCommand komut = new NpgsqlCommand();
        NpgsqlDataAdapter adtr = new NpgsqlDataAdapter();
        DataSet ds = new DataSet();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            NpgsqlConnection baglan = new NpgsqlConnection("Host=localhost;Port=5433;Username=postgres;Password=20013463;Database=EczaneOtomasyonu");
            baglan.Open();
            NpgsqlCommand komut = new NpgsqlCommand();
            NpgsqlDataAdapter adtr = new NpgsqlDataAdapter();
            DataSet ds = new DataSet();

            
            

        }
        //8374973943 dataGridView1.Rows[0].Cells[8].Value.ToString()

        private void ara_Click(object sender, EventArgs e)
        {
            DBIslemleri DBIslemleri = new DBIslemleri();
            adtr = new NpgsqlDataAdapter("SELECT *FROM musteriler WHERE musteritc LIKE '" + textBox1.Text + "%'", baglan);
            ds = new DataSet();
            baglan.Open();
            adtr.Fill(ds, "musteriler");
            dataGridView1.DataSource = ds.Tables["musteriler"];
            baglan.Close();



            adtr = new NpgsqlDataAdapter("SELECT *FROM recete ", baglan);
            ds = new DataSet();
            baglan.Open();
            adtr.Fill(ds, "recete");
            dataGridView3.DataSource = ds.Tables["recete"];
            baglan.Close();

            label4.Text = dataGridView3.Rows[0].Cells[6].Value.ToString();
            
            
        }

        private void fiyat_Click(object sender, EventArgs e)
        {

        }

        private void satis_Click(object sender, EventArgs e)
        {
            DBIslemleri DBIslemleri = new DBIslemleri();
            


        }
    }
}
