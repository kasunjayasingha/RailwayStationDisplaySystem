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
    public partial class Logout : Form
    {
        SqlDataAdapter sda = new SqlDataAdapter();
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\My Works\GENUINE\Railway Station new\Railway Station new\Train Details.mdf;Integrated Security=True");
        public Logout()
        {
            InitializeComponent();
        }
        //Sign Out Button
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Are you sure,Do you really want to Log out..?", "LOGOUT", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            
            if (res == DialogResult.Yes)
            
            

            {
                SqlDataAdapter sda = new SqlDataAdapter("Select count(*) From [REG] where username='" + txtuser.Text + "' and password='" + txtpass.Text + "'", conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (txtuser.Text =="" || txtpass.Text=="")
                    MessageBox.Show("Please fill Username & Password Fiels");
                else if (dt.Rows[0][0].ToString() == "1") 

               
                
                
                    try
                    {
                        string pass;
                        pass = txtpass.Text;
                        conn.Open();
                        SqlCommand comm = new SqlCommand("DELETE FROM[REG]WHERE password='" + pass + "'", conn);
                        comm.ExecuteNonQuery();
                        txtpass.Clear();
                        txtuser.Clear();
                        DialogResult ms;
                        ms = MessageBox.Show("Successful Logout","Logout",MessageBoxButtons.OK);

                        if(ms==DialogResult.OK)
                        {
                            Reg re = new Reg();
                            this.Hide();
                            re.Show();

                        }
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                    }
                else
                {
                    MessageBox.Show("Invalid User Name Or Password.!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtuser.Clear();
                    txtpass.Clear();
                    
                    this.Show();
                }
                
            }
        }
        //Close
        private void button3_Click(object sender, EventArgs e)
        {
            Home re = new Home();
            this.Hide();
            re.Show();
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
