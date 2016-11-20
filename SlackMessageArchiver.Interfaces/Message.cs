using System;
using System.Diagnostics.Contracts;

namespace SlackMessageArchiver.Interfaces
{
	/// <summary>
	/// Доменный объект сообщения. Идентификатором сообщения является пара «Таймстамп сообщения — Имя канала».
	/// </summary>
	public sealed class Message
	{
		public Message(int timestamp, string text, bool isDeleted, User user, Channel channel)
		{
			Contract.Requires(user != null);
			Contract.Requires(channel != null);
			Contract.Ensures(!String.IsNullOrEmpty(text));
			Contract.Ensures(timestamp > 0);

			if (timestamp < 0)
			{
				throw new ArgumentException("Timestamp cannot be less then zero.", nameof(timestamp));
			}

			if (text == null)
			{
				throw new ArgumentException("Text cannot be null.", nameof(text));
			}

			if (text.Length == 0)
			{
				throw new ArgumentException("Text cannot be empty.", nameof(text));
			}

			Timestamp = timestamp;
			Text = text;
			IsDeleted = isDeleted;
			User = user;
			Channel = channel;
		}

		/// <summary>
		/// Таймстамп сообщения в миллисекундах.
		/// </summary>
		public int Timestamp { get; }

		/// <summary>
		/// Текст сообщения.
		/// </summary>
		public string Text { get; }

		/// <summary>
		/// Признак удалённости сообщения.
		/// </summary>
		public bool IsDeleted { get; }

		/// <summary>
		/// Пользователь, оставивший сообщение.
		/// </summary>
		public User User { get; }

		/// <summary>
		/// Канал, в котором было оставлено сообщение.
		/// </summary>
		public Channel Channel { get; }

		[ContractInvariantMethod]
		private void ObjectInvariant()
		{
			Contract.Invariant(Timestamp > 0);
			Contract.Invariant(!String.IsNullOrEmpty(Text));
			Contract.Invariant(User != null);
			Contract.Invariant(Channel != null);
		}
	}
}
