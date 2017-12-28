using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeEpicSpies
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            resultLabel.Text = "";
            //Page.MaintainScrollPositionOnPostBack = true;
            if (!IsPostBack)
            {
                endDatePrevious.SelectedDate = DateTime.Now.Date;
                startDateNew.SelectedDate = DateTime.Now.Date.AddDays(14);
                startDateNew.VisibleDate = startDateNew.SelectedDate;
                endDateNew.SelectedDate = DateTime.Now.Date.AddDays(21);
                endDateNew.VisibleDate = endDateNew.SelectedDate;
            }
        }

        protected void assignButton_Click(object sender, EventArgs e)
        {      
            double totalDays = endDateNew.SelectedDate.Subtract(startDateNew.SelectedDate).TotalDays + 1;
            double totalAmount = 500 * totalDays;
            if (totalDays > 21)
            {
                totalAmount += 1000;
            }
            resultLabel.Text = String.Format("Assignment of {0} to assignment Project: {1} is authorized. Budget total: {2:C}", spyCodeName.Text, assignmentNewName.Text, totalAmount);
      
            if (startDateNew.SelectedDate.Subtract(endDatePrevious.SelectedDate).TotalDays < 14)
            {
                resultLabel.Text = "Error: Must allow at least two weeks between previous assignment and new assignment";

                DateTime newDate = endDatePrevious.SelectedDate.AddDays(14);
                startDateNew.SelectedDate = newDate;
                startDateNew.VisibleDate = newDate;
            }
        }
    }
}