using System;
using System.Collections.Generic;
using System.Text;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace g1hgm_bot.Command.Commands
{
    class Musk : Command
    {
        public override string[] Nemes { get; set; } = new string[] { "Овцебык", "овцебык", "Бык", "бык"};

        public override async void Execute(Message message, TelegramBotClient client)
        {
            Random rnd = new Random();
            int r = rnd.Next(169, 173);
            await client.SendTextMessageAsync(message.Chat.Id, "https://vk.com/photo-202797035_457239" + r, replyToMessageId: message.MessageId);
        }
    }
}
