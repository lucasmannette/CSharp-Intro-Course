using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MegaChallengeCasino
{
    public partial class _default : System.Web.UI.Page
    {
        //create random object
        Random random = new Random();
        protected void Page_Load(object sender, EventArgs e)
        {
            //initial page load
            //create array with image names
            //set images
            //add PlayersMoney to viewstate
            //Set moneyLabel
            if (!IsPostBack)
            {
                string[] reels = new string[] { spinReel(), spinReel(), spinReel() };
                displayImages(reels);
                ViewState.Add("PlayersMoney", 100);
                displayPlayersMoney();
            }
        }
        //verify if int entered into textbox (output value as bet)
        //set winnings value
        protected void pullLeverButton_Click(object sender, EventArgs e)
        {
            int bet = 0;
            if (!int.TryParse(betTextBox.Text, out bet))
                return;

            int winnings = pullLever(bet);
            displayResult(bet, winnings);
            adjustPlayersMoney(bet, winnings);
            displayPlayersMoney();

        }

        //set moneyLabel
        //get PlayersMoney from viewstate
        private void displayPlayersMoney()
        {
            moneyLabel.Text = String.Format("Player's Money: {0:C}", ViewState["PlayersMoney"]); ;
        }

        //calculate players money based on winnings/losings
        //save to PlayersMoney viewstate
        private void adjustPlayersMoney(int bet, int winnings)
        {
            int playersMoney = int.Parse(ViewState["PlayersMoney"].ToString());
            playersMoney -= bet;
            playersMoney += winnings;
            ViewState["PlayersMoney"] = playersMoney;
        }
        
        //set resultLabel
        private void displayResult(int bet, int winnings)
        {
            if (winnings > 0)
                resultLabel.Text = String.Format("You bet {0:C} and won {1:C}!", bet, winnings);
            else
                resultLabel.Text = String.Format("Sorry you lost {0:C}. Better luck next time.", bet);
        }

        //set array of image names
        //display images
        //set multiplier
        //return money won
        private int pullLever(int bet)
        {
            string[] reels = new string[] { spinReel(), spinReel(), spinReel() };
            displayImages(reels);
            int multiplier = evaluateSpin(reels);
            return bet * multiplier;
        }

        //check for bars
        //check for jackpot
        //check how many cherries
        private int evaluateSpin(string[] reels)
        {
            if (isBar(reels))
                return 0;
            if (isJackpot(reels))
                return 100;
            int multiplier = 0;
            if (isWinner(reels, out multiplier))
                return multiplier;
            return 0;
        }

        //check how many cherries
        //return if winner or loser
        private bool isWinner(string[] reels, out int multiplier)
        {
            multiplier = determineMultiplier(reels);
            if(multiplier > 0)
            {
                return true;
            }
            return false;
        }

        //return multiplier based on number of cherries
        private int determineMultiplier(string[] reels)
        {
            int cherryCount = determineCherryCount(reels);
            if (cherryCount == 1) return 2;
            if (cherryCount == 2) return 3;
            if (cherryCount == 3) return 4;
            return 0;    
        }

        //calculate number of cherries
        private int determineCherryCount(string[] reels)
        {
            int cherryCount = 0;
            if (reels[0] == "Cherry")
                cherryCount++;
            if (reels[1] == "Cherry")
                cherryCount++;
            if (reels[2] == "Cherry")
                cherryCount++;
            return cherryCount;
        }

        //check for all sevens
        private bool isJackpot(string[] reels)
        {
            if (reels[0] == "Seven" && reels[1] == "Seven" && reels[2] == "Seven")
                return true;
            return false;
        }

        //check for any bars
        private bool isBar(string[] reels)
        {
            if (reels[0] == "Bar" || reels[1] == "Bar" || reels[2] == "Bar")
                return true;
            return false;
        }

        //set images
        private void displayImages(string[] reels)
        {
            slotOne.ImageUrl = "images/" + reels[0] + ".png";
            slotTwo.ImageUrl = "images/" + reels[1] + ".png";
            slotThree.ImageUrl = "images/" + reels[2] + ".png";
        }

        //set array with image names
        private string spinReel()
        {
            string[] slotImage = new string[] { "Bar", "Bell", "Cherry", "Clover", "Diamond", "HorseShoe", "Lemon", "Orange", "Plum", "Seven", "Strawberry", "Watermellon" };
            return slotImage[random.Next(12)];
        }

    }
}