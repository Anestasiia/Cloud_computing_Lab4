using Telegram.Bot;

    namespace _4LabTgBot
    {
        public class Bot
        {
        private static TelegramBotClient? client { get; set; }
            public static async Task<TelegramBotClient> GetTelegramBot()
            {
                if (client != null)
                {
                    return client;
                }
                client = new TelegramBotClient("6709989535:AAFgoIKjlhIIBDh-YuffouNSbmTaSEfq5lA");
                string hook = "cloudtechnologieslab4.azurewebsites.net";
                await client.SetWebhookAsync(hook);
                return client;
            }
        }
    }

