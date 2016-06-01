using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Net;
using System.Net.Mail;

namespace WebApplication2
{
    public partial class Contacts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            //sending email using SMTP
            //using (MailMessage mm = new MailMessage(EmailTextBox.Text, "sampsunny1995@gmail.com"))
            //{
            //    mm.Subject = FirstNameTextBox.Text + " " + LastNameTextBox.Text;
            //    mm.Body = MessageTextBox.Text;
            //    mm.IsBodyHtml = false;
            //    SmtpClient smtp = new SmtpClient();
            //    smtp.Host = "smtp.gmail.com";
            //    smtp.EnableSsl = true;
            //    NetworkCredential NetworkCred = new NetworkCredential("myEmailID", "MyIDPassword");
            //    smtp.UseDefaultCredentials = false;
            //    smtp.Credentials = NetworkCred;
            //    smtp.Port = 587;
            //    smtp.Send(mm);
            //    ClientScript.RegisterStartupScript(GetType(), "alert", "alert('Email sent.');", true);
            //}
            Response.Redirect("Default.aspx");
        }
    }
}