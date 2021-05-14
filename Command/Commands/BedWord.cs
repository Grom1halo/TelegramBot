using System;
using System.Collections.Generic;
using System.Text;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace g1hgm_bot.Command.Commands
{
    class BedWord : Command
    {
        public override string[] Nemes { get; set; } = new string[] { "Бля", "Сука", "сука", "бля", "еб", "Еб", "Пизд", "пизд", "Хуй", "хуй"  };

        public override async void Execute(Message message, TelegramBotClient client)
        {
            await client.SendTextMessageAsync(message.Chat.Id, "Не матерись!", replyToMessageId: message.MessageId);
        }
    }
}
