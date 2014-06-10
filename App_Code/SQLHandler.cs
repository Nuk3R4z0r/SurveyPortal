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
    SurveyPortalDBDataContext sql;

	public SQLHandler()
	{
        sql = new SurveyPortalDBDataContext();
	}

    public bool Login(string email, string password)
    {
        var pass = from u in sql.users where u.email == email select u.password;
        string rawr = pass.Single().ToString();
        if (rawr == password)
            return true;
        else
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