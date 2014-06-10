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
    public void SendActivation(string username, string email)
    {
        SmtpClient client = new SmtpClient();
        MailAddress sendTo = new MailAddress(email);
        MailAddress from = new MailAddress("no-reply@surveyportal.com");
        MailMessage message = new MailMessage(from, sendTo);
        message.IsBodyHtml = false;
        message.Subject = "SurveyPortal Validation";
        message.Body = "Please click to following link to validate your account:\n";
        NetworkCredential nc = new NetworkCredential("surveyportal2014@gmail.com", "pollepalle");
        client.Host = "smtp.gmail.com";
        client.UseDefaultCredentials = false;

        client.Port = 25;
        client.Credentials = nc;
        client.EnableSsl = true;
        try
        {
            client.Send(message);
        }
        catch (Exception ex)
        {
        }
    }
}