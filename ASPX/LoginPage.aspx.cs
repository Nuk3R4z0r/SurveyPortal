using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Drawing;
using System.Web.UI.WebControls;
using System.Threading;

public partial class LoginPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Login_Click(object sender, EventArgs e)
    {
        SQLHandler sql = new SQLHandler();
        try
        {
            int code = sql.Login(emailBox.Text, passBox.Text);
            if (code == 0)
            {
                statusLabel.ForeColor = Color.Green;
                statusLabel.Text = "Login succesful, redirecting...";
                Response.Redirect("MainPage.aspx");
            }
            else if(code == 1)
            {
                statusLabel.ForeColor = Color.Red;
                statusLabel.Text = "Login failed, credentials invalid.";
            }
            else if (code == 2)
            {
                statusLabel.ForeColor = Color.Red;
                statusLabel.Text = "Account is disabled.";
            }
        }
        catch(Exception n)
        {
            statusLabel.ForeColor = Color.Red;
            statusLabel.Text = "Backend error, please try again.";
        }
    }

    protected void Register_Click(object sender, EventArgs e)
    {
        Response.Redirect("Register.aspx");
    }
}