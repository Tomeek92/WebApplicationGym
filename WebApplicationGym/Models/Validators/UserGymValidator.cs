using FluentValidation;
using WebApplicationGym.Models.Gym;

namespace WebApplicationGym.Models.Validators
{
    public class UserGymValidator : AbstractValidator<UserGym>
    {
        public UserGymValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Nazwa użytkownika musi być wpisana!");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email należy wpisać!");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Należy wpisać nazwisko!");
            RuleFor(x => x.Address).NotEmpty().WithMessage("Należy wpisać adres");
        }
    }
}
