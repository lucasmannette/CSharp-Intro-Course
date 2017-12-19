using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_011
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            resultLabel.Text = "";

            /*
            if (firstText.Text == secondText.Text)
            {
                resultLabel.Text = "Yes! They're equal!";
            }
            else
            {
                resultLabel.Text = "No! They're not equal!";
            }
            */

            /*
            if (coolCheckBox.Checked)
            {
                resultLabel.Text = "You are the coolest kat around!!!";
            }
            else
            {
                resultLabel.Text = "Sorry, you are not cool buddy";
            }
            */

            /*
            if (pizzaButton.Checked)
            {
                resultLabel.Text = "You must be from Chicago!";
            }
            else if (pbjButton.Checked)
            {
                resultLabel.Text = "You are the PB&J boss!";
            }
            else if (noodlesButton.Checked)
            {
                resultLabel.Text = "You are a noodle head!!!";
            }
            else
            {
                resultLabel.Text = "Please select one of the options";
            }
            */

            //resultLabel.Text = (firstText.Text == secondText.Text) ? "Yes" : "No";
            //resultLabel.Text = (coolCheckBox.Checked) ? "So Cool!" : "You are not cool";
            int result = (firstText.Text == secondText.Text) ? 100 : 50;
            resultLabel.Text = result.ToString();
        }

    }
}