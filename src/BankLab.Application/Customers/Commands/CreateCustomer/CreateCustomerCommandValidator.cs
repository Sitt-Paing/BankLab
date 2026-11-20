using FluentValidation;

namespace BankLab.Application.Customers.Commands.CreateCustomer;

public sealed class CreateCustomerCommandValidator: AbstractValidator<CreateCustomerCommand>
{
    public CreateCustomerCommandValidator()
    {
        RuleFor(x => x.FullName).NotEmpty().MaximumLength(200);
        RuleFor(x => x.Email).NotEmpty().MaximumLength(200);
        RuleFor(x => x.Address).NotEmpty().MaximumLength(500);
        RuleFor(x => x.PhoneNo).NotEmpty().MaximumLength(100);
        RuleFor(x => x.FatherName).NotEmpty().MaximumLength(200);
        RuleFor(x => x.Nrc).NotEmpty().MaximumLength(100);

        RuleFor(x => x.DateOfBirth)
            .NotEmpty()
            .LessThanOrEqualTo(_ => DateOnly.FromDateTime(DateTime.Today))
            .WithMessage("Date of birth cannot be in the future.");
    }
}