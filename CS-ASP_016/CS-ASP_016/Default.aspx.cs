using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_016
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void getDateButton_Click(object sender, EventArgs e)
        {
            resultLabel.Text = myCalander.SelectedDate.ToShortDateString();
        }

        protected void setDateButton_Click(object sender, EventArgs e)
        {
            myCalander.SelectedDate = DateTime.Parse("12/28/2017");

        }

        protected void showDateButton_Click(object sender, EventArgs e)
        {
            myCalander.VisibleDate = DateTime.Parse("10/23/1991");
        }

        protected void selecedWeekButton_Click(object sender, EventArgs e)
        {
            resultLabel.Text = "Week of " + myCalander.SelectedDate.ToShortDateString();
        }

        protected void myCalander_SelectionChanged(object sender, EventArgs e)
        {
            resultLabel.Text = myCalander.SelectedDate.ToShortDateString();
        }
    }
}