using PC = D_DTesting.Domain.Model.Objects;

namespace D_DTesting.Application.Common.Interfaces
{
    public interface IApplicationDbContext<T> where T : struct
    {
        DbSet<PC.PlayableCharacter> PlayableCharacters { get; set; }

        Task<T> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
