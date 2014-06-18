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
        if (HttpContext.Current.Session["user"] != null)
        {
            panelList = new List<HtmlGenericControl>();
            btnList = new List<Button>();

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
                        if (btnList != null)
                            div.Controls.Add(btnList[counter]);

                        plcDiv.Controls.Add(div);

                        counter++;
                    }
                }
        }
        else
        {
            Response.Redirect("LoginPage.aspx");
        }
    }

    void SaveSession()
    {
        HttpContext.Current.Session["panelList"] = panelList;
        HttpContext.Current.Session["btnList"] = btnList;
        Response.Redirect(Request.RawUrl);
    }

    void AddSection(string title, object o, object u)
    {
        string section = "";
        
        section += title;
        if (o.GetType() == typeof(TextBox))
        {
            section += "tex";
        }
        else
        {
            section += "rad";
        }

        section += (counter + 1);

        HtmlGenericControl divPanel = new HtmlGenericControl("DIV");
        divPanel.Attributes["class"] = "panel panel-default";
        divPanel.Attributes["runat"] = "server";
        divPanel.ID = section;
        HtmlGenericControl divBody = new HtmlGenericControl("DIV");
        divBody.Attributes["class"] = "panel-body";
        HtmlGenericControl divBody2 = new HtmlGenericControl("DIV");
        divBody2.Attributes["class"] = "panel-body";
        divBody2.InnerHtml = "<h2>" + title + "</h2>";

        Button btn = new Button();
        btn.Text = "Delete";
        btn.ID = counter.ToString();

        plcDiv.Controls.Add(divPanel);
        btnList.Add(btn);
        divPanel.Controls.Add(divBody);
        divBody.Controls.Add(divBody2);
        divBody2.Controls.Add((Control)o);
        if (u != null)
        {
            divBody2.Controls.Add((Control)u);
        }

        propBox.Text = "";

        panelList.Add(divPanel);

        counter++;
    }

    protected void btnRadio_Click(object sender, EventArgs e)
    {
        addRadio(propBox.Text);
    }

    void addRadio(string text)
    {
        RadioButton rdb1 = new RadioButton();
        rdb1.ID = text + "Yes" + counter;
        rdb1.GroupName = text + counter;
        rdb1.Text = "Yes";

        RadioButton rdb2 = new RadioButton();
        rdb2.ID = text + "No" + counter;
        rdb2.GroupName = text + counter;
        rdb2.Text = "No";

        AddSection(text, rdb1, rdb2);
        SaveSession();
    }

    protected void btnBox_Click(object sender, EventArgs e)
    {
        addBox(propBox.Text);
    }

    void addBox(string text)
    {
        TextBox txtBox = new TextBox();
        txtBox.Attributes["placeholder"] = "Enter answer here";
        txtBox.ID = text + counter;

        AddSection(text, txtBox, null);
        SaveSession();
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

    protected void btnSave_Click(object sender, EventArgs e)
    {
        string metadata = "";

        foreach(HtmlGenericControl div in panelList)
        {
            metadata += div.ID + ";";
        }
        
        SQLHandler sql = new SQLHandler();
        sql.SaveSurvey(nameBox.Text, Convert.ToInt32(HttpContext.Current.Session["id"].ToString()), metadata, null);

        HttpContext.Current.Session["panelList"] = null;
        HttpContext.Current.Session["btnList"] = null;

        Response.Redirect("MySurveys.aspx");
    }
}