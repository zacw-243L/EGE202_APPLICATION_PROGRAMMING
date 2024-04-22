using System;
using System.Windows.Forms;

namespace Calculator
{

    public partial class frmMain : Form
    {

        public frmMain()

        {
            InitializeComponent();
        }
        private void numPad_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string number = button.Text;
            string currentResult = txtResults.Text;
            if (flagOpPressed == true)
            {
                currentResult = ""; 
                flagOpPressed = false;
            }

            if (number == "." && currentResult.Contains("."))
            {
                return; // don't allow multiple decimal points
            }

            if (currentResult == "0")
            {
                currentResult = ""; // remove leading zeros
            }

            currentResult += number;
            txtResults.Text = currentResult;
        }

        string opr = "";
        double operand = 0;
        // This event handler is triggered when the "equal" button is clicked
        private void equal_Click(object sender, EventArgs e)
        {
            double operand2;
            // Parse the text in the results textbox to a double
            // If parsing fails, display an error message and return from the method
            if (!Double.TryParse(txtResults.Text, out operand2))
            {
                MessageBox.Show("Invalid input");
                return;
            }
            // Perform the appropriate mathematical operation based on the operator that was clicked
            switch (opr)
            {
                case "Add":
                    operand = operand + operand2;
                    txtResults.Text = operand.ToString();
                    break;
                case "Subtract":
                    operand = operand - operand2;
                    txtResults.Text = operand.ToString();
                    break;
                case "Multiply":
                    operand = operand * operand2;
                    txtResults.Text = operand.ToString();
                    break;
                case "Divide":
                    // Check if the divisor is zero before performing the division operation
                    if (operand2 == 0)
                    {
                        // Display an error message if the divisor is zero and return from the method
                        MessageBox.Show("Cannot divide by zero");
                        return;
                    }
                    operand = operand / operand2;
                    txtResults.Text = operand.ToString();
                    break;
                default:
                    break;
            }
            // Reset the operator to an empty string after the operation is performed
            opr = "";
        }

        bool flagOpPressed = false;
        private void operator_Click(object sender, EventArgs e)
        {
            equal.PerformClick();
            operand = Double.Parse(txtResults.Text);
            Button btn = (Button)sender;
            opr = btn.Tag.ToString();
            flagOpPressed = true;
        }
        // This method handles the click event of a button that represents a unary operator, such as square root.
        private void u_operatorClick(object sender, EventArgs e)
        {
            // Try to parse the value in the text box to a double
            if (double.TryParse(txtResults.Text, out double value))
            {
                // Compute the square root of the value and format the result as a string with up to 10 decimal places
                string results = string.Format("{0:N10}", Math.Sqrt(value));
                // Trim trailing zeros and decimal point from the result string
                txtResults.Text = results.TrimEnd('0', '.');
            }
            else
            {
                // Display an error message if the value in the text box cannot be parsed to a double
                MessageBox.Show("Error");
            }
        }
        private void Square_Click(object sender, EventArgs e)
        {
            // Try to parse the value in the text box to a double
            if (double.TryParse(txtResults.Text, out double value))
            {
                // Compute the square of the value and format the result as a string with up to 10 decimal places
                string results = string.Format("{0:N10}", value * value);
                // Trim trailing zeros and decimal point from the result string
                txtResults.Text = results.TrimEnd('0', '.');
            }
            else
            {
                // Display an error message if the value in the text box cannot be parsed to a double
                MessageBox.Show("Error");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            opr = "";
            operand = 0;
            flagOpPressed = false;
            txtResults.Text = "0";
        }
    }
}
