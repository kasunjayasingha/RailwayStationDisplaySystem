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

namespace Railway_Station_new
{
    public partial class DisplayMon : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\My Works\GENUINE\Railway Station new\Railway Station new\Train Details.mdf;Integrated Security=True");
        SqlDataAdapter sqlda;
        SqlCommandBuilder com;
        DataTable dtb;
        public DisplayMon()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void DisplayMon_Load(object sender, EventArgs e)
        {
            try
            {

                conn.Open();
                sqlda = new SqlDataAdapter("SELECT* FROM[MONDAY]", conn);
                dtb = new DataTable();
                sqlda.Fill(dtb);
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = dtb;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        //Back Button
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DisplaySampleMon mo = new DisplaySampleMon();
            this.Hide();
            mo.Show();
        }
        //Time Code
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            this.Timeid.Text = dt.ToString();
        }

        private void Timeid_Click(object sender, EventArgs e)
        {

        }

        private void Timeid_Click_1(object sender, EventArgs e)
        {

        }
    }
}
