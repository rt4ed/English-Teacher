using Microsoft.Extensions.Configuration;
using Telegram.Bot;

namespace TeacherEnglish
{
    public class TelegramBot
    {
        private readonly IConfiguration _configuration;
        private TelegramBotClient _botClient;
        public TelegramBot(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public TelegramBotClient GetBot()
        {
            if (_botClient != null)
            {
                return _botClient;
            }

            var telegramBot = new TelegramBotClient(_configuration["Token"]);

            return telegramBot;
        }

        async Task Update(ITelegramBotClient botClient, Update update, CancellationToken token)
        {
            var user = new TeacherEnglish.Entities.User();
            var message = update.Message;
            if (message != null)
            {
                if (message.Text.ToLower().Contains("start"))
                {
                    for (int i = 0; i < 5; i++)
                        await botClient.SendTextMessageAsync();
                }
            }
        }


    }
}
