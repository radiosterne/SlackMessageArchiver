using InfrastructureInterfaces.Enums;

namespace InfrastructureInterfaces
{
	public interface IVerifiableCommandHandlingResult
	{
		CommandHandlingStatus CommandHandlingStatus { get; }
		string Message { get; }
	}
}