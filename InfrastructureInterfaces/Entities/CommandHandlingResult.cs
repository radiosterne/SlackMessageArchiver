using System;

namespace InfrastructureInterfaces.Entities
{
	public class CommandHandlingResult : ICommandHandlingResult
	{
		private CommandHandlingResult(bool succesful, string message)
		{
			Succesful = succesful;
			Message = message;
		}

		public bool Succesful { get; }

		public string Message { get; }

		public static CommandHandlingResult Success()
		{
			return new CommandHandlingResult(true, String.Empty);
		}

		public static CommandHandlingResult Fail(string message)
		{
			return new CommandHandlingResult(false, message);
		}
	}
}