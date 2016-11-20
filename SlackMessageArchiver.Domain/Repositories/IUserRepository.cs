using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SlackMessageArchiver.Interfaces;

namespace SlackMessageArchiver.Domain.Repositories
{
	/// <summary>
	/// Репозиторий для работы с <see cref="User"/>.
	/// </summary>
	public interface IUserRepository
	{
		/// <summary>
		/// Возвращает доменный объект пользователя.
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		User Get(string id);
	}
}
