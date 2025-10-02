using S627.INTRANET.COMMUNICATION.Requests;
using S627.INTRANET.COMMUNICATION.Responses;
using S627.INTRANET.EXCEPTION.ExceptionsBase;

namespace S627.INTRANET.APPLICATION.UseCases.Register;

public class RegisterParametroUseCase
{
    public ParametroResponse Execute(ParametroRequest request)
    {
        Validate(request);
        return new ParametroResponse();
    }

    private void Validate(ParametroRequest request)
    {
        var validator = new RegisterParametroValidator();

        var result = validator.Validate(request);

        if (result.IsValid == false)
        {
            var errorMessages = result.Errors.Select(f => f.ErrorMessage).ToList();
            throw new ErrorOnValidationException(errorMessages);
        }

    }
}
