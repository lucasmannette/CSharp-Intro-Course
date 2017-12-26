using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeFirstPapaBobsWebsite
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            double totalAmount = 0;

            //Size
            if (babySize.Checked)
                totalAmount += 10;
            else if (mamaSize.Checked)
                totalAmount += 13;
            else if (papaSize.Checked)
                totalAmount += 16;

            //Crust
            if (deepCrust.Checked)
                totalAmount += 2;

            //Toppings
            if (pepperoni.Checked)
                totalAmount += 1.5;
            if (onions.Checked)
                totalAmount += 0.75;
            if (greenPeppers.Checked)
                totalAmount += 0.50;
            if (redPeppers.Checked)
                totalAmount += 0.75;
            if (anchovies.Checked)
                totalAmount += 2;

            if ((pepperoni.Checked && greenPeppers.Checked && anchovies.Checked)
                || (pepperoni.Checked && redPeppers.Checked && onions.Checked))
                totalAmount -= 2;

            resultLabel.Text = "Total: $" + totalAmount.ToString();

        }
    }
}