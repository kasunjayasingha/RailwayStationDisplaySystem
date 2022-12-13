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
    public partial class DisplaySat : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\My Works\GENUINE\Railway Station new\Railway Station new\Train Details.mdf;Integrated Security=True");
        SqlDataAdapter sqlda;
        SqlCommandBuilder com;
        DataTable dtb;
        public DisplaySat()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void DisplaySat_Load(object sender, EventArgs e)
        {
            try
            {

                conn.Open();
                sqlda = new SqlDataAdapter("SELECT* FROM[SATURDAY]", conn);
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DisplaySampleSat sat = new DisplaySampleSat();
            this.Hide();
            sat.Show();
        }
        //Time Code
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            this.Timeid.Text = dt.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
