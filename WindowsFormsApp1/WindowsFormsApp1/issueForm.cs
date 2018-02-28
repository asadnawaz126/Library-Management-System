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

namespace WindowsFormsApp1
{
    public partial class issueForm : Form
    {
        string usn;
        public issueForm(string rusn)
        {
            InitializeComponent();
            this.usn = rusn;
        }

        private void issueForm_Load(object sender, EventArgs e)
        {
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {

                OleDbConnection dbcon = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data source= F:\\BESE\\6th Semester\\Software Construction\\Labs\\Lab 2\\Library-Management-System-SC_Lab2\\Library.accdb; Persist Security Info=False;");
                dbcon.Open();

                OleDbCommand sqlcommand = new OleDbCommand("Select * From tblArtifacts where Title = '" + textBox1.Text + "'", dbcon);
                OleDbDataReader nrd = sqlcommand.ExecuteReader();

                if (nrd.Read())
                {

                    string status = Convert.ToString(nrd.GetValue(11));
                    string artifactid = Convert.ToString(nrd.GetValue(0));

                    if (status == "Available")
                    {

                        OleDbCommand myCommand = new OleDbCommand();
                        string sql = null;
                        myCommand.Connection = dbcon;
                        sql = "insert into tblTrans ([Book ID], [ID],[Date Returned],[Date Borrowed]) values ('" + artifactid + "','" + usn + "','"+DateTime.Now.AddDays(30)+"','"+ DateTime.Now+"')";
                        myCommand.CommandText = sql;
                        myCommand.ExecuteNonQuery();

                        OleDbCommand updation = new OleDbCommand();
                        string nsql = null;
                        updation.Connection = dbcon;
                        nsql = "update tblArtifacts set Status = 'Issued' where [Artifact ID] = '"+ artifactid +"'";
                        updation.CommandText = nsql;
                        updation.ExecuteNonQuery();

                        dbcon.Close();
                        MessageBox.Show("Book Issued");
                        this.Hide();

                    }
                    else if (status == "Issued")
                    {
                        MessageBox.Show("Sorry the Book has already been issued.");
                    }
                }
            }
        }
    }
}
