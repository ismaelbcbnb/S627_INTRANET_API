using Microsoft.AspNetCore.Mvc;
using S627.INTRANET.APPLICATION.UseCases.Register;
using S627.INTRANET.COMMUNICATION.Requests;
using S627.INTRANET.COMMUNICATION.Responses;
using S627.INTRANET.EXCEPTION.ExceptionsBase;

namespace S627.INTRANET.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ParametroController : ControllerBase
{
    [HttpPost]
    public IActionResult Register([FromBody] ParametroRequest request)
    {
        try
        {
            var useCase = new RegisterParametroUseCase();
            var response = useCase.Execute(request);

            return Created(string.Empty, response);
        }
        catch (ErrorOnValidationException ex)
        {
            var errorMessage = new ErrorResponse(ex.Errors);

            return BadRequest(errorMessage);
        }
        catch
        {
            var errorMessage = new ErrorResponse("Erro Desconhecido.");

            return StatusCode(StatusCodes.Status500InternalServerError, errorMessage);
        }
    }
}
