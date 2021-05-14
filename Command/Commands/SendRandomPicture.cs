using System;
using System.Collections.Generic;
using System.Text;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace g1hgm_bot.Command.Commands
{
    public class SendRandomPicture : Command
    {
        public override string[] Nemes { get; set; } = new string[] { "Еще", "еще", "Мил", "мил", "Жив", "жив"};

        public override async void Execute(Message message, TelegramBotClient client)
        {
            Random rnd = new Random();
            int r = rnd.Next(9019, 9135);
            if (r == 134)
            {
                r = rnd.Next(9019, 9099);
            }
            await client.SendTextMessageAsync(message.Chat.Id, "https://vk.com/sta1ble_cat?z=photo-202797035_45723" + r + "%2Falbum-202797035_00%2Frev", replyToMessageId: message.MessageId);
        }
    }
}
