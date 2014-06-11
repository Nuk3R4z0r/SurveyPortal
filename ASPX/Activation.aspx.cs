using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ASPX_Activation : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string code = Request.QueryString["code"];

        if(code!= null && code.Length == 16)
        {
            SQLHandler sql = new SQLHandler();
            if(sql.ActivateAccount(code))
            {
                statusLabel.Text = "Invalid or expired verificationcode";
            }
            else
            {
                statusLabel.Text = "Account activated!";
            }
        }
    }
}