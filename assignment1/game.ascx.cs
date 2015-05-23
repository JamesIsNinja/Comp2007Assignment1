/**
 * James White, 200203355
 *  May 23rd, 2015
 * This is the C# file for the game.ascx file, it handles when the user changes values on the game page, and validates the information. 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace assignment1
{
    
    public partial class WebUserControl1 : System.Web.UI.UserControl
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        //When the user changes the score value
        protected void txtScored_TextChanged(object sender, EventArgs e)
        {
            //Try to parse what they entered, and if it's less then 0, or equal to allowed, tell the user the error.
            try
            {
                if (Int32.Parse(txtScored.Text) >= 0)
                {
                    lblWarning1.Text = "";

                }
                else
                {
                    lblWarning1.Text = "Value must be a #, and above one";


                }
                if (Int32.Parse(txtAllowed.Text) == Int32.Parse(txtScored.Text))
                {
                    lblWarning4.Text = "Scores can't be the same";
                }
                    //Else clear warning messages and move on.
                else
                {
                    lblWarning4.Text = "";
                }
            }
                //catch for an error when parsing
            catch (Exception q)
            {
               
            }
        }
        //When the user changes the allowed value
        protected void txtAllowed_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //Try to parse what they entered, and if it's less then 0, or equal to allowed, tell the user the error.
                if (Int32.Parse(txtAllowed.Text) < 0)
                {
                    lblWarning2.Text = "Value must be a #, and above one";
                }
                else
                {
                    lblWarning2.Text = "";

                }
                if (Int32.Parse(txtAllowed.Text) == Int32.Parse(txtScored.Text))
                {
                    lblWarning4.Text = "Scores can't be the same";
                }
                //Else clear warning messages and move on.
                else
                {
                    lblWarning4.Text = "";
                }
            }
            //catch for an error when parsing
            catch (Exception r)
            {
            }
        }
        //When the user changes the spectator value
        protected void txtSpec_TextChanged(object sender, EventArgs e)
        {
            //Try to parse what the user inputs
            try
            {
                if (Int32.Parse(txtSpec.Text) < 0)
                {
                    lblWarning3.Text = "Value must be numeric, 0 or more.";
                }
                else
                {
                    lblWarning3.Text = "";
                }
            }
            //Catch any errors
            catch (Exception s)
            {
            }
        }
        //Method to call when the user clicks submit, validates all input fields at once.
        public bool validate()
        {
            //Try incase there are parsing errors.
            try
            {
                //If statement that checks the allowed and score aren't the same, as well as both above or equal to 0, >=0 spectators, and make sure win or lose is picked.
                if (Int32.Parse(txtAllowed.Text) != Int32.Parse(txtScored.Text) 
                    && Int32.Parse(txtAllowed.Text) >= 0 
                    && Int32.Parse(txtScored.Text) >= 0
                    && Int32.Parse(txtSpec.Text) >= 0
                    && rblWinLose.SelectedValue == "Win" || rblWinLose.SelectedValue == "Lose")
                {
                    //return everything is validated
                    return true;
                }
                    //Otherwise return false
                else
                {
                    return false;
                }
            }
            //Catch any parsing errors and return false
            catch (Exception e)
            {
                return false;
            }
        }
        //Method to get the int value of score
        public int getScore()
        {
            return Int32.Parse(txtScored.Text);
        }
        //Method to get the int value of allowed
        public int getAllowed()
        {
            return Int32.Parse(txtAllowed.Text);
        }
        //Method to get the int value of spectators
        public int getSpecs()
        {
                return Int32.Parse(txtSpec.Text);
        }
        //Method to get the win, or lose selected value
        public string getWinLose()
        {
            return rblWinLose.SelectedValue;
        }
    }
}