using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eczane
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void satisIslem_Click(object sender, EventArgs e)
        {
            home h = new home();
            h.Close();
            Form1 f1 = new Form1();
            f1.Show();
            
        }

        private void stokIslemleri_Click(object sender, EventArgs e)
        {
            home h = new home();
            h.Hide();
            stokIslemleriForm stok = new stokIslemleriForm();
            stok.Show();

        }

        private void home_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:\\Users\\user\\source\\repos\\eczane\\eczane\\Properties\\vitamin1.png");
            pictureBox2.Image = Image.FromFile("C:\\Users\\user\\source\\repos\\eczane\\eczane\\Properties\\pharmacy1.png");
        }
    }
}
