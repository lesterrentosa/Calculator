using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            display.Text = 0.ToString();
        }

        private void btndot_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {

        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {

        }

        private void btnDivide_Click(object sender, EventArgs e)
        {

        }

        private void btnPN_Click(object sender, EventArgs e)
        {

        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {

        }

        private void btnPercent_Click(object sender, EventArgs e)
        {

        }

        private void btnHalf_Click(object sender, EventArgs e)
        {

        }

        private void btnEquals_Click(object sender, EventArgs e)
        {

        }

        private void btnMC_Click(object sender, EventArgs e)
        {

        }

        private void btnMR_Click(object sender, EventArgs e)
        {

        }

        private void btnMS_Click(object sender, EventArgs e)
        {

        }

        private void btnMPlus_Click(object sender, EventArgs e)
        {

        }

        private void btnMMinus_Click(object sender, EventArgs e)
        {

        }

        private void btnNum(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            display.Text = display.Text + button.Text;
        }
    }
}
