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
        Double result = 0;
        String operationDone = " ";
        bool isoperationDone = false;
        public Form1()
        {
            InitializeComponent();
        }

        

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            display.Text = "0";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            display.Text = "0";
            result = 0;
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
            switch(operationDone)
            {
                case "+":
                    display.Text = (result + Double.Parse(display.Text)).ToString();
                    break;
                case "-":
                    display.Text = (result - Double.Parse(display.Text)).ToString();
                    break;
                case "*":
                    display.Text = (result * Double.Parse(display.Text)).ToString();
                    break;
                case "/":
                    display.Text = (result / Double.Parse(display.Text)).ToString();
                    break;
                default:
                    break;
            }
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
            if ((display.Text == "0") || (isoperationDone))
                display.Text = " ";
            isoperationDone = false;
            Button button = (Button)sender;
            if(button.Text == ".")
            {
                if(!display.Text.Contains("."))
                   display.Text = display.Text + button.Text;
            }else
            display.Text = display.Text + button.Text;
        }


        private void operationClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operationDone = button.Text;
            result = Double.Parse(display.Text);
            inputedLabel.Text = result + " " + operationDone;
            isoperationDone = true;
        }
    }
}
