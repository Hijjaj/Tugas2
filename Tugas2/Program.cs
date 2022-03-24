using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Tugas2
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Tampil();
        }
        public void Tampil()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=LAPTOP-OG8P1VHL\\HIJJAJ;database=sewatoko;Integrated Security = TRUE");
                con.Open();
                Console.WriteLine("Koneksi Sukses");
                var tabel = new DataTable("TabelToko");

                var cmd = new SqlCommand("Select Id_toko,No_toko,Nama_toko,P_perbulan,P_pertahun,Durasi,Tanggal_bayar From Tabel_Toko", con);
                var r = cmd.ExecuteReader();
                tabel.Load(r);
                con.Close();

                foreach (DataRow baris in tabel.Rows)
                {
                    Console.WriteLine("Tabel Toko =");
                    Console.WriteLine(baris[0]);
                    Console.WriteLine(baris["No_toko"]);
                    Console.WriteLine(baris["Nama_toko"]);
                    Console.WriteLine(baris["P_perbulan"]);
                    Console.WriteLine(baris["P_pertahun"]);
                    Console.WriteLine(baris["Durasi"]);
                    Console.WriteLine(baris["Tanggal_bayar"]);
 
                }
                con.Open();
                Console.WriteLine("Masukkan Id toko: ");
                string idtoko = Console.ReadLine();
                Console.WriteLine("Masukkan No toko: ");
                string notoko = Console.ReadLine();
                Console.WriteLine("Masukkan nama toko: ");
                string namatoko = Console.ReadLine();
                string sql = "INSERT INTO Tabel_Toko(Id_toko,No_toko,Nama_toko) VALUES ('"+idtoko+"','"+notoko+"';'"+namatoko+"')";
                cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
            } catch (Exception e)
            {
                Console.WriteLine("Gagal" + e);
                Console.ReadKey();
            }
            finally
            {
                con.Close();
            }
        }
        
    }
}
