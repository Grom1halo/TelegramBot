using System;
using System.Collections.Generic;
using System.Text;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace g1hgm_bot.Command.Commands
{
    class SendDP : Command
    {
        public override string[] Nemes { get; set; } = new string[] { "Скинь хуй", "скинь хуй", "ньюдсы", "Ньюдсы" };

        public override async void Execute(Message message, TelegramBotClient client)
        {
            await client.SendTextMessageAsync(message.Chat.Id, "Так, попроси это у меня в секретном чате, а не у моего бота, блять", replyToMessageId: message.MessageId);
        }
    }
}
