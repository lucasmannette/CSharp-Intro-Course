using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeDaysBetweenDates
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            if (firstCalander.SelectedDate > secondCalander.SelectedDate)
                resultLabel.Text = firstCalander.SelectedDate
                               .Subtract(secondCalander.SelectedDate)
                               .TotalDays.ToString();
            else
                resultLabel.Text = secondCalander.SelectedDate
                               .Subtract(firstCalander.SelectedDate)
                               .TotalDays.ToString();

        }
    }
}