using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SQLHandler sql = new SQLHandler();
        List<survey> surveyList = sql.ListSurveys(Convert.ToInt32(HttpContext.Current.Session["id"].ToString()));

        SurveyDiv.InnerHtml = "";

        foreach(survey s in surveyList)
        {
            SurveyDiv.InnerHtml += "<div Class=\"form-group\">" + s.creationDate
                + " | <asp:Button runat=\"server\" OnClick=\"btnDelete\" class=\"btn btn-default\" ID=\"del" + s.id + "\" Text=\"Delete\"/>"
                + "<asp:Button runat=\"server\" OnClick=\"btnRadio_Click\" class=\"btn btn-default\" ID=\"res" + s.id + "\" Text=\"Results\"/>"
                + " | " + s.name + "</div>";
        }
    }

    protected void btnDelete(object sender, EventArgs e)
    {
        //((Button)sender).ID;
    }
}