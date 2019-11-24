using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Bazy_graphical
{
    public partial class Form1 : Form
    {
        string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Programing\\CS\\bazaSQL\\Bazy_graphical\\Bazy_graphical\\Database1.mdf;Integrated Security=True";
        SqlConnection conn;
        SqlCommand select_command;
        SqlCommand insert_command;
        SqlCommand delete_command;

        public Form1()
        {
            conn = new SqlConnection();
            conn.ConnectionString = connString;
            select_command = new SqlCommand("SELECT * FROM Measurements", conn);

            InitializeComponent();
        }


        private void insert_button_Click(object sender, EventArgs e)
        {
            conn.Open();

            insert_command = new SqlCommand("INSERT INTO Measurements(time,value,comment) VALUES ('"+DateTime.Now.ToString("h:mm:ss tt")+"','"+value_box.Text+"','"+comment_box.Text+"')", conn);
            select_command.ExecuteNonQuery();
            insert_command.ExecuteNonQuery();
            conn.Close();
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            conn.Open();

            delete_command = new SqlCommand("DELETE FROM Measurements WHERE value='"+value_box.Text+"'", conn);
            select_command.ExecuteNonQuery();
            delete_command.ExecuteNonQuery();
            conn.Close();
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter();
            sda.SelectCommand = select_command;
            DataTable dbdataset = new DataTable();
            sda.Fill(dbdataset);
            BindingSource bsource = new BindingSource();
            bsource.DataSource = dbdataset;
            sql_table.DataSource = dbdataset;
            sda.Update(dbdataset);

            
            list_id.Items.Clear();
            list_time.Items.Clear();
            list_value.Items.Clear();
            list_comment.Items.Clear();

            using (SqlDataReader reader = select_command.ExecuteReader())
            {
                while (reader.Read())
                {
                    if(!list_id.Items.Contains(reader[0]))
                    {
                        list_id.Items.Add(reader[0]);
                        list_time.Items.Add(reader[1]);
                        list_value.Items.Add(reader[2]);
                        list_comment.Items.Add(reader[3]);
                    }
                        

                }
            }
            conn.Close();
        }

       
    }
}
