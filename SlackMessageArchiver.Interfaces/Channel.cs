using System;
using System.Diagnostics.Contracts;

namespace SlackMessageArchiver.Interfaces
{
	/// <summary>
	/// Доменный объект канала сообщений. Идентификатором канала является его имя.
	/// </summary>
	public sealed class Channel
	{
		/// <summary>
		/// Имя канала.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Признак архивности канала.
		/// </summary>
		public bool IsArchived { get; set; }

		/// <summary>
		/// Описание канала.
		/// </summary>
		public string ChannelPurpose { get; set; }

		[ContractInvariantMethod]
		private void ObjectInvariant()
		{
			Contract.Invariant(!String.IsNullOrEmpty(Name));
			Contract.Invariant(Name.StartsWith("#"));
			Contract.Invariant(ChannelPurpose != null);
		}
	}
}
