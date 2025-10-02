namespace S627.INTRANET.EXCEPTION.ExceptionsBase;

public class ErrorOnValidationException : IntranetException
{
    public List<string> Errors { get; set; }
    public ErrorOnValidationException(List<string> errorMessages)
    {
        Errors = errorMessages;
    }
}
