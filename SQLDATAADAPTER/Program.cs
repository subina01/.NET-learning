using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace SqlDATADOPTER
{
    class Program
    {
        static void Main(string[] args)
        {
            string cs = "Data Source=DESKTOP-ABAT3M5 ; Initial Catalog = ADOConnect; Integrated Security= True";
            SqlConnection con = new SqlConnection(cs);
            SqlDataAdapter sda =  new SqlDataAdapter("SELECT * FROM STUDENTS", con);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Console.WriteLine("{0} {1} {2} {3}", dr[0], dr[1], dr[2], dr[3]);
                
            }
            
            Console.WriteLine("------------------------------------------------------------------------------------------");
            //DataTable dt = new DataTable();
            //sda.Fill(dt);
            //foreach (DataRow dr in dt.Rows)
            //{
            //    Console.WriteLine("{0} {1} {2} {3}", dr[0], dr[1], dr[2], dr[3]);

            //}
            Console.ReadKey();
        }
    }
}