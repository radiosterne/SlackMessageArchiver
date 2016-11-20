namespace SlackMessageArchiver.Interfaces.Commands
{
	/// <summary>
	/// Команда создания или обновления сообщения.
	/// </summary>
	public sealed class CreateOrUpdateMessageCommand
	{
		public int Timestamp { get; set; }

		/// <summary>
		/// Текст сообщения.
		/// </summary>
		public string Text { get; set; }

		/// <summary>
		/// Признак удалённости сообщения.
		/// </summary>
		public bool IsDeleted { get; set; }

		/// <summary>
		/// Идентификатор пользователя, оставившего сообщение.
		/// </summary>
		public string UserId { get; set; }

		/// <summary>
		/// Идентификатор канала, в котором было оставлено сообщение.
		/// </summary>
		public string ChannelName { get; set; }
	}
}
