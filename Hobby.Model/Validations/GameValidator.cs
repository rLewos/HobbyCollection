using FluentValidation;

namespace Games.Model.Validations;

public class GameValidator : AbstractValidator<Game>
{
    public GameValidator()
    {
        RuleFor(g => g.Name).NotEmpty().NotNull();
    }
}