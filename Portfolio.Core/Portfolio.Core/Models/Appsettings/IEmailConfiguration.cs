namespace Portfolio.Core.Models.Appsettings
{
    public interface IEmailConfiguration
    {
        string Password { get; set; }
        int Port { get; set; }
        string Reciever { get; set; }
        string SenderEmail { get; set; }
        string SenderName { get; set; }
        string SmtpServer { get; set; }
        string UserName { get; set; }
    }
}