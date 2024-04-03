using D_DTesting.Domain.Model.Objects;
using MediatR;

namespace D_DTesting.Domain.Events
{
    public class PlayerCharacterCompletedEvent : INotification
    {
        public PlayerCharacterCompletedEvent(PlayableCharacter playerCharacter)
        {
            PlayerCharacter = playerCharacter;
        }

        public PlayableCharacter PlayerCharacter { get; }
    }
}
