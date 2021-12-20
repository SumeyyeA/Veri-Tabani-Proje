using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;


namespace eczane
{
    class Db_Fonk
    {
        /*
        NpgsqlConnection baglan = new NpgsqlConnection("Server=127.0.0.1;User Id=postgres; " +
            "Password=20013463;Database=EczaneOtomasyonu;");
        NpgsqlCommand komut = new NpgsqlCommand();
        NpgsqlDataAdapter adtr = new NpgsqlDataAdapter();
        DataSet ds = new DataSet();

        public DataSet ilacAra(string ad)
        {
            baglan.Open();
            string query = "SELECT Ilaclar.ilacId as [Ilaç ID], Ilaclar.UrunAdi as [Ürün Adı]," +
                "  Ilaclar.Recete as [Reçete Türü]," +
                " Ilaclar.birimFiyati FROM Ilaclar " +
                " Ilaclar.uretimTarihi FROM Ilaclar " +
                " Ilaclar.adet FROM Ilaclar " +
                "WHERE (((Ilaclar.UrunAdi) Like '%" + ad + "%'))";

            Console.WriteLine(query);
            NpgsqlDataAdapter adtr = new NpgsqlDataAdapter(query, baglan);
            ds.Clear();
            adtr.Fill(ds, "Ilaclar");
            adtr.Dispose();
            baglan.Close();

            return ds;
        }*/
}
