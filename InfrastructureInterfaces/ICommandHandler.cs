namespace InfrastructureInterfaces
{
	/// <summary>
	/// Интерфейс обработчика команд типа fire-and-forget.
	/// </summary>
	/// <typeparam name="TCommand">Тип обрабатываемой команды.</typeparam>
	public interface ICommandHandler<TCommand> where TCommand : class
	{
		/// <summary>
		/// Инициирует обработку переданной команды.
		/// </summary>
		/// <param name="command"></param>
		/// <returns>Результат попытки инициирования процесса обработки.</returns>
		/// <remarks>
		/// Результат, который возвращает этот метод, не имеет ничего общего с результатом выполнения команды.
		/// В результате вызова этого метода, команда может быть передана дальше по цепи удалённых обработчиков с немедленным возвратом отсюда.
		/// </remarks>
		ICommandHandlingResult Handle(TCommand command);
	}
}
