namespace S627.INTRANET.COMMUNICATION.Responses;

public class ErrorResponse
{
    public List<string> ErrorMessages { get; set; }

    public ErrorResponse(List<string> errorMessages)
    {
        ErrorMessages = errorMessages;
    }

    public ErrorResponse(string errorMessage)
    {
        ErrorMessages = [errorMessage];
    }
}
