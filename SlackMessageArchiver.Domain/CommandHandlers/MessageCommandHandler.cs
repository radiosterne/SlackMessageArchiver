using System;
using InfrastructureInterfaces;
using InfrastructureInterfaces.Entities;
using InfrastructureInterfaces.Exceptions;
using Polly;
using SlackMessageArchiver.Domain.Services;
using SlackMessageArchiver.Interfaces;
using SlackMessageArchiver.Interfaces.CommandHandlers;
using SlackMessageArchiver.Interfaces.Commands;

namespace SlackMessageArchiver.Domain.CommandHandlers
{
	internal sealed class MessageCommandHandler : IMessageCommandHandler
	{
		private readonly IUserAccessorService _userService;
		private readonly IChannelAccessorService _channelService;
		private readonly IMessageGeneratorService _messageGeneratorService;

		private static readonly Policy HandlingPolicy;

		public ICommandHandlingResult Handle(CreateOrUpdateMessageCommand command)
		{
			try
			{
				return HandlingPolicy.Execute(() => HandleInternal(command));
			}
			catch (Exception ex)
			{
				return CommandHandlingResult.Fail($"Error creating or updating message: {ex.Message}");
			}
		}

		private ICommandHandlingResult HandleInternal(CreateOrUpdateMessageCommand command)
		{
			if(String.IsNullOrEmpty(command.UserId))
			{
				//todo log
				return ValidationFail(nameof(command.UserId));
			}

			if (String.IsNullOrEmpty(command.ChannelName))
			{
				return ValidationFail(nameof(command.ChannelName));
			}

			var user = _userService.Get(command.UserId);
			var channel = _channelService.Get(command.ChannelName);

			var message = new Message(command.Timestamp, command.Text, false, user, channel);

			_messageGeneratorService.CreateOrUpdate(message);

			return CommandHandlingResult.Success();
		}

		private static ICommandHandlingResult ValidationFail(string argumentName)
		{
			return CommandHandlingResult.Fail($"Incorrect value for {argumentName}.");
		}

		static MessageCommandHandler()
		{
			//todo to consul
			var objectNotFoundPolicy = Policy.Handle<ObjectNotFoundException>().Retry(5);
			HandlingPolicy = objectNotFoundPolicy;
		}

		internal MessageCommandHandler(IUserAccessorService userService, IChannelAccessorService channelService, IMessageGeneratorService messageGeneratorService)
		{
			_userService = userService;
			_channelService = channelService;
			_messageGeneratorService = messageGeneratorService;
		}
	}
}
