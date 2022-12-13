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
    public partial class Login : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\My Works\GENUINE\Railway Station new\Railway Station new\Train Details.mdf;Integrated Security=True");
        public Login()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void USERpass_TextChanged(object sender, EventArgs e)
        {

        }
        //Login Button
        private void button2_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select count(*) From [REG] where username='"+TXTuser.Text+"' and password='"+USERpass.Text+"'",conn );
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if(dt.Rows[0][0].ToString()=="1")
                
           
            {
                Home GRS = new Home();
                this.Hide();
                GRS.Show();
                var first = Application.OpenForms.OfType<Loginbackg>().FirstOrDefault();
                if (first != null) ;
                Background BackG = new Background();
                this.Hide();
                BackG.Show();
                var Second = Application.OpenForms.OfType<Background>().FirstOrDefault();
                if (first != null)
                {
                    first.Hide();

                }


            }
           else
            {
                MessageBox.Show("Invalid User Name Or Password.!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                USERpass.Clear();
                TXTuser.Clear();
                TXTuser.Focus();
                this.Show();
            }
        }

        private void TXTuser_Enter(object sender, EventArgs e)
        {
            TXTuser.Text = "";
        }

        private void TXTuser_Leave(object sender, EventArgs e)
        {
            if (TXTuser.Text == "")
            {
                TXTuser.Text = "Username";
            }
        }

        private void USERpass_Enter(object sender, EventArgs e)
        {
            USERpass.Text = "";
        }

        private void USERpass_Leave(object sender, EventArgs e)
        {
            if (USERpass.Text == "")
            {
                USERpass.Text = "Password";
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        //Close
        private void button3_Click(object sender, EventArgs e)
        {
            Loginbackg back = new Loginbackg();
            this.Close();
            var first = Application.OpenForms.OfType<Background>().FirstOrDefault();
            if (first != null)
            {
                first.Hide();



            }
               
        }
        //Minimize
        private void button1_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
        }
    }
}
