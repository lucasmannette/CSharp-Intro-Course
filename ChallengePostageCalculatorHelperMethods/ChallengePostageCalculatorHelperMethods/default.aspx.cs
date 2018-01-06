using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengePostageCalculatorHelperMethods
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
         
        protected void groundRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (checkWidthTextBox() && checkHeightTextBox())
            {
                if (checkLengthTextBox())
                {
                    calculatePostage(0.15, double.Parse(widthTextBox.Text), double.Parse(heightTextBox.Text), double.Parse(lengthTextBox.Text));
                }
                else
                {
                    calculatePostage(0.15, double.Parse(widthTextBox.Text), double.Parse(heightTextBox.Text));
                }
                
            }
        }

        protected void airRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (checkWidthTextBox() && checkHeightTextBox())
            {
                if (checkLengthTextBox())
                {
                    calculatePostage(0.25, double.Parse(widthTextBox.Text), double.Parse(heightTextBox.Text), double.Parse(lengthTextBox.Text));
                }
                else
                {
                    calculatePostage(0.25, double.Parse(widthTextBox.Text), double.Parse(heightTextBox.Text));
                }

            }
        }

        protected void nextDayRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (checkWidthTextBox() && checkHeightTextBox())
            {
                if (checkLengthTextBox())
                {
                    calculatePostage(0.45, double.Parse(widthTextBox.Text), double.Parse(heightTextBox.Text), double.Parse(lengthTextBox.Text));
                }
                else
                {
                    calculatePostage(0.45, double.Parse(widthTextBox.Text), double.Parse(heightTextBox.Text));
                }

            }
        }

        protected bool checkWidthTextBox()
        {
            if (widthTextBox.Text.Length > 0)
                return true;
            else
                return false;
        }

        protected bool checkHeightTextBox()
        {
            if (heightTextBox.Text.Length > 0)
                return true;
            else
                return false;
        }

        protected bool checkLengthTextBox()
        {
            if (lengthTextBox.Text.Length > 0)
                return true;
            else
                return false;
        }

        //return postage value
        protected void calculatePostage(double multiplier, double width, double height, double length = 1)
        {
            double totalPostage = (width * height * length) * multiplier;
            resultLabel.Text = String.Format("Total Postage: {0:C}", totalPostage);
        }

    }
}