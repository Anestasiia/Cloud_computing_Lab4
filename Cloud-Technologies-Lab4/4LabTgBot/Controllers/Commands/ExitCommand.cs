using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;

namespace _4LabTgBot.Controllers.Commands
{
    public class ExitCommand : ICommand
    {
        public TelegramBotClient Client => Bot.GetTelegramBot().Result;

        public string Name => "Вийти";

        public async Task Execute(Update update)
        {
            long chatId = update.Message.Chat.Id;


            await Client.SendTextMessageAsync(
                chatId,
                text: "Виконую вихід",
                replyMarkup: new ReplyKeyboardRemove());

        }
    }
}
