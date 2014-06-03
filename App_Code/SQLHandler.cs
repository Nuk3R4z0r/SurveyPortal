using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

/// <summary>
/// Summary description for SQLHandler
/// </summary>
public class SQLHandler
{
    SqlConnection conn;

	public SQLHandler()
	{
        conn = new SqlConnection("");
	}

    public bool Login(string username, string password)
    {
        return false;
    }

    public bool CreateUser(string username, string password)
    {
        return false;
    }

    public string ListSurveys()
    {
        return "";
    }

    public string GetSurvey()
    {
        return "";
    }

    public string ListResults()
    {
        return "";
    }

    public string GetResult()
    {
        return "";
    }
}