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
        int wins;
        int loses;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            wins = 0;
            loses = 0;
            int score = 0;
            int allow = 0;
            int attendance = 0;

            lblSubmitWarning.Text = "";
            if (game.validate() && game1.validate() && game2.validate() && game3.validate())    
            {
                score = game.getScore() + game1.getScore() + game2.getScore() + game3.getScore();
                allow = game.getAllowed() + game1.getAllowed() + game2.getAllowed() + game3.getAllowed();
                attendance = game.getSpecs() + game1.getSpecs() + game2.getSpecs() + game3.getSpecs();
                calcWinsLoses();
                //Display Results
                lblPointScored.Text = "Points Scored: " + score.ToString();
                lblPointAllowed.Text = "Points Allowed: " + allow.ToString();
                lblPointDiff.Text = "Point Differential: " + (score - allow).ToString();
                lblTotalAtt.Text = "Total Attendance: " + attendance.ToString();
                lblWins.Text ="Wins: " + wins.ToString();
                lblLosses.Text = "Loses: "+ loses.ToString();
                if (loses == 0)
                {
                    lblWinPercent.Text = "Winning %: 100";
                }
                else
                {
                    lblWinPercent.Text = "Winning %: " + (wins / loses * 100).ToString();
                }
                if (attendance == 0)
                {
                    lblAvgAtt.Text = "Average Attendance: 0";
                }
                else
                {
                    lblAvgAtt.Text ="Average Attendance: " + (attendance / 4).ToString();
                }
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
            else
            {
                lblSubmitWarning.Text = "Whoops, looks like you've forgot an input, or an input is invalid. Make sure every box has a value, and score/allowed do not match.";
            }
            


        }
        protected void calcWinsLoses ()
        {
            string temp;
            temp = game.getWinLose();
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