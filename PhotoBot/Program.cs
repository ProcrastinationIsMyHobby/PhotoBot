using System.Threading.Tasks;


namespace PhotoBot
{
    class Program
    {
        static void Main(string[] args)
        {
            Run().Wait();
        }

        static async Task Run()
        {
            int offset = 0;

            var client = Bot.Get();

            var commands = Bot.Commands;

            while (true)
            {
                var updates = await client.GetUpdatesAsync(offset);
                
                foreach (var update in updates)
                {
                    var message = update.Message;

                    foreach (var command in commands)
                    {
                        if (command.Contains(message.Text))
                        {
                            command.Execute(message, client);
                            break;
                        }
                    }
                    offset = update.Id + 1;
                }
            }
        }
    }
}
