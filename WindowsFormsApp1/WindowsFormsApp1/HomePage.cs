using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class HomePage : Form
    {
        string usn;
        public HomePage(string rusn)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.usn = rusn;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Data.OleDb.OleDbConnection conn = new System.Data.OleDb.OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;" +
        @"Data source= F:\BESE\6th Semester\Software Construction\Labs\Lab 2\Library-Management-System-SC_Lab2\Library.accdb";

            try
            {
                conn.Open();
                String my_querry = "SELECT * FROM tblArtifacts ORDER BY Type";

                OleDbCommand cmd = new OleDbCommand(my_querry, conn);
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                

                
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

        private void goToSearchPage_Click(object sender, EventArgs e)
        {
            SearchPage sp = new SearchPage();
            sp.Show();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            issueForm instance = new issueForm(usn);
            instance.Show();
        }
    }
}
