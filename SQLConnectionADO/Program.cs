using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Specialized;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Connection();
            Console.ReadLine();
        }

       static void Connection()
        {
           // string cs = "Data Source=DESKTOP-ABAT3M5; Initial Catalog=ADOConnect; Integrated Security=True;";

            string cs = ConfigurationManager.ConnectionStrings["adbc"].ConnectionString;
            //SqlConnection con = new SqlConnection(cs);

            SqlConnection con = null;
            try
            {
               // con.Open();
                //if (con.State == ConnectionState.Open)
                //{
                  //  Console.WriteLine("Connection has been created sucessfully!");
                //}
                using(con = new SqlConnection(cs))
                {
                    //EXECUTE NONQUERY
                    //Console.WriteLine("ENTER ID:");
                    //string id = Console.ReadLine();
                    //Console.WriteLine("ENTER YOUR NAME:");
                    //string name = Console.ReadLine();
                    //Console.WriteLine("ENTER YOUR ADDRESS:");
                    //string address = Console.ReadLine();
                    //Console.WriteLine("ENTER YOUR ROLLNO:");
                    //string roll= Console.ReadLine();

                    //string query = "INSERT INTO STUDENTS VALUES( @id, @name, @address, @roll)";
                    //string query = "update STUDENTS set NAMES=@name, ADDRESS=@address, ROLLNO=@roll WHERE ID=@id";
                    //string query = "DELETE FROM STUDENTS  WHERE ID=@id";
                    string query = "SELECT max(ROLLNO) from STUDENTS";
                    SqlCommand cmd = new SqlCommand(query, con);
                   // cmd.Parameters.AddWithValue("@id", id);
                    //cmd.Parameters.AddWithValue ("@name", name);
                    //cmd.Parameters.AddWithValue("@address", address);
                    //cmd.Parameters.AddWithValue("@roll", roll);

                    con.Open();
                   int a = Convert.ToInt32(cmd.ExecuteScalar());
                    Console.WriteLine(a);
                   // int a = cmd.ExecuteNonQuery();
                    //if(a>0)
                    //{
                    //    Console.WriteLine("DATA HAS BEEN INSERTED SUCESSFULLY");
                    //}
                    //else { Console.WriteLine("DATA INSERTION FAILED...."); }
                    //if (a > 0)
                    //{
                    //   Console.WriteLine("DATA HAS BEEN UPDATED SUCESSFULLY");
                    //}
                    //else { Console.WriteLine("DATA UPDATE FAILED...."); }
                    //if (a > 0)
                    //{
                    //    Console.WriteLine("DATA HAS BEEN DELETED SUCESSFULLY");
                    //}
                    //else { Console.WriteLine("DATA DELETION FAILED...."); }


                    //EXECUTE READER();
                    //string query = "select * from STUDENTS";
                    //SqlCommand cmd =new SqlCommand(query, con);
                    //con.Open();
                    //SqlDataReader dr = cmd.ExecuteReader();
                    //while (dr.Read())
                    //{
                    //    Console.WriteLine("ID="+ dr["ID"]+" " + "NAMES=" + dr["NAMES"] +" "+ "ADDRESS=" + dr["ADDRESS"]+" " + "ROLLNO=" + dr["ROLLNO"]);
                    //}
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close(); 
            }    
            
        }
    }
}