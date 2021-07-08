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
        Double result = 0;
        String operationDone = " ";
        bool isoperationDone = false;
        bool equalclick = false;

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
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            screen.Text = "0";
            inputedLabel.Text = "";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            screen.Text = "0";
            result = 0;
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
            switch (operationDone)
            {
                case "+":
                    screen.Text = (result + Double.Parse(screen.Text)).ToString();
                    break;
                case "-":
                    screen.Text = (result - Double.Parse(screen.Text)).ToString();
                    break;
                case "*":
                    screen.Text = (result * Double.Parse(screen.Text)).ToString();
                    break;
                case "/":
                    screen.Text = (result / Double.Parse(screen.Text)).ToString();
                    break;
                default:
                    break;
            }
            result = Double.Parse(screen.Text);
            inputedLabel.Text = "";
            equalclick = true;
             
            
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

            if ((screen.Text == "0") || (isoperationDone))
                screen.Clear();            
            isoperationDone = false;
           Button button = (Button)sender;
            if (equalclick)
            {
                screen.Text = "";
                equalclick = false;
                


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
           
            if (equalclick)
            {
                
                operationDone = button.Text;
                result = Double.Parse(screen.Text);
                inputedLabel.Text = result + " " + operationDone;
                isoperationDone = true;
            }
            else
            {
                operationDone = button.Text;
                result = Double.Parse(screen.Text);
                inputedLabel.Text = result + " " + operationDone;
                isoperationDone = true;
            }
        }
    }
}
