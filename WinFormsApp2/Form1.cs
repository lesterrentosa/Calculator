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
            if (display.Text.Length > 0)
            {
                display.Text = display.Text.Remove(display.Text.Length - 1, 1);
            }

            if (display.Text == "")
            {
                display.Text = "0";
            }
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            display.Text = "0";
            inputedLabel.Text = "";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            display.Text = "0";
            result = 0;
        }

        private void btnPN_Click(object sender, EventArgs e)
        {
           double result = double.Parse(display.Text);
            result = result * -1;
            display.Text = result.ToString();
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            double sq = Double.Parse(display.Text);
            inputedLabel.Text = System.Convert.ToString("Sqrt" + "(" + (display.Text) + ")");
            sq = Math.Sqrt(sq);
            display.Text = System.Convert.ToString(sq);
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(display.Text) / Convert.ToDouble(100);
            display.Text = System.Convert.ToString(a);
        }

        private void btnHalf_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(1.0 / Convert.ToDouble(display.Text));
            display.Text = System.Convert.ToString(a);
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            switch (operationDone)
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
            result = Double.Parse(display.Text);
            inputedLabel.Text = "";
            
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
           
            if (button.Text == ".")
            {
                if (!display.Text.Contains("."))
                    display.Text = display.Text + button.Text;
            } else
                display.Text = display.Text + button.Text;
        }


        private void operationClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (result != 0)
            {
                btnEquals.PerformClick();
                operationDone = button.Text;
                result = Double.Parse(display.Text);
                inputedLabel.Text = result + " " + operationDone;
                isoperationDone = true;
            }
            else
            {
                operationDone = button.Text;
                result = Double.Parse(display.Text);
                inputedLabel.Text = result + " " + operationDone;
                isoperationDone = true;
            }
        }
    }
}
