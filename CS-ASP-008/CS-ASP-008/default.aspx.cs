using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_008
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            /*
            int i;
            i = "3";
            */

            /*
            int i = 20000000;
            long j = i;
            */

            /*
            long i = 20000000000;
            int j = (int)i;
            */

            //double k = 2.5;
            //int j = (int)k;

            //resultLabel.Text = j;
            //resultLabel.Text = (string)j;
            //resultLabel.Text = j.ToString();

            string i = textBox.Text;
            int j = int.Parse(i);
            int k = j + 1;
            resultLabel.Text = k.ToString();
        }
    }
}