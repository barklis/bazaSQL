using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bazy_danych
{
    class Program
    {
        static void Main(string[] args)
        {
            string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Programing\\CS\\bazaSQL\\Bazy_danych\\Bazy_danych\\Database1.mdf;Integrated Security=True;";
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connString;
            conn.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM Phones", conn);
            SqlCommand command2 = new SqlCommand("INSERT INTO Phones(Name, Surname, Number) VALUES ('Stanisław','Nowak',512347112)", conn);
            Console.WriteLine("Table before:");
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Console.WriteLine(String.Format("{0}\t|{1}\t|{2}\t|{3}",
                        reader[0], reader[1], reader[2], reader[3]));
                }
            }

            command.ExecuteNonQuery();
            command2.ExecuteNonQuery();

            Console.WriteLine("Table after:");
            using (SqlDataReader reader=command.ExecuteReader()){
                while(reader.Read()){
                    Console.WriteLine(String.Format("{0}\t|{1}\t|{2}\t|{3}",
                        reader[0],reader[1],reader[2],reader[3]));
                }
            }
            conn.Close();
            Console.ReadKey();

        }
    }
}
