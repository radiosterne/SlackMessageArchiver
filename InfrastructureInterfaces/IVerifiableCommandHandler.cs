using System.Threading.Tasks;

namespace InfrastructureInterfaces
{
	/// <summary>
	/// Интерфейс обработчика команд с подтверждением результата обработки.
	/// </summary>
	/// <typeparam name="TCommand"></typeparam>
	public interface IVerifiableCommandHandler<TCommand> where TCommand : class
	{
		/// <summary>
		/// Обрабатывает переданную команду.
		/// </summary>
		/// <param name="command"></param>
		/// <returns>Задача обработки команды.</returns>
		Task<IVerifiableCommandHandlingResult> HandleAsync(TCommand command);
	}
}