using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SimpleCalculatorChallenge
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void addButton_Click(object sender, EventArgs e)
        {
            int firstNumber = int.Parse(firstValue.Text);
            int secondNumber = int.Parse(secondValue.Text);

            int resultValue = firstNumber + secondNumber;

            resultLabel.Text = resultValue.ToString();

        }

        protected void subtractButton_Click(object sender, EventArgs e)
        {
            int firstNumber = int.Parse(firstValue.Text);
            int secondNumber = int.Parse(secondValue.Text);

            int resultValue = firstNumber - secondNumber;

            resultLabel.Text = resultValue.ToString();
        }

        protected void multiplyButton_Click(object sender, EventArgs e)
        {
            int firstNumber = int.Parse(firstValue.Text);
            int secondNumber = int.Parse(secondValue.Text);

            int resultValue = firstNumber * secondNumber;

            resultLabel.Text = resultValue.ToString();
        }

        protected void divideButton_Click(object sender, EventArgs e)
        {
            double firstNumber = double.Parse(firstValue.Text);
            double secondNumber = double.Parse(secondValue.Text);

            double resultValue = firstNumber / secondNumber;

            resultLabel.Text = resultValue.ToString();
        }
    }
}