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
    public partial class Infomonday : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\My Works\GENUINE\Railway Station new\Railway Station new\Train Details.mdf;Integrated Security=True");
        public Infomonday()
        {
            InitializeComponent();
        }
        //Minimize Button
        private void button6_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
        }
        //CLOSE(X) Button
        private void button5_Click(object sender, EventArgs e)
        {
            Records re = new Records();
            this.Hide();
            var first = Application.OpenForms.OfType<Background>().FirstOrDefault();
            if (first != null)
            {
                first.Hide();
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //BACK Button
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Records re = new Records();
            re.Show();
            this.Hide();
        }
        //ADD Button
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int trno;
                string artime, dptime, stations, actdact, clz="", fac;
                trno = Convert.ToInt32(txttrno.Text);
                artime = txtartime.Text;
                dptime = txtdptime.Text;
                stations = txtsta.Text;
                actdact = txtcombo.Text;
                fac = txtcombo2.Text;
                foreach (Control cc in this.Controls)
                {
                    if(cc is CheckBox)
                    {
                        CheckBox b = (CheckBox)cc;
                        if (b.Checked)
                        {
                            clz = b.Text + " " + clz;
                        }
                    }
                }
                conn.Open();
                SqlCommand comm = new SqlCommand("INSERT INTO[MONDAY](trno,arrtime,deptime,stations,actdeact,classes,facilities)VALUES('" + trno + "','" + artime + "','" + dptime + "','" + stations + "','" + actdact + "','" + clz + "','" + fac + "')", conn);
                comm.ExecuteNonQuery();
                MessageBox.Show("Your record added successfully", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                txttrno.Clear();
                txtartime.Clear();
                txtdptime.Clear();
                txtsta.Clear();
                conn.Close();
            }
        }
        //DELETE Button
        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Are you sure,Do you really want to delete..?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(res==DialogResult.Yes)
                {
                    try
                    {
                    int trno;
                    trno=Convert.ToInt32(txttrno.Text);
                    conn.Open();
                    SqlCommand comm=new SqlCommand("DELETE FROM[MONDAY]WHERE trno='"+trno+"'",conn);
                    comm.ExecuteNonQuery();
                    txttrno.Clear();
                    txtartime.Clear();
                    txtdptime.Clear();
                    txtsta.Clear();
                   
                    }
                    catch(Exception ex){
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                    conn.Close();
                    }
                }
        }
        //UPDATE Button
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int trno;
                string artime, dptime, stations, actdact, clz="", fac;
                trno = Convert.ToInt32(txttrno.Text);
                artime = txtartime.Text;
                dptime = txtdptime.Text;
                stations = txtsta.Text;
                actdact = txtcombo.Text;
                fac = txtcombo2.Text;
                foreach (Control cc in this.Controls)
                {
                    if (cc is CheckBox)
                    {
                        CheckBox b = (CheckBox)cc;
                        if (b.Checked)
                        {
                            clz = b.Text + " " + clz;
                        }
                    }
                }
                conn.Open();
                SqlCommand comm = new SqlCommand("UPDATE[MONDAY]SET arrtime='" + artime + "',deptime='" + dptime + "',stations='" + stations + "',actdeact='" + actdact + "',facilities='" + fac + "',classes='"+clz+"'WHERE trno='" + trno + "'", conn);
                comm.ExecuteNonQuery();
                MessageBox.Show("Your record updated successfully!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                txttrno.Clear();
                txtartime.Clear();
                txtdptime.Clear();
                txtsta.Clear();
                conn.Close();
            }
        }
        //SEARCH Button
        private void button3_Click(object sender, EventArgs e)
        {
            try
            { 
            int trno;
            string artime, dptime, stations, actdact, clz, fac;
            trno = Convert.ToInt32(txttrno.Text);
            artime = txtartime.Text;
            dptime = txtdptime.Text;
            stations = txtsta.Text;
            actdact = txtcombo.Text;
            fac = txtcombo2.Text;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            conn.Open(); 
            SqlCommand comm = new SqlCommand("SELECT* FROM[MONDAY]WHERE trno='"+trno+"'",conn);
            SqlDataReader reader = comm.ExecuteReader();
            while (reader.Read())
            {
                txttrno.Text = reader[0].ToString();
                txtartime.Text = reader[1].ToString();
                txtdptime.Text = reader[2].ToString();
                txtsta.Text = reader[3].ToString();
                txtcombo.Text = reader[4].ToString();
               txtcombo2.Text = reader[6].ToString();

                string aa = reader["classes"].ToString();
                string[] a = aa.Split(' ');
                foreach (Control cc in this.Controls)
                {
                    if (cc is CheckBox)
                    {
                        CheckBox b = (CheckBox)cc;
                        for (int j = 0; j < a.Length; j++)
                        {
                            if (a[j].ToString() == b.Text)
                            {
                                b.Checked = true;
                            }
                        }
                    }
                }
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
        }
        //DISPLAY Button
        private void button2_Click_1(object sender, EventArgs e)
        {
            DisplaySampleMon dis = new DisplaySampleMon();
            this.Hide();
            dis.Show();
        }
        //CLEAR Button
        private void butclear_Click(object sender, EventArgs e)
        {
            txttrno.Clear();
            txtartime.Clear();
            txtdptime.Clear();
            txtsta.Clear();
        }
    }
}
