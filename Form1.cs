using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ibtxt.Visible = true;
            ibtxt.Text = "WelCome to SE Prof." + txtBox.Text;
            txtBox.Enabled = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ibtxt_Click(object sender, EventArgs e)
        {

        }

        private void txtBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
