using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RadioButtonChallenge
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            if (pencilRadio.Checked)
            {
                resultLabel.Text = "You Selected Pencil";
                resultImage.ImageUrl = "pencil.png";
            }
            else if (penRadio.Checked)
            {
                resultLabel.Text = "You Selected Pen";
                resultImage.ImageUrl = "pen.png";
            }
            else if (phoneRadio.Checked)
            {
                resultLabel.Text = "You Selected Phone";
                resultImage.ImageUrl = "phone.png";
            }
            else if (tabletRadio.Checked)
            {
                resultLabel.Text = "You Selected Tablet";
                resultImage.ImageUrl = "tablet.png";
            }
            else
            {
                resultLabel.Text = "Please Select One Of The Radio Buttons Above.";
            }
        }
    }
}