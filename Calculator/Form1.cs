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
        Double resultValue = 0;
        string operationPerform = "";

        bool isOperationPerform = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void numOne_Click(object sender, EventArgs e)
        {
            if ((textResult.Text == "0") || (isOperationPerform))
                textResult.Clear();

            isOperationPerform = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if(!textResult.Text.Contains("."))
                    textResult.Text = textResult.Text + button.Text;
            }
            else
            {
                textResult.Text = textResult.Text + button.Text;
            }
        }



        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if(resultValue != 0)
            {
                calcEnter.PerformClick();
                operationPerform = button.Text;
                labelInput.Text = resultValue + " " + operationPerform;
                isOperationPerform = true;
            }

            operationPerform = button.Text;
            resultValue = Double.Parse(textResult.Text);
            labelInput.Text = resultValue + " " + operationPerform;
            isOperationPerform = true;
        }


        private void calcClearEntry_Click(object sender, EventArgs e)
        {
            textResult.Text = "0";
        }

        private void calcClear_Click(object sender, EventArgs e)
        {
            textResult.Text = "0";
            resultValue = 0; 
        }


        private void calcEnter_Click(object sender, EventArgs e)
        {
            switch (operationPerform)
            {
                case "+":
                    textResult.Text = (resultValue + double.Parse(textResult.Text)).ToString();
                    break;
                case "-":
                    textResult.Text = (resultValue - double.Parse(textResult.Text)).ToString();
                    break;
                case "*":
                    textResult.Text = (resultValue * double.Parse(textResult.Text)).ToString();
                    break;
                case "/":
                    textResult.Text = (resultValue / double.Parse(textResult.Text)).ToString();
                    break;
                default:
                    break;
            }
            resultValue = Double.Parse(textResult.Text);
            labelInput.Text = "";  
        }

        private void labelInput_Click(object sender, EventArgs e)
        {

        }
    }
}
