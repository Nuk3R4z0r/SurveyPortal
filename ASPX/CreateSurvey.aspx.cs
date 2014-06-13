using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

public partial class ASPX_CreateSurvey : System.Web.UI.Page
{
    int counter = 0;
    List<HtmlGenericControl> panelList;
    List<Button> btnList;

    protected void Page_Load(object sender, EventArgs e)
    {
        string load = Request.QueryString["load"];

        panelList = new List<HtmlGenericControl>();
        btnList = new List<Button>();

        if(load != null)
        if (HttpContext.Current.Session["panelList"] != null)
        {
            if (HttpContext.Current.Session["btnList"] != null)
            {
                btnList = (List<Button>)HttpContext.Current.Session["btnList"];

                    foreach (Button btn in btnList)
                    {
                        btn.Click += new EventHandler(btnDelete_Click);
                    }
            }

            panelList = (List<HtmlGenericControl>)HttpContext.Current.Session["panelList"];

            foreach (HtmlGenericControl div in panelList)
            {
                if(btnList != null)
                div.Controls.Add(btnList[counter]);

                div.ID = "Section " + (counter + 1);
                plcDiv.Controls.Add(div);

                counter++;
            }
        }
    }

    protected void btnSect_Click(object sender, EventArgs e)
    {
        AddSection(propBox.Text);
        SaveSession();
    }

    void SaveSession()
    {
        HttpContext.Current.Session["panelList"] = panelList;
        HttpContext.Current.Session["btnList"] = btnList;
        Response.Redirect(Request.RawUrl);
    }

    void AddSection(string title)
    {
        string section = "Section " + (counter + 1);

        HtmlGenericControl divPanel = new HtmlGenericControl("DIV");
        divPanel.Attributes["class"] = "panel panel-default";
        divPanel.Attributes["runat"] = "server";
        HtmlGenericControl divBody = new HtmlGenericControl("DIV");
        divBody.Attributes["class"] = "panel-body";
        HtmlGenericControl divBody2 = new HtmlGenericControl("DIV");
        divBody2.Attributes["class"] = "panel-body";
        divBody2.InnerHtml = "<h2>" + title + "</h2>";

        Button btn = new Button();
        btn.Text = "Delete";
        btn.ID = counter.ToString();
        /*btn.Attributes["OnCLick"] = "btnDelete_Click";
        btn.Click += new EventHandler(btnDelete_Click);*/

        plcDiv.Controls.Add(divPanel);
        btnList.Add(btn);
        divPanel.Controls.Add(divBody);
        divBody.Controls.Add(divBody2);

        propBox.Text = "";

        panelList.Add(divPanel);

        counter++;
    }

    protected void btnRadio_Click(object sender, EventArgs e)
    {

    }

    protected void btnBox_Click(object sender, EventArgs e)
    {

    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        int id = Convert.ToInt32(((Button)sender).ID);
        
        btnList.RemoveAt(id);

        for (int i = 0; i < btnList.Count; i++ )
        {
            if(i >= id)
            {
                int temp = Convert.ToInt32(btnList[i].ID) - 1;
                btnList[i].ID = temp.ToString();
            }
        }

        panelList.RemoveAt(id);
        SaveSession();
    }
}