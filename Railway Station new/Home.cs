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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        //Record Button
        private void button3_Click(object sender, EventArgs e)
        {
            Records RE = new Records();
            RE.Show();
            this.Hide();
        }
        //Close Button
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
            var first = Application.OpenForms.OfType<Background>().FirstOrDefault();
            if (first != null)
            {
                first.Hide();
            

            
            }
        }
        //Minimize Button
        private void button2_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Login back = new Login();
            back.Show();
            this.Hide();
                
        }
        //Reg Button
        private void button4_Click(object sender, EventArgs e)
        {
            Reg r = new Reg();
            this.Hide();
            r.Show();
        }
        //Logout Button
        private void button5_Click(object sender, EventArgs e)
        {
            Logout lo = new Logout();
            this.Hide();
            lo.Show();
        }
    }
}
