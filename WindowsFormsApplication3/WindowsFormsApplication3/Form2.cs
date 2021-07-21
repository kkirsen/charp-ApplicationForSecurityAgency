using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Net;
namespace WindowsFormsApplication3
{
    public partial class Form2 : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public Form2()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BM-holding.accdb;
Persist Security Info=False;";
        }

        private void Form2_Load(object sender, EventArgs e)  //D:\s
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;  
                string query = "select * from Objects";
                command.CommandText = query;

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    comboBox1.Items.Add(reader["company"].ToString());
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error  " + ex);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select * from Objects where company= '" + comboBox1.Text + "'";
                command.CommandText = query;

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                     textBox1.Text =reader["adress"].ToString();
                     textBox6.Text = reader["geolocation"].ToString();  
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error  " + ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select * from Objects where company= '" + comboBox1.Text + "'";
                command.CommandText = query;

                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    textBox6.Text = reader["geolocation"].ToString();
                    string url = textBox6.Text;
                    string url1 = "https://api.telegram.org/bot674959493:AAHkLQTfEMIC32LIg2SikB0OYGEqSOU0ypY/sendMessage?chat_id=-213592758&text=";
                    string url2 = url1 + url;
                    WebClient client = new WebClient();
                    WebProxy wp = new WebProxy("80.120.86.242:46771");
                    client.Proxy = wp;
                    string str = client.DownloadString(url2);
                    MessageBox.Show("Вызов отправлен бригаде.");
                }
               
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error  " + ex);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }
    }
}
