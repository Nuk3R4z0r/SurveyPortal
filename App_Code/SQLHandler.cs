﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

/// <summary>
/// Summary description for SQLHandler
/// </summary>
public class SQLHandler
{

    public int Login(string email, string password)
    {
        SurveyPortalDBDataContext sql = new SurveyPortalDBDataContext();

        try
        {
            var ena = (from u in sql.users where u.email == email select u).Single();

            if((bool)ena.isEnabled)
            {

                if (ena.password == password)
                {
                    HttpContext.Current.Session["user"] = ena.username;
                    HttpContext.Current.Session["id"] = ena.id;
                    return 0;
                }
                else
                    return 1;
            }
            else
            {
                return 2;
            }
        }
        catch(Exception e)
        {
            return 1;
        }
    }

    public int CreateUser(string email, string pass, string user)
    {
        SurveyPortalDBDataContext sql = new SurveyPortalDBDataContext();

        try
        {
            var check = (from u in sql.users where u.username == user select u).FirstOrDefault();
            if (check.username.ToLower() == user.ToLower())
            {
                return 2;
            }
        }
        catch (Exception e) { }
        try
        {
            var check = (from u in sql.users where u.email == email select u).FirstOrDefault();
            if (check.email.ToLower() == email.ToLower())
            {
                return 3;
            }
        }
        catch (Exception e) { }

        user adduser = new user
        {
            email = email,
            password = pass,
            username = user,
            isEnabled = false
        };

        sql.users.InsertOnSubmit(adduser);

        try
        {
            sql.SubmitChanges();

            RNG rng = new RNG();

            string activation = "";
            for(int i = 0; i < 16; i++)
            {
                int type = rng.NextRandom(0, 1);
                char c;
                if(type == 0)
                {
                    c = (char)rng.NextRandom(48, 57);
                }
                else
                {
                    c = (char)rng.NextRandom(65, 90);
                }

                activation += c;
            }

            validationcode valid = new validationcode
            {
                userid = adduser.id,
                code = activation
            };

            sql.validationcodes.InsertOnSubmit(valid);

            try
            {
                sql.SubmitChanges();
            }
            catch(Exception n)
            {

            }

            SMTPHandler smtp = new SMTPHandler();
            smtp.SendActivation(activation, email, user, pass);
            return 0;
        }
        catch (Exception e)
        {
            return 1;
        }
    }

    public bool ActivateAccount(string code)
    {
        SurveyPortalDBDataContext sql = new SurveyPortalDBDataContext();
        try
        {
            var validation = (from v in sql.validationcodes where v.code == code select v).Single();
            var cUser = (from u in sql.users where u.id == ((validationcode)validation).userid select u).Single();

            cUser.isEnabled = true;

            sql.validationcodes.DeleteOnSubmit(validation);

            sql.SubmitChanges();
        }
        catch (Exception e) { return false; }
        
        return true;
    }

    public List<survey> ListSurveys(int id)
    {
        SurveyPortalDBDataContext sql = new SurveyPortalDBDataContext();
        List<survey> surveyList = new List<survey>();

        try
        {
            var surveys = from v in sql.surveys where v.userid == id select v;

            foreach(survey s in surveys)
            {
                surveyList.Add(s);
            }
        }
        catch (Exception e) {  }

        return surveyList;
    }

    public void SaveSurvey(string surveyName, int id, string surveyMetadata, string endOfLife)
    {
        try
        {
            survey addsurvey = new survey
            {
                name = surveyName,
                userid = id,
                metadata = surveyMetadata,
                creationDate = DateTime.Now.ToShortDateString(),
                endDate = endOfLife
            };

            SurveyPortalDBDataContext sql = new SurveyPortalDBDataContext();
            sql.surveys.InsertOnSubmit(addsurvey);

            sql.SubmitChanges();
        }
        catch (Exception e) {}
    }

    public void DeleteSurvey(int id)
    {
        SurveyPortalDBDataContext sql = new SurveyPortalDBDataContext();
        var survey = (from v in sql.surveys where v.id == id select v).Single();

        sql.surveys.DeleteOnSubmit(survey);
        sql.SubmitChanges();
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