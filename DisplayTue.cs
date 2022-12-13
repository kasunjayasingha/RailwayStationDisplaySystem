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
    
    public partial class DisplayTue : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\My Works\GENUINE\Railway Station new\Railway Station new\Train Details.mdf;Integrated Security=True");
        SqlDataAdapter sqlda;
        SqlCommandBuilder com;
        DataTable dtb;
        public DisplayTue()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void DisplayTue_Load(object sender, EventArgs e)
        {
            try
            {

                conn.Open();
                sqlda = new SqlDataAdapter("SELECT* FROM[TUESDAY]", conn);
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
            DisplaySampleTue tu = new DisplaySampleTue();
            this.Hide();
            tu.Show();
        }
        //Time Code
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            this.Timeid.Text = dt.ToString();
        }
    }
}
