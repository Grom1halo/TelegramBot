using System;
using System.Collections.Generic;
using System.Text;
using Telegram.Bot;
using Telegram.Bot.Types;


namespace g1hgm_bot.Command.Commands
{
    class AntEater : Command
    {
        public override string[] Nemes { get; set; } = new string[] { "Муравьед", "муравьед"};

        public override async void Execute(Message message, TelegramBotClient client)
        {
            Random rnd = new Random();
            int a = rnd.Next(0, 1);
            int r;
            switch (a)
            {
                case 0:
                    r = rnd.Next(309, 331);
                    await client.SendTextMessageAsync(message.Chat.Id, "https://vk.com/photo-202797035_457239" + r, replyToMessageId: message.MessageId);
                    break;
                case 1:
                    r = rnd.Next(398, 412);
                    await client.SendTextMessageAsync(message.Chat.Id, "https://vk.com/photo-202797035_457239" + r, replyToMessageId: message.MessageId);
                    break;
            }            
        }
    }
}
