using System;
using System.Collections.Generic;
using System.Text;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace g1hgm_bot.Command.Commands
{
    public class GetMyIdCommand : Command
    {
        public override string[] Nemes { get; set; } = new string[] { "ID", "Id", "id" };

        public override async void Execute(Message message, TelegramBotClient client)
        {
            await client.SendTextMessageAsync(message.Chat.Id, $"ваш телеграм ID: {message.From.Id}", replyToMessageId: message.MessageId);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"[Log]: id - {message.From.Id}");
        }
    }
}
