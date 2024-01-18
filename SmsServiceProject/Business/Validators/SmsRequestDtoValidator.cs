using FluentValidation;
using SmsServiceProject.Dtos;

namespace SmsServiceProject.Business.Validators
{
    public class SmsRequestDtoValidator : AbstractValidator<SmsRequestDto>
    {
        public SmsRequestDtoValidator()
        {
            RuleFor(x => x.PhoneNumber)
                .NotEmpty()
                .WithMessage("Phone number is required.")
                .MaximumLength(20)
                .WithMessage("Phone number cannot be longer than 20 characters.")
                .Matches(@"^\+\d+$")
                .WithMessage("Phone number is not valid.");

            RuleFor(x => x.Message)
                .NotEmpty()
                .WithMessage("Message is required.")
                .MaximumLength(480)
                .WithMessage("Message cannot be longer than 480 characters.");
        }
    }
}