using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Railway_Station_new
{
    public partial class Records : Form
    {
        public Records()
        {
            InitializeComponent();
        }

        private void RECORDS_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Infomonday mo = new Infomonday();
            mo.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Infotuesday tu = new Infotuesday();
            tu.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Infowednesday we = new Infowednesday();
            we.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            butadd th = new butadd();
            th.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Infofriday fr = new Infofriday();
            fr.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Infosaturday sa = new Infosaturday();
            sa.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Infosunday su = new Infosunday();
            su.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home back = new Home();
            back.Show();
            this.Hide();
             
            
            

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Home back = new Home();
            this.Hide();
            var first = Application.OpenForms.OfType<Background>().FirstOrDefault();
            if (first != null)
            {
                first.Hide();



            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Home back = new Home();
            back.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
        }

    }
}
