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
    public partial class Reg : Form
    {

        string con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\My Works\GENUINE\Railway Station new\Railway Station new\Train Details.mdf;Integrated Security=True";
        public Reg()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        //Submit Button
        private void button2_Click(object sender, EventArgs e)
        {
            if (txtuser.Text == "" || txtpass.Text == "")
                MessageBox.Show("Please fill Username & Password Fiels");
            else if (txtpass.Text != txtconpass.Text)
                MessageBox.Show("Password do not match");
            else
            {
                using (SqlConnection sqlcon = new SqlConnection(con))
                {
                    sqlcon.Open();
                    SqlCommand comm = new SqlCommand("useradd", sqlcon);
                    comm.CommandType = CommandType.StoredProcedure;
                    comm.Parameters.AddWithValue("@ftname", txtftname.Text.Trim());
                    comm.Parameters.AddWithValue("@ltname", txtltname.Text.Trim());
                    comm.Parameters.AddWithValue("@username", txtuser.Text.Trim());
                    comm.Parameters.AddWithValue("@password", txtpass.Text.Trim());
                    comm.Parameters.AddWithValue("@conpassword", txtconpass.Text.Trim());
                    comm.ExecuteNonQuery();
                    MessageBox.Show("Registration is Successfull");
                    Clear();
                }
                Login lo = new Login();
                this.Hide();
                lo.Show();
            }
 

        }
        void Clear()
        {
            txtftname.Text = txtltname.Text = txtuser.Text = txtpass.Text = txtconpass.Text = "";
        
        }
        //Close Button
        private void button3_Click(object sender, EventArgs e)
        {
            Home ho = new Home();
            this.Hide();
            ho.Show();
        }

        private void Reg_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //Minimize Button
        private void button1_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtftname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtltname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtconpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
          

    }
}
