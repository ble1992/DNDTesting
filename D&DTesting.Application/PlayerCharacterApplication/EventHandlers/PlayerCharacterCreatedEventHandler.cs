using D_DTesting.Domain.Events;
using Microsoft.Extensions.Logging;

namespace D_DTesting.Application.PlayableCharacterApplication.EventHandlers
{
    internal class PlayerCharacterCreatedEventHandler(ILogger<PlayerCharacterCreatedEventHandler> logger) 
        : INotificationHandler<PlayerCharacterCreatedEvent>
    {
        private readonly ILogger<PlayerCharacterCreatedEventHandler> _logger = logger;

        public Task Handle(PlayerCharacterCreatedEvent notification, CancellationToken cancellationToken)
        {
            _logger.LogInformation("D%26DTesting Domain Event: {DomainEvent}", notification);

            return Task.CompletedTask;
        }
    }
}
