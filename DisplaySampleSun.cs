﻿using System;
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
    public partial class DisplaySampleSun : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\My Works\GENUINE\Railway Station new\Railway Station new\Train Details.mdf;Integrated Security=True");
        SqlDataAdapter sqlda;
        SqlCommandBuilder com;
        DataTable dtb;
        public DisplaySampleSun()
        {
            InitializeComponent();
        }

        private void DisplaySampleSun_Load(object sender, EventArgs e)
        {

        }

        private void btnSR_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sqlda = new SqlDataAdapter("SELECT* FROM[SUNDAY]", conn);
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

        private void btnup_Click(object sender, EventArgs e)
        {
            try
            {
                com = new SqlCommandBuilder(sqlda);
                sqlda.Update(dtb);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Infosunday sun = new Infosunday();
            this.Hide();
            sun.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
        }

        private void btndis_Click(object sender, EventArgs e)
        {
            DisplaySun sun = new DisplaySun();
            this.Hide();
            sun.Show();
        }
    }
}
