using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Data.OleDb.OleDbConnection conn = new System.Data.OleDb.OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;" +
        @"Data source= F:\BESE\6th Semester\Software Construction\Labs\Lab 2\Library-Management-System-SC_Lab2\Library.accdb";

            try
            {
                conn.Open();
                String username = textBox1.Text.ToString();
                String Paswrd = textBox2.Text.ToString();

                String my_querry = "select * from tblMembers where UserName = '" + username + "' and Pasword = '" + Paswrd + "'";

                OleDbCommand cmd = new OleDbCommand(my_querry, conn);
                OleDbDataReader rd = cmd.ExecuteReader();
                //OleDbDataReader dr = cmd.ExecuteReader();

                if (rd.Read())
                {
                     MessageBox.Show("Login Successful" );
                        string usn = (string)rd.GetValue(0);
                    MessageBox.Show(usn);

                    this.Hide();
                    
                    HomePage hp = new HomePage(usn);
                    hp.Show();

                }
                else
                {
                    MessageBox.Show("Invalid Credentials, Please Re-Enter");
                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed due to" + ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
