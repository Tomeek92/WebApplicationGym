using FluentValidation;
using WebApplicationGym.Models.Gym;

namespace WebApplicationGym.Models.Validators
{
    public class ExerciseGymValidator : AbstractValidator<ExerciseGym>
    {
        public ExerciseGymValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Nazwa ćwiczenia musi być wpisana!");
            RuleFor(x => x.SeriesOfExercise).NotEmpty().WithMessage("Ilość serii musi być wpisana");
            RuleFor(x => x.Weight).NotEmpty().WithMessage("Należy wpisać obciążenie");
        }
    }
}
