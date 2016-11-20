using InfrastructureInterfaces.Exceptions;
using SlackMessageArchiver.Interfaces;

namespace SlackMessageArchiver.Domain.Services
{
	/// <summary>
	/// Контракт сервиса получения объектов <see cref="Channel"/>.
	/// </summary>
	internal interface IChannelAccessorService
	{
		/// <summary>
		/// Получает объект канала по его идентификатору.
		/// </summary>
		/// <param name="channelId">Идентификатор канала.</param>
		/// <returns>Доменный объект канала.</returns>
		/// <exception cref="ObjectNotFoundException">Выбрасывается в случае отсутствия объекта в хранилище.</exception>
		Channel Get(string channelId);
	}
}
