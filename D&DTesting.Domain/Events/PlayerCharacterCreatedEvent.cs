using D_DTesting.Domain.Common;
using D_DTesting.Domain.Model.Objects;

namespace D_DTesting.Domain.Events
{
    public class PlayerCharacterCreatedEvent : BaseEvent
    {
        public PlayerCharacterCreatedEvent(PlayableCharacter playerCharacter)
        {
            PlayerCharacter = playerCharacter;
        }

        public PlayableCharacter PlayerCharacter { get; }
    }
}
