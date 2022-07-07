namespace CallApp.Domain.Respons.Models.Impementation;

public class EmailModel
{
    public string From { get; set; }
    public List<string> To { get; set; }
    public string Subject { get; set; }
    public string Body { get; set; }
    public bool IsBodyHtml { get; set; }
}
