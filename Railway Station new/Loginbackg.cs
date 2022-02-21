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
    public partial class Loginbackg : Form
    {
        public Loginbackg()
        {
            InitializeComponent();
        }
        //Click Button
        private void button1_Click(object sender, EventArgs e)
        {
            Login Click_Here_to_Login = new Login();
            Click_Here_to_Login.Show();
        }
    }
}
