using D_DTesting.Domain.Events;
using Microsoft.Extensions.Logging;

namespace D_DTesting.Application.PlayableCharacterApplication.EventHandlers
{
    public class PlayerCharacterCompletedEventHandler(ILogger<PlayerCharacterCompletedEvent> logger) : INotificationHandler<PlayerCharacterCompletedEvent>
    {
        private readonly ILogger<PlayerCharacterCompletedEvent> _logger = logger;
        public Task Handle(PlayerCharacterCompletedEvent notification, CancellationToken cancellationToken)
        {
            _logger.LogInformation("D%26DTesting Domain Event: {DomainEvent}", notification.GetType().Name);
            return Task.CompletedTask;
        }
    }
}
