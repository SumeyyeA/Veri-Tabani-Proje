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
    class DBIslemleri
    {
        NpgsqlConnection baglan = new NpgsqlConnection("Host=localhost;Port=5433;Username=postgres;Password=20013463;Database=EczaneOtomasyonu");
        NpgsqlCommand komut = new NpgsqlCommand();
        NpgsqlDataAdapter adtr = new NpgsqlDataAdapter();
        DataSet ds = new DataSet();

      
    }
}
