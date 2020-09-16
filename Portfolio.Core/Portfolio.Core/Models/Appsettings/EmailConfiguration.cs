using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Core.Models.Appsettings
{
    public class EmailConfiguration : IEmailConfiguration
    {
        public string SenderEmail { get; set; }
        public string SenderName { get; set; }
        public string Reciever { get; set; }
        public string SmtpServer { get; set; }
        public int Port { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
