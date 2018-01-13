using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengePhunWithStrings
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // 1.  Reverse your name
            string name = "Lucas Mannette";
            // In my case, the result would be:
            // ettennaM sacuL
            string reverseName = "";
            for (int i = name.Length - 1; i >= 0; i--)
            {
                reverseName += name[i];
            }

            resultLabel.Text = reverseName;

            // 2.  Reverse this sequence:
            string names = "Luke,Leia,Han,Chewbacca";
            // When you're finished it should look like this:
            // Chewbacca,Han,Leia,Luke
            string reverseNames = "";
            string[] reverseArray = names.Split(',');
            for (int i = reverseArray.Length - 1; i >= 0; i--)
            {
                reverseNames += reverseArray[i];
                
            }
            reverseNames = reverseNames.Remove(reverseNames.Length - 1, 1);
            resultLabel.Text = reverseNames;

            // 3. Use the sequence to create ascii art:
            // *****luke*****
            // *****leia*****
            // *****han******
            // **Chewbacca***
            string namesArt = "";
            for (int i = 0; i < reverseArray.Length; i++)
            {
                namesArt += reverseArray[i].PadLeft(reverseArray[i].Length + (14 - reverseArray[i].Length) / 2, '*').PadRight(14, '*') + "<br>";
            }

            resultLabel.Text = namesArt;


            // 4. Solve this puzzle:

            string puzzle = "NOW IS ZHEremove-me ZIME FOR ALL GOOD MEN ZO COME ZO ZHE AID OF ZHEIR COUNZRY.";

            // Once you fix it with string helper methods, it should read:
            // Now is the time for all good men to come to the aid of their country.

            //Instructor Solution
            //string removeMe = "remove-me";
            //int index = puzzle.IndexOf(removeMe); 
            //puzzle = puzzle.Remove(index, removeMe.Length);
            //puzzle = puzzle.ToLower();
            //puzzle = puzzle.Replace('z', 't');
            //puzzle = puzzle.Remove(0, 1);
            //puzzle = puzzle.Insert(0, "N");

            //My Solution
            puzzle = puzzle.Substring(0,1)  + puzzle.Substring(1).Replace("Z","T").Replace("remove-me","").ToLower();

            resultLabel.Text = puzzle;

        }
    }
}