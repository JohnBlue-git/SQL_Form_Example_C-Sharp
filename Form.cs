/*
Auther: John Blue
Time: 2022/5
Platform: VS2017
Object: to use SQL with WinForm

 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;// for Directory.GetCurrentDirectory()
using System.Data.SqlClient;

namespace SQL_Form_Example
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();

            // assign Index with Table size
            string queryString = "SELECT COUNT(Id) FROM dbo.[Table];";// to COUNT how many elment
            using (SqlCommand command = new SqlCommand(queryString, connectionString))
            {
                try {
                    command.Connection.Open();
                    Index = (Int32)command.ExecuteScalar();//textBox.Text = Index.ToString();
                    command.Connection.Close();
                }
                catch (SqlException e)
                {
                    textBox.Text = e.ToString();
                }
            }
        }

        ////// variable
        private int Index; 

        // Directory.GetCurrentDirectory() is the path of the Debug folder
        // AppDomain.CurrentDomain.BaseDirectory.Length - 10 since \bin\Debug is ten
        private SqlConnection connectionString = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Directory.GetCurrentDirectory().Substring(0, AppDomain.CurrentDomain.BaseDirectory.Length - 11) + @"\Database.mdf;Integrated Security=True");

        // if this project is deployed as .exe
        //private SqlConnection connectionString = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Directory.GetCurrentDirectory() + @"\Database.mdf;Integrated Security=True");

        ////// SQL method 
        private void InsertCommand(string Name = "NAN")// give an optional value "NAN", but somhow it didn't work
        {
            string queryString = "SET IDENTITY_INSERT dbo.[Table] ON;";// !!! have to turn ON insertion option

            connectionString.Open();
            using (SqlCommand command = new SqlCommand(queryString, connectionString))
            {
                try
                {
                    command.ExecuteNonQuery();

                    command.Parameters.Clear();
                    command.CommandText = "INSERT INTO dbo.[Table] (Id, Name) VALUES (" + (++Index).ToString() + ",'" + Name + "');";
                    command.CommandText = "INSERT INTO dbo.[Table] (Id, Name) VALUES (" + (++Index).ToString() + ",'" + Name + "');";
                    // only Name is not work
                    //command.CommandText = "INSERT INTO dbo.[Table] (Name) VALUES ('" + Name + "');";
                    command.ExecuteNonQuery();
                }
                catch (SqlException e)
                {
                    textBox.Text = e.ToString();
                }
            }
            connectionString.Close();
        }

        ////// Button method
        private void Touch_Grid(object sender, EventArgs e)
        {
            string queryString = "SELECT * FROM dbo.[Table];";

            connectionString.Open();
            using (SqlDataAdapter command = new SqlDataAdapter(queryString, connectionString))
            {
                DataTable dt = new DataTable();
                command.Fill(dt);
                DataGrid.DataSource = dt;
            }
            connectionString.Close();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            InsertCommand(textBox.Text);
        }
    }
}
