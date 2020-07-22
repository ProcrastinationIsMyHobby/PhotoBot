using System;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace PhotoBot.Commands
{
    class SomeCommand : Command
    {
        public override string Name => "Привет";

        public override async void Execute(Message message, TelegramBotClient client)
        {
            var chatId = message.Chat.Id;
            var messageId = message.MessageId;

            //TODO: Command logic -_-

            await client.SendTextMessageAsync(chatId, "Привет, последняя новость, оказывается у Коли мамаша проститутка", replyToMessageId: messageId);
        }
    }
}
