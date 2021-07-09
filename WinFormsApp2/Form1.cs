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
    public partial class display : Form
    {
        Class1 calc = new Class1();

        public display()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = screen.Text.Length;
            index--;
            screen.Text = screen.Text.Remove(index);
            if (screen.Text == string.Empty)
            {
                screen.Text = "0";
            }
            if(calc.equalclick)
            {
                screen.Text = "0";
                calc.equalclick = false;
            }
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            screen.Text = "0";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            screen.Text = "0";
            calc.result = 0;
            inputedLabel.Text = " ";
        }

        private void btnPN_Click(object sender, EventArgs e)
        {
          if(screen.Text != "0")
            {
              double sresult = double.Parse(screen.Text);
              sresult = sresult * -1;
              screen.Text = sresult.ToString();
            }
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            double sq = Double.Parse(screen.Text);
            inputedLabel.Text = System.Convert.ToString("Sqrt" + "(" + (screen.Text) + ")");
            sq = Math.Sqrt(sq);
            screen.Text = System.Convert.ToString(sq);
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(screen.Text) / Convert.ToDouble(100);
            screen.Text = System.Convert.ToString(a);
        }

        private void btnHalf_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(1.0 / Convert.ToDouble(screen.Text));
            screen.Text = System.Convert.ToString(a);
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            switch (calc.operationDone)
            {
                case "+":
                    screen.Text = (calc.result + Double.Parse(screen.Text)).ToString();
                    break;
                case "-":
                    screen.Text = (calc.result - Double.Parse(screen.Text)).ToString();
                    break;
                case "*":
                    screen.Text = (calc.result * Double.Parse(screen.Text)).ToString();
                    break;
                case "/":
                    screen.Text = (calc.result / Double.Parse(screen.Text)).ToString();
                    break;
                default:
                    break;
            }
            calc.result = Double.Parse(screen.Text);
            inputedLabel.Text = "";
            calc.equalclick = true;
            calc.result = 0;
        }

        private void btnNum(object sender, EventArgs e)
        {
            if ((screen.Text == "0") || (calc.isoperationDone))
                screen.Clear();            
            calc.isoperationDone = false;
           Button button = (Button)sender;

            if (calc.equalclick)
            {
                screen.Text = "";
                calc.equalclick = false;
            }
            
            if (button.Text == ".")
            {
                if (!screen.Text.Contains("."))
                    screen.Text = screen.Text + button.Text;
            } else
                screen.Text = screen.Text + button.Text;
        }


        private void operationClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
           
            if (calc.result !=0 )
            {
                btnEquals.PerformClick();
                calc.operationDone = button.Text;
                calc.result = Double.Parse(screen.Text);
                inputedLabel.Text = calc.result + " " + calc.operationDone;
                calc.isoperationDone = true;
            }
            else
            {
                calc.operationDone = button.Text;
                calc.result = Double.Parse(screen.Text);
                inputedLabel.Text = calc.result + " " + calc.operationDone;
                calc.isoperationDone = true;
            }
        }
    }
}
