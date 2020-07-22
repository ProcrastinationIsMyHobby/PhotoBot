using PhotoBot.Commands;
using System.Collections.Generic;
using System.Configuration;
using Telegram.Bot;

namespace PhotoBot
{
    public static class Bot
    {
        private static TelegramBotClient client;

        private static List<Command> commandsList;
        public static IReadOnlyList<Command> Commands => commandsList.AsReadOnly();

        public static TelegramBotClient Get()
        {
            if(client != null)
            {
                return client;
            }

            commandsList = new List<Command>();
            commandsList.Add(new SomeCommand());
            //TODO: Add more commands

            client = new TelegramBotClient(ConfigurationManager.AppSettings.Get("token"));
            return client;

        }

    }
}
