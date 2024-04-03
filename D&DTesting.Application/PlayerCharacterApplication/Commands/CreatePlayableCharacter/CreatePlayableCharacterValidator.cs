namespace D_DTesting.Application.PlayableCharacterApplication.Commands.CreatePlayableCharacter
{
    public class CreatePlayableCharacterValidator : AbstractValidator<CreatePlayableCharacterCommand>
    {
        public CreatePlayableCharacterValidator()
        {
            RuleFor(v => v.Name)
                .MaximumLength(200)
                .NotEmpty();
        }
    }
}
