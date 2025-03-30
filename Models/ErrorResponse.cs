namespace crud_dot_net.Models;

public class ErrorResponse : Exception
{
    public ErrorResponse(string message, string title, int? statusCode) : base(message)
    {
        Message = message;
        Title = title;
        StatusCode = statusCode;
    }
    public override string Message { get; }
    public string Title { get; set; }
    public int? StatusCode { get; set; }
}