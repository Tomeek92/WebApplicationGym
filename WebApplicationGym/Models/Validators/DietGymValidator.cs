using FluentValidation;
using WebApplicationGym.Models.Gym;

namespace WebApplicationGym.Models.Validators
{
    public class DietGymValidator : AbstractValidator<DietGym>
    {
        public DietGymValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Nazwa diety jest wymagana");
            RuleFor(x => x.Calories).NotEmpty().WithMessage("Liczba calorii jest wymagana");
            

        }
    }
}
