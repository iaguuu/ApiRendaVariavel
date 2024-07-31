using ApiRendaVariavel.Domain.DTOs;
using ApiRendaVariavel.Domain.Enums;
using FluentValidation;

namespace ApiRendaVariavel.Domain.Validations
{
    public class FundoImobiliarioValidator : AbstractValidator<FundoImobiliarioDTO>
    {
        public FundoImobiliarioValidator()
        {
            RuleFor(x => x.Ticker)
                .NotEmpty()
                .NotNull()
                .WithMessage("Ticker vazio ou em branco. Certifique-se de preenchê-lo")
                .MinimumLength(6)
                .WithMessage("O ticker deve ter ao menos 6 caracteres")
                .MaximumLength(15)
                .WithMessage("O ticker tem o máximo de 15 caracteres")
                .Must(str => str.EndsWith("11"))
                .WithMessage("O ticker deve terminar com 11");

            RuleFor(x => x.tipoFundoImobiliario)
                .IsInEnum()
                .Must(x => x.GetType().Equals(typeof(FundoImobiliarioType)) && Enum.IsDefined(typeof(FundoImobiliarioType), x.Value))
                .WithMessage("O tipo de fundo imobiliario valor válido do Enum tipoFundoImobiliario");

        }
    }
}

/*
namespace ApiRendaVariavel.Domain.Validations
{
    public class FundoImobiliarioValidator
    {
        public ValidationError ValidateFundoImobiliario(FundoImobiliarioDTO fundoImobiliarioDTO)
        {
            var validation = new ValidationError
            {
                Messages = []
            };

            if (string.IsNullOrEmpty(fundoImobiliarioDTO.Ticker)) {
                validation.Messages.Add("Ticker vazio ou em branco. Certifique-se de preenchê-lo");
                return validation;
            }                

            if (!fundoImobiliarioDTO.Ticker.EndsWith("11"))
                validation.Messages.Add("O ticker do fundo imobiliário deve terminar com '11'");

            if (fundoImobiliarioDTO.Ticker.Length < 6)
                validation.Messages.Add("O ticker deve ter ao menos 6 caracteres");

            if (fundoImobiliarioDTO.Ticker.Length > 15)
                validation.Messages.Add("O ticker deve ter ao menos 15 caracteres");

            Type TypeFundoImobiliario = fundoImobiliarioDTO.tipoFundoImobiliario.GetType();
            FundoImobiliarioType tipoFundoImobiliario = fundoImobiliarioDTO.tipoFundoImobiliario;

            if (!TypeFundoImobiliario.IsEnum)
                validation.Messages.Add("Indice de tipo de fundo imobiliario inválido");

            if (!Enum.IsDefined(TypeFundoImobiliario, tipoFundoImobiliario))
                validation.Messages.Add($"Tipo de fundo imobiliario inválido: {tipoFundoImobiliario}");
           
            return validation;
        }
    }
}
*/