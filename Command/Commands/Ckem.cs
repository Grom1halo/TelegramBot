using System;
using System.Collections.Generic;
using System.Text;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace g1hgm_bot.Command.Commands
{
    class Ckem : Command
    {
        public override string[] Nemes { get; set; } = new string[] { "ать", "ять", "еть", "ить" };

        public override async void Execute(Message message, TelegramBotClient client)
        {
            await client.SendTextMessageAsync(message.Chat.Id, "С кем?", replyToMessageId: message.MessageId);
        }
    }
    class Ckem2 : Command
    {
        public override string[] Nemes { get; set; } = new string[] { "кем", "Кем"};

        public override async void Execute(Message message, TelegramBotClient client)
        {
            await client.SendTextMessageAsync(message.Chat.Id, "Шаришь", replyToMessageId: message.MessageId);
        }
    }
}
