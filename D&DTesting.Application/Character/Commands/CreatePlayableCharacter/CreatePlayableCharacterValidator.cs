namespace D_DTesting.Application.PlayableCharacter.Commands.CreatePlayableCharacter
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
