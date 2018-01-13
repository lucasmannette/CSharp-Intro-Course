using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_035
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            // use \ to escape double quotes
            //resultLabel.Text = "<p style=\"color:#ee3b32;\">Hi<p>";

            string value = valueTextBox.Text;

            //Access any specific character
            //resultLabel.Text = value[2].ToString();

            //StartWith(), EndWith(), Contains()
            //if (value.StartsWith("A"))
            //    resultLabel.Text = "The value starts with A";

            //if (value.EndsWith("."))
            //    resultLabel.Text = "The value end in a .";

            //if (value.Contains("wise"))
            //    resultLabel.Text = "The value contains wise!";

            //IndexOf()
            int index = value.IndexOf("wise");
            //resultLabel.Text = "'wise' begins at index " + index.ToString();

            //Insert,Remove
            //resultLabel.Text = value.Insert(index, "jolly ");
            //resultLabel.Text = value.Remove(index, value.Length - index);

            //Substring
            //resultLabel.Text = value.Substring(index, value.Length - index - 1);

            //Trim, TrimStart, TrimEnd
            //resultLabel.Text = String.Format("Length Before: {0}<br> Length After: {1}", value.Length, value.Trim().Length);

            //PadLeft, PadRight
            //char needs single quotes
            //resultLabel.Text = value.PadLeft(10, '*');

            //ToUpper, ToLower
            //if ("Bob" == "bob")
            //    resultLabel.Text = "Same";
            //else
            //    resultLabel.Text = "Different";

            //if (valueTextBox.Text.Trim().ToUpper() == "LUKE")
            //    resultLabel.Text = "Same";
            //else
            //    resultLabel.Text = "Different";

            //Replace()
            //string template = "[NAME] said it was ok. Maybe you should take it up with [NAME]";
            //resultLabel.Text = template.Replace("[NAME]", valueTextBox.Text);

            //Split
            //string result = "";
            StringBuilder sb = new StringBuilder();
            string[] values = valueTextBox.Text.Split(',');
            for (int i = 0; i < values.Length; i++)
            {
                //result += values[i] + " " + values[i].Length + "<br>";
                sb.Append(values[i]);
                sb.Append(" ");
                sb.Append(values[i].Length);
                sb.Append("<br>");
            }
            //resultLabel.Text = result;
            resultLabel.Text = sb.ToString();
        }
    }
}