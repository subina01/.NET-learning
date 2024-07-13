using System.Data;
using System.Data.SqlClient;
using System.Configuration;

class Program
{
    static void Main(string[] args)
    {
        
        try
        {
            string cs = "Data Source=DESKTOP-ABAT3M5 ;Initial Catalog=ADOConnect; Integrated Security=True";
            SqlConnection con = new SqlConnection(cs);
            string query = "select * from STUDENTS";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable Students = new DataTable();
            sda.Fill(Students);
            Console.WriteLine("orignal");
            foreach (DataRow dr in Students.Rows)
            {
                Console.WriteLine(dr["ID"] + " " + dr["NAMES"] + " " + dr["ADDRESS"] + " " + dr["ROLLNO"]);
            }
            DataTable Cpy = Students.Copy();
            foreach (DataRow dr in Cpy.Rows)
            {
                Console.WriteLine(dr["ID"] + " " + dr["NAMES"] + " " + dr["ADDRESS"] + " " + dr["ROLLNO"]);
            }

            DataTable clonedatable = Students.Clone();
            if(clonedatable.Rows.Count>0) {
                Console.WriteLine("found rows");
            }
            else
            {
                Console.WriteLine("Rows NOT FOUND");
                clonedatable.Rows.Add(1, "saba", "kathmandu", "23");
                clonedatable.Rows.Add(2, "nirvana", "Pokhara", "24");
                foreach (DataRow dr in clonedatable.Rows)
                {
                    Console.WriteLine(dr["ID"] + " " + dr["NAMES"] + " " + dr["ADDRESS"] + " " + dr["ROLLNO"]);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}