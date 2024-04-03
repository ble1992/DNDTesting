using D_DTesting.Application.Common.Interfaces;
using D_DTesting.Domain.Abstractions;
using D_DTesting.Domain.Enums;
using D_DTesting.Domain.Extensions;
using PC = D_DTesting.Domain.Model.Objects;

namespace D_DTesting.Application.PlayableCharacterApplication.Commands.CreatePlayableCharacter
{
    public record CreatePlayableCharacterCommand : IRequest<Guid>
    {
        public string Name { get; init; }
        public Size Size { get; init; }
        public int MaxHealth { get; init; }
        public List<IAbilitiyScore> AbilitiyScores { get; init; }
        public List<IItem> Inventories { get; init; }
    }

    public class CreatePlayableCharacterCommandHandler(IApplicationDbContext<Guid> context) : IRequestHandler<CreatePlayableCharacterCommand, Guid> { 
        private readonly IApplicationDbContext<Guid> _context = context;

        public async Task<Guid> Handle(CreatePlayableCharacterCommand request, CancellationToken cancellationToken)
        {
            var entity = new PC.PlayableCharacter()
            {
                Name = request.Name,
                Size = request.Size,
                MaxHealth = request.MaxHealth,
                Abilities = request.AbilitiyScores,
                Inventories = request.Inventories
            };

            entity.SetSkills();
            entity.SetSavingThrows();

            _context.PlayableCharacters.Add(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return entity.Id;
        }
    }
}
