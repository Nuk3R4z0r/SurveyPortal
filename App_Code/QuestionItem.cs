using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;


/// <summary>
/// Summary description for QuestionItem
/// </summary>
public class QuestionItem
{
    private int itemType;
    private string title;
    private RadioButtonList list;
    private object item;

	public QuestionItem(string title, int itemType)
	{
        this.title = title;
        this.itemType = itemType;
        if(itemType == 0)
        {
            list = new RadioButtonList();
            item = list;
        }
	}

    public void AddItem(string name)
    {
        if(itemType == 0)
        {
            list.Items.Add(name);
        }
        else
        {
            TextBox txtBox = new TextBox();
            txtBox.Width = 100;
            item = txtBox;
        }
    }

    public object GetItem()
    {
        return item;
    }

    public int GetItemType()
    {
        return itemType;
    }

    public string GetTitle()
    {
        return title;
    }
}