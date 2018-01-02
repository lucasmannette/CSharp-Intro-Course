using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeEpicSpiesAssetTracker
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                string[] assetName = new string[0];
                int[] elections = new int[0];
                int[] actsPerformed = new int[0];

                ViewState.Add("AssetName", assetName);
                ViewState.Add("Elections", elections);
                ViewState.Add("ActsPerformed", actsPerformed);

            }
        }

        protected void addAssetButton_Click(object sender, EventArgs e)
        {
            string[] assetName = (string[])ViewState["AssetName"];
            int[] elections = (int[])ViewState["Elections"];
            int[] actsPerformed = (int[])ViewState["ActsPerformed"];

            int newLength = assetName.Length + 1;

            Array.Resize(ref assetName, newLength);
            Array.Resize(ref elections, newLength);
            Array.Resize(ref actsPerformed, newLength);

            int newIndex = assetName.GetUpperBound(0);

            assetName[newIndex] = assetNameTextBox.Text;
            elections[newIndex] = int.Parse(electionsRiggedTextBox.Text);
            actsPerformed[newIndex] = int.Parse(subterfugePerformedTextBox.Text);

            ViewState["AssetName"] = assetName;
            ViewState["Elections"] = elections;
            ViewState["ActsPerformed"] = actsPerformed;

            resultLabel.Text = String.Format("Total Elections Rigged: {0}<br>" +
                "Average Acts of Subterfuge per Asset: {1:N2}<br>" +
                "(Last Asset you Added: {2})",
                elections.Sum(),
                actsPerformed.Average(),
                assetName[newIndex]);

            assetNameTextBox.Text = "";
            electionsRiggedTextBox.Text = "";
            subterfugePerformedTextBox.Text = "";

        }
    }
}