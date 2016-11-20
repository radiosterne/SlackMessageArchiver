using SlackMessageArchiver.Interfaces;

namespace SlackMessageArchiver.Domain.Services
{
	/// <summary>
	/// Контракт сервиса создания объектов <see cref="Message"/>.
	/// </summary>
	internal interface IMessageGeneratorService
	{
		/// <summary>
		/// Создаёт сообщение в хранилище или обновляет его состояние.
		/// </summary>
		/// <param name="message">Сообщение.</param>
		void CreateOrUpdate(Message message);
	}
}
