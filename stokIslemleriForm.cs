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
    public partial class stokIslemleriForm : Form
    {
        NpgsqlConnection baglan = new NpgsqlConnection("Host=localhost;Port=5433;Username=postgres;Password=20013463;Database=EczaneOtomasyonu");
        NpgsqlCommand komut = new NpgsqlCommand();
        NpgsqlDataAdapter adtr = new NpgsqlDataAdapter();
        DataSet ds = new DataSet();

        DBIslemleri DBIslemleri = new DBIslemleri();
        public stokIslemleriForm()
        {
            InitializeComponent();
        }

        private void stokIslemleriForm_Load(object sender, EventArgs e)
        {
            NpgsqlConnection baglan = new NpgsqlConnection("Host=localhost;Port=5433;Username=postgres;Password=20013463;Database=EczaneOtomasyonu");
            baglan.Open();
            
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void stok_Click(object sender, EventArgs e)
        {

            DBIslemleri DBIslemleri = new DBIslemleri();
            NpgsqlDataAdapter adtr = new NpgsqlDataAdapter("SELECT * FROM ilaclar", baglan);
            
            adtr.Fill(ds, "ilaclar");

            dataGridView2.DataSource = ds.Tables["ilaclar"];

            adtr.Dispose();

            baglan.Close();

        }

        private void ekle_Click(object sender, EventArgs e)
        {
            DBIslemleri DBIslemleri = new DBIslemleri();
            komut = new NpgsqlCommand();
            baglan.Open();
            komut.Connection = baglan;
            komut.CommandText = "INSERT INTO ilaclar(ilacid,ilacadi,birimfiyati,adet,snkt,barkod) VALUES ('" + ilacID.Text + "','" + ilacAdi.Text + "','" + fiyat.Text + "','" + adet.Text +"','"+uretimTarihi.Text+"','"+barkod.Text+ "')";
            komut.ExecuteNonQuery(); 
            baglan.Close();
           // dataGridView2.Rows.Clear();
            stok_Click(sender,e);
            ilacID.Clear(); ilacAdi.Clear(); fiyat.Clear(); adet.Clear(); uretimTarihi.Clear(); barkod.Clear();
        }

        private void sil_Click(object sender, EventArgs e)
        {
            DBIslemleri DBIslemleri = new DBIslemleri();
            baglan.Open();
            komut.Connection = baglan;
            komut.CommandText = "DELETE FROM ilaclar WHERE ilacid LIKE'" +ilacID.Text + "%'";
            komut.ExecuteNonQuery();
            komut.Dispose();
            baglan.Close();
            ds.Clear();
            stok_Click(sender, e);
        }

        private void guncelleme_Click(object sender, EventArgs e)
        {
            DBIslemleri DBIslemleri = new DBIslemleri();
            komut = new NpgsqlCommand();
            baglan.Open();
            komut.Connection = baglan;
            komut.CommandText = "UPDATE ilaclar SET ilacadi='" + ilacAdi.Text + "', birimfiyati='" + fiyat.Text + "', adet='" + adet.Text + "', snkt='" + uretimTarihi.Text +"',barkod='"+barkod.Text+"'WHERE ilacid LIKE'"+ilacID.Text+"%'";
            komut.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show(" kayıt güncellendi");
            ds.Clear();
            stok_Click(sender, e);
        }
    }
}
