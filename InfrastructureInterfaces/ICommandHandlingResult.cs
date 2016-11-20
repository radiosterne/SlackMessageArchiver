namespace InfrastructureInterfaces
{
	public interface ICommandHandlingResult
	{
		bool Succesful { get; }

		string Message { get; }
	}
}