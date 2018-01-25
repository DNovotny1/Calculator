//Daniel Novotny
//Simple C# calculator made for C# advanced
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double a;
        double b;
        //clears output, adds and outputs to the two textboxes 
        private void add_Click(object sender, EventArgs e)
        {
            txtOut.Clear(); 
            a = System.Convert.ToDouble(firstNum.Text);
            b = System.Convert.ToDouble(secNum.Text);
            txtOut.AppendText(System.Convert.ToString(a + b));
        }
        //clears output, subtracts and outputs to the two textboxes 
        private void sub_Click(object sender, EventArgs e)
        {
            txtOut.Clear();
            a = System.Convert.ToDouble(firstNum.Text);
            b = System.Convert.ToDouble(secNum.Text);
            txtOut.AppendText(System.Convert.ToString(a-b));

        }
        //clears output, multiplies and outputs to the two textboxes 
        private void multi_Click(object sender, EventArgs e)
        {
            txtOut.Clear();
            a = System.Convert.ToDouble(firstNum.Text);
            b = System.Convert.ToDouble(secNum.Text);
            txtOut.AppendText(System.Convert.ToString(a * b));
        }
        //clears output, divides, modulus and outputs to the two textboxes 
        private void div_Click(object sender, EventArgs e)
        {
            txtOut.Clear();
            a = System.Convert.ToDouble(firstNum.Text);
            b = System.Convert.ToDouble(secNum.Text);
            if (b == 0)
            {
                txtOut.AppendText("Hey, no dividing by Zero!");
            }
            else
            {
                txtOut.AppendText(System.Convert.ToString(a / b) + "." + System.Convert.ToString(a % b));
            }
        }
    }
}
