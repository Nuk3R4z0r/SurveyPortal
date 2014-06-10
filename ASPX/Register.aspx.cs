using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

public partial class ASPX_Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        if(passBox.Text == confirmBox.Text)
        {
            SQLHandler sql = new SQLHandler();
            if(sql.CreateUser(emailBox.Text, passBox.Text))
            {
                statusLabel.ForeColor = Color.Green;
                statusLabel.Text = "User created successfully!";
            }
            else
            {
                statusLabel.ForeColor = Color.Red;
                statusLabel.Text = "Backend error, please try again";
            }
        }
        else
        {
            statusLabel.ForeColor = Color.Red;
            statusLabel.Text = "Passwords doesn't match!";
        }

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("LoginPage.aspx");
    }
}