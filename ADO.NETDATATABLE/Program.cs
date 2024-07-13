using System.Data;

namespace ADODATATABLE
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DataTable Students= new DataTable("STUDENTS");
                DataColumn id = new DataColumn("ID");
                id.Caption = "STU_ID";
                id.DataType = typeof(int);
                id.AllowDBNull = false;
                id.AutoIncrement = true;
                id.AutoIncrementSeed = 1;
                id.AutoIncrementStep = 1;
                Students.Columns.Add(id);


                
                DataColumn Name = new DataColumn("NAME");
                Name.Caption = "STU_Name";
                Name.DataType = typeof(string);
                Name.AllowDBNull = false;
                Name.MaxLength = 50;
                Students.Columns.Add(Name);


                DataColumn gender = new DataColumn("Gender");
                gender.Caption = "STU_Gender";
                gender.DataType = typeof(string);
                gender.AllowDBNull = false;
                gender.MaxLength = 19;
                Students.Columns.Add(gender);

                DataRow row1 = Students.NewRow();
               // row1["id"] = 1;
                row1["name"] = "Subina";
                row1["gender"] ="female";

                Students.Rows.Add(row1);
                Students.Rows.Add(null, "Anu", "Female");
                Students.Rows.Add(null, "Prativa", "Female");
                Students.Rows.Add(null, "Subodh", "Male");
                Students.PrimaryKey = new DataColumn[] { id };

                foreach(DataRow row in Students.Rows)
                {
                    Console.WriteLine(row["id"]+" "+ row["name"]+" " + row["gender"]);
                }
            }
            catch (Exception ex)
            {
            Console.WriteLine(ex.Message);
            }

        }
    }
}