using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

public partial class ASPX_CreateSurvey : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Createbtn_Click(object sender, EventArgs e)
    {
        HtmlGenericControl html1 = new HtmlGenericControl("div");
        html1.ID = "div" + 1;
        Button btn1 = new Button();
        btn1.Text = "test";
        New_Question.Controls.Add(html1);
        html1.Controls.Add(btn1);


    }
}