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

    public bool Login(string email, string password)
    {
        SurveyPortalDBDataContext sql = new SurveyPortalDBDataContext();
        var pass = from u in sql.users where u.email == email select u.password;

        try
        {
            if (pass.Single() == password)
                return true;
            else
                return false;
        }
        catch(Exception e)
        {
            return false;
        }
    }

    public bool CreateUser(string username, string pass)
    {
        SurveyPortalDBDataContext sql = new SurveyPortalDBDataContext();
        user adduser = new user
        {
            email = username,
            password = pass
        };

        sql.users.InsertOnSubmit(adduser);

        try
        {
            sql.SubmitChanges();
            return true;
        }
        catch (Exception e)
        {
            return false;
        }
        
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