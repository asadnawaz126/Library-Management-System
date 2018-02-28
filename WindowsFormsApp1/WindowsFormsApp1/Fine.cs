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
    public partial class Fine : Form
    {
        string usn;
        public Fine(string rusn)
        {
            this.usn = rusn;
            InitializeComponent();

            OleDbConnection dbcon = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data source= F:\\BESE\\6th Semester\\Software Construction\\Labs\\Lab 2\\Library-Management-System-SC_Lab2\\Library.accdb; Persist Security Info=False;");
            dbcon.Open();

            OleDbCommand sqlcommand = new OleDbCommand("Select * From tblTrans where ID = '" + this.usn + "'", dbcon);
            OleDbDataReader nrd = sqlcommand.ExecuteReader();
            
            while (nrd.Read())
            {
                string book_ID = Convert.ToString(nrd.GetValue(0));
                DateTime date = Convert.ToDateTime(nrd.GetValue(2));
                int days = (DateTime.Now - date).Days;
                
                OleDbCommand sqlcommand2 = new OleDbCommand("Select * From tblArtifacts where [Artifact ID] = '" + book_ID + "'", dbcon2);
                OleDbDataReader nrd2 = sqlcommand2.ExecuteReader();

                string Title = Convert.ToString(nrd2.GetValue(1));
                string Type = Convert.ToString(nrd2.GetValue(4));
                int addition = 0;
                int daycheck = 0;
                if(Type == "Journal")
                {
                    addition = 100;
                    daycheck = 15;
                }
                else if(Type == "Book")
                {
                    addition = 50;
                    daycheck = 30;
                }
                int finedays = 0;
                if(days > daycheck)
                {
                    finedays = days - daycheck;
                }
                int fine = finedays * addition;

                string addinlist = Title + "     Rs." + Convert.ToString(fine);
                listView1.Items.Add(addinlist);


            }
            }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
