using FluentValidation;
using S627.INTRANET.COMMUNICATION.Requests;

namespace S627.INTRANET.APPLICATION.UseCases.Register;

public class RegisterParametroValidator : AbstractValidator<ParametroRequest>
{
    public RegisterParametroValidator()
    {
        RuleFor(p => p.Codigo).GreaterThan(0).WithMessage("O código precisa ser maior que 0.");
        RuleFor(p => p.NomeParametro).NotEmpty().WithMessage("O nome do parâmetro não pode estar vazio.");
        RuleFor(p => p.ValorParametro).NotEmpty().WithMessage("O valor do parâmetro não pode estar vazio.");
        RuleFor(p => p.DescricaoParametro).NotEmpty().WithMessage("A descrição do parâmetro não pode estar vazia.");

    }
}
