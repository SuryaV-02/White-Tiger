using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Castor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            string server = "localhost";
            string database = "c_sharp";
            string username = "root";
            string password = "";

            string ConnectionString = "SERVER=" + server + ";DATABASE=" + database + ";UID=" + username + ";PASSWORD=" + password + ";";

            MySqlConnection conn = new MySqlConnection(ConnectionString);

            conn.Open();

            MySqlCommand cmd = new MySqlCommand("INSERT INTO test VALUES(@id,@username,@dept)", conn);

            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(textBox1.Text));
            cmd.Parameters.AddWithValue("@username", textBox2.Text);
            cmd.Parameters.AddWithValue("@dept", textBox3.Text);

            int res = cmd.ExecuteNonQuery();

            if (res > 0)
            {
                Console.WriteLine("Inserted Successfully");
                MessageBox.Show("Inserted");
            }
            else
            {
                MessageBox.Show("Error!!");
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            string server = "localhost";
            string database = "c_sharp";
            string username = "root";
            string password = "";

            string ConnectionString = "SERVER=" + server + ";DATABASE=" + database + ";UID=" + username + ";PASSWORD=" + password + ";";

            MySqlConnection conn = new MySqlConnection(ConnectionString);

            conn.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM test", conn);

            MySqlDataReader res =  cmd.ExecuteReader();

            Console.WriteLine("UID    NAME    DEPT");

            string text = "UID    NAME    DEPT" + Environment.NewLine;

            



            while (res.Read())
            {
                text += res["ID"] + "  " + res["NAME"] + "  " + res["DEPT"]+ Environment.NewLine ;                
            }

            textBox4.Text = text;
        }
    }
}
