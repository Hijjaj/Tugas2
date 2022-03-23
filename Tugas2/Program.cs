using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Tugas2
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        public void InsertTable()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=LAPTOP-OG8P1VHL\\HIJJAJ;database=sewatoko;Integrated Security = TRUE");
                con.Open();
            } catch (Exception e)
            {

            }
        }
    }
}
