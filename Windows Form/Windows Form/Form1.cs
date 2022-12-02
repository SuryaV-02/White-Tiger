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

namespace Windows_Form
{
    public partial class Form1 : Form
    {
        const string Server = "localhost";
        const string Database = "FRUITSTALL";
        const string Table = "Fruits";
        const string Uid = "root";
        const string Password = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string FruitName = textBox1.Text.ToString().ToLower();
            string FruitCost = textBox2.Text.ToString();

            InsertIntoDatabase(FruitName, FruitCost);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FetchDataFromDB();
        }

        private void FetchDataFromDB()
        {
            const string ConnectionString = "SERVER=" + Server + ";DATABASE=" + Database + ";UID=" + Uid + ";PASSWORD=" + Password + ";";
            MySqlConnection conn = new MySqlConnection(ConnectionString);
            conn.Open();

            MySqlCommand FetchCmd = new MySqlCommand("SELECT * FROM " + Table, conn);

            MySqlDataReader DataReader = FetchCmd.ExecuteReader();

            string Data = "";
            string Intent = "     ";
            if(DataReader.HasRows)
            {
                while(DataReader.Read())
                {
                    Data += DataReader["ID"] + Intent + DataReader["NAME"] + Intent + DataReader["COST"] + Environment.NewLine;
                }

                textBox3.Text = Data;
            } else
            {
                textBox3.Text = "No fruits are available at this time!";
            }
        } 


        private void InsertIntoDatabase(string FruitName, string FruitCost)
        {
            const string ConnectionString = "SERVER=" + Server + ";DATABASE=" + Database + ";UID=" + Uid + ";PASSWORD=" + Password + ";";

            MySqlConnection Connection = new MySqlConnection(ConnectionString);

            Connection.Open();

            MySqlCommand InsertCommand = new MySqlCommand("INSERT INTO " + Table + " VALUES(@id,@name,@cost)", Connection);

            InsertCommand.Parameters.AddWithValue("@id", (new Random().Next(1000)).ToString());
            InsertCommand.Parameters.AddWithValue("@name", FruitName);
            InsertCommand.Parameters.AddWithValue("@cost", FruitCost);

            int InsertionResult = InsertCommand.ExecuteNonQuery();

            string message;
            if(InsertionResult > 0)
            {
                message = "Fruit " + FruitName + " of cost Rs." + FruitCost + " created Successfully!";
            } else
            {
                message = "Cannot create fruit " + FruitName;   
            }
            MessageBox.Show(message);

        }

        
    }
}
