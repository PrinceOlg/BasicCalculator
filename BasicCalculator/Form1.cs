using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (float.TryParse(txtNum1.Text, out float num1) && float.TryParse(txtNum2.Text, out float num2))
            {
                float result = 0;

                string selectedOperator = cmbOperations.SelectedItem?.ToString() ?? string.Empty;

                switch (selectedOperator)
                {
                    case "+":
                        result = BasicComputation.Add(num1, num2);
                        break;
                    case "-":
                        result = BasicComputation.Subtract(num1, num2);
                        break;
                    case "*":
                        result = BasicComputation.Multiply(num1, num2);
                        break;
                    case "/":
                        result = BasicComputation.Divide(num1, num2);
                        break;
                    default:
                        lblResult.Text = "Select a valid operator.";
                        return;
                }

                // Display the result
                lblResult.Text = " " + result.ToString();
            }
            else
            {
                lblResult.Text = "Invalid input. Please enter numbers.";
            }
        }
    }
    public static class BasicComputation
    {
        public static float Add(float a, float b) => a + b;
        public static float Subtract(float a, float b) => a - b;
        public static float Multiply(float a, float b) => a * b;
        public static float Divide(float a, float b) => b != 0 ? a / b : float.NaN;
    }
}
