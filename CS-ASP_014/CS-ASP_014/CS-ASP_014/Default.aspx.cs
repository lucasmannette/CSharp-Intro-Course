using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_014
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            //DateTime myValue = DateTime.Now;
            //resultLabel.Text = myValue.ToString();
            //resultLabel.Text = myValue.ToLongDateString();
            //resultLabel.Text = myValue.ToShortDateString();
            //resultLabel.Text = myValue.ToLongTimeString();
            //resultLabel.Text = myValue.AddDays(2).ToString();
            //resultLabel.Text = myValue.AddMonths(-2).ToString();
            //resultLabel.Text = myValue.Month.ToString();
            //resultLabel.Text = myValue.IsDaylightSavingTime().ToString();
            //resultLabel.Text = myValue.DayOfYear.ToString();

            //DateTime myValue = DateTime.Parse("10/23/1991");
            DateTime myValue = new DateTime(1991, 10, 23, 6, 33, 0);
            resultLabel.Text = myValue.ToLongTimeString();
        }
    }
}