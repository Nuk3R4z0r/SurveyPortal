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
            if (sql.Login(emailBox.Text, passBox.Text))
            {
                statusLabel.ForeColor = Color.Green;
                statusLabel.Text = "Login succesful, redirecting...";
                Response.Redirect("Default.aspx");

            }
            else
            {
                statusLabel.ForeColor = Color.Red;
                statusLabel.Text = "Login failed, credentials invalid.";
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