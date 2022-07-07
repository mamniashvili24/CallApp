namespace CallApp.Api.Model;

public class NotificationModel
{
    public string From { get; set; }
    public List<string> To { get; set; }
    public string Subject { get; set; }
    public string Body { get; set; }
    public bool IsBodyHtml { get; set; }
}