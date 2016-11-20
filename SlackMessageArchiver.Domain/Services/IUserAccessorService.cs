using InfrastructureInterfaces.Exceptions;
using SlackMessageArchiver.Interfaces;

namespace SlackMessageArchiver.Domain.Services
{
	/// <summary>
	/// Контракт сервиса получения объектов <see cref="User"/>.
	/// </summary>
	internal interface IUserAccessorService
	{
		/// <summary>
		/// Получает объект пользователя по его идентификатору.
		/// </summary>
		/// <param name="userId">Идентификатор пользователя.</param>
		/// <returns>Доменный объект пользователя.</returns>
		/// <exception cref="ObjectNotFoundException">Выбрасывается в случае отсутствия объекта в хранилище.</exception>
		User Get(string userId);
	}
}
