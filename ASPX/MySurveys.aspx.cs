using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (HttpContext.Current.Session["user"] != null)
        {
            SQLHandler sql = new SQLHandler();
            List<survey> surveyList = sql.ListSurveys(Convert.ToInt32(HttpContext.Current.Session["id"].ToString()));

            SurveyDiv.InnerHtml = "";
            int count = surveyList.Count;
            int counter = 0;

            foreach (survey s in surveyList)
            {
                counter++;
                HtmlGenericControl div = new HtmlGenericControl("DIV");
                div.Attributes["class"] = "form-group";
                div.Attributes["style"] = "padding-top:10px;";

                Label lblDate = new Label();
                lblDate.Text = s.creationDate + " | ";

                Button btnDel = new Button();
                btnDel.Click += new EventHandler(btnDelete);
                btnDel.ID = "del" + s.id;
                btnDel.Attributes["class"] = "btn btn-default";
                btnDel.Text = "Delete";

                Button btnRes = new Button();
                btnRes.Click += new EventHandler(btnResults);
                btnRes.ID = "res" + s.id;
                btnRes.Attributes["class"] = "btn btn-default";
                btnRes.Text = "Results";

                Label lblName = new Label();
                lblName.Text = s.name;

                HtmlGenericControl buttonDiv = new HtmlGenericControl("DIV");
                buttonDiv.Attributes["style"] = "float:right;margin-top:-10px;";

                div.Controls.Add(lblDate);
                div.Controls.Add(lblName);
                
                buttonDiv.Controls.Add(btnDel);
                buttonDiv.Controls.Add(btnRes);

                div.Controls.Add(buttonDiv);

                SurveyDiv.Controls.Add(div);

                if(counter != count)
                SurveyDiv.Controls.Add(new HtmlGenericControl("hr"));
            }
        }
        else
        {
            Response.Redirect("LoginPage.aspx");
        }
    }

    protected void btnDelete(object sender, EventArgs e)
    {
        SQLHandler sql = new SQLHandler();
        sql.DeleteSurvey(Convert.ToInt32(((Button)sender).ID.Substring(3)));
    }

    protected void btnResults(object sender, EventArgs e)
    {
        Response.Redirect("Results.aspx?load=" + ((Button)sender).ID.Substring(3));
    }
}