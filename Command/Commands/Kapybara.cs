using System;
using System.Collections.Generic;
using System.Text;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace g1hgm_bot.Command.Commands
{
    class Kapybara : Command
    {
        public override string[] Nemes { get; set; } = new string[] { "Капибар", "капибар", "Водосвин", "водосвин" };

        public override async void Execute(Message message, TelegramBotClient client)
        {
            Random rnd = new Random();
            int r = rnd.Next(468, 508);
            await client.SendTextMessageAsync(message.Chat.Id, "https://vk.com/photo-202797035_457239" + r, replyToMessageId: message.MessageId);
        }
    }
}
