using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DustinCrawford.Web.Concrete
{

    public class EmailSettings
    {
        public string MailToAddress = "dustindjc92@gmail.com";
        public string MailFromAddress = "dustindjc92@gmail.com";
        public bool UseSsl = true;
        public string Username;
        public string Password;
        public string ServerName;
        public int ServerPort;
        public bool WriteAsFile = false;
        public string FileLocation = @"C:\Users\dustin.crawford\Documents\SportsStoreEmails";
    }

    public class EmailMessageProcessor
    {




    }
}