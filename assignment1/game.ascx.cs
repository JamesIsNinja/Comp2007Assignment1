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

        protected void txtScored_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Int32.Parse(txtScored.Text) < 0)
                {
                    lblWarning1.Text = "Value must be a #, and above one!";
                }
                else if (Int32.Parse(txtAllowed.Text) == Int32.Parse(txtScored.Text))
                {
                    lblWarning1.Text = "Scores can't be the same";

                }
                else
                {
                    lblWarning1.Text = "";
                    lblWarning2.Text = "";
                }
            }
            catch (Exception)
            {

            }
        }

        protected void txtAllowed_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Int32.Parse(txtAllowed.Text) < 0)
                {
                    lblWarning2.Text = "Value must be a #, and above one!";
                }
                else if (Int32.Parse(txtAllowed.Text) == Int32.Parse(txtScored.Text))
                {
                    lblWarning2.Text = "Scores can't be the same";
                }
                else
                {
                    lblWarning2.Text = "";
                    lblWarning1.Text = "";
                }
            }
            catch (Exception)
            {

            }
        }

        protected void txtSpec_TextChanged(object sender, EventArgs e)
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
        public bool validate()
        {
            try
            {
                if (Int32.Parse(txtAllowed.Text) != Int32.Parse(txtScored.Text) 
                    && Int32.Parse(txtAllowed.Text) > 0 
                    && Int32.Parse(txtScored.Text) > 0
                    && Int32.Parse(txtSpec.Text) >= 0
                    && rblWinLose.SelectedValue == "Win" || rblWinLose.SelectedValue == "Lose")
                {
                    return true;
                }
                else
                {

                    return false;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public int getScore()
        {
            return Int32.Parse(txtScored.Text);
        }
        public int getAllowed()
        {
            return Int32.Parse(txtAllowed.Text);
        }
        public int getSpecs()
        {
                return Int32.Parse(txtSpec.Text);
        }
        public string getWinLose()
        {
            return rblWinLose.SelectedValue;
        }
    }
}