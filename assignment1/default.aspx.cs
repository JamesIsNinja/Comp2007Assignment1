 /* James White, 200203355
 *  May 23rd, 2015
 * This is the C# file for the default.ascx file, it handles when the submits the values from the game.ascx objects, and displays the information
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace assignment1
{
    public partial class _default : System.Web.UI.Page
    {
        //Variables for wins and loses, global to be accessed from other methods.
        int wins;
        int loses;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        //On submit button clicked
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            //Set wins/loses to 0 by default.
            wins = 0;
            loses = 0;
            //ints for score, allowed and attendance
            int score = 0;
            int allow = 0;
            int attendance = 0;
            //Set the text for the warning to empty
            lblSubmitWarning.Text = "";
            //Check and make sure every game panel is valide.
            if (game.validate() && game1.validate() && game2.validate() && game3.validate())    
            {
                //Get the scores, allowed and attendance from each game and add them up
                score = game.getScore() + game1.getScore() + game2.getScore() + game3.getScore();
                allow = game.getAllowed() + game1.getAllowed() + game2.getAllowed() + game3.getAllowed();
                attendance = game.getSpecs() + game1.getSpecs() + game2.getSpecs() + game3.getSpecs();
                //Method that calculates the wins and loses
                calcWinsLoses();
                //If there are no loses, report 100%
                if (loses == 0)
                {
                    lblWinPercent.Text = "Winning %: 100";
                }
                //otherwise calculate the win %
                else
                {
                    lblWinPercent.Text = "Winning %: " + (wins / loses * 100).ToString();
                }
                //If there are no attendees report 0 average.
                if (attendance == 0)
                {
                    lblAvgAtt.Text = "Average Attendance: 0";
                }
                //Otherwise calculate the average
                else
                {
                    lblAvgAtt.Text ="Average Attendance: " + (attendance / 4).ToString();
                }
                //Display The Results
                lblPointScored.Text = "Points Scored: " + score.ToString();
                lblPointAllowed.Text = "Points Allowed: " + allow.ToString();
                lblPointDiff.Text = "Point Differential: " + (score - allow).ToString();
                lblTotalAtt.Text = "Total Attendance: " + attendance.ToString();
                lblWins.Text = "Wins: " + wins.ToString();
                lblLosses.Text = "Loses: " + loses.ToString();
                lblResults.Visible = true;
                lblResults.Visible = true;
                lblWins.Visible = true;
                lblPointScored.Visible = true;
                lblPointAllowed.Visible = true;
                lblPointDiff.Visible = true;
                lblTotalAtt.Visible = true;
                lblLosses.Visible = true;
                lblWinPercent.Visible = true;
                lblAvgAtt.Visible = true;  
            }
            //If a game didn't validate, give the user an error.
            else
            {
                lblSubmitWarning.Text = "Whoops, looks like you've forgot an input, or an input is invalid. Make sure every box has a value, and score/allowed do not match.";
            }
        }
        //Method that calculates the wins an loses
        protected void calcWinsLoses ()
        {
            //Temporary string to load the result from each game
            string temp;
            temp = game.getWinLose();
            //Check if the string is win or loss and tally it up for each game
            if (temp == "Win")
            {
                wins = wins + 1;
            }
            else
            {
                loses = loses + 1;
            }
            temp = game1.getWinLose();
            if (temp == "Win")
            {
                wins = wins + 1;
            }
            else
            {
                loses = loses + 1;
            }
            temp = game2.getWinLose();
            if (temp == "Win")
            {
                wins = wins + 1;
            }
            else
            {
                loses = loses + 1;
            }
            temp = game3.getWinLose();
            if (temp == "Win")
            {
                wins = wins + 1;
            }
            else
            {
                loses = loses + 1;
            }
            
        }
    }
}