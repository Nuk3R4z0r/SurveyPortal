using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;

/// <summary>
/// Summary description for SMTPHandler
/// </summary>
public class SMTPHandler
{
    public void SendActivation(string activation, string email, string username, string pass)
    {
        SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
        client.Credentials = new NetworkCredential("surveyportal2014@gmail.com", "pollepalle");
        client.EnableSsl = true;

        client.Send("surveyportal2014@gmail.com", email,
            "SurveyPortal Validation", "Welcome to SurveyPortal, " + username + "!\n\n" + 
            "Your password is: " + pass + "\nPlease click to following link to activate your account:\n" +
            "http://localhost:50316/ASPX/Activation.aspx?code=" + activation +
            "\n\nClick here to log in after activating your account:\n" + "http://localhost:50316/ASPX/LoginPage.aspx");
    }
}