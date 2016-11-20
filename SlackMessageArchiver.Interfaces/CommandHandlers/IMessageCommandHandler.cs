using InfrastructureInterfaces;
using SlackMessageArchiver.Interfaces.Commands;

namespace SlackMessageArchiver.Interfaces.CommandHandlers
{
	public interface IMessageCommandHandler : ICommandHandler<CreateOrUpdateMessageCommand>
	{
	}
}