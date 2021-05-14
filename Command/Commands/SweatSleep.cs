using System;
using System.Collections.Generic;
using System.Text;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace g1hgm_bot.Command.Commands
{
    class SweatSleep : Command
    {
        public override string[] Nemes { get; set; } = new string[] {"@@"};

        public override async void Execute(Message message, TelegramBotClient client)
        {
            foreach (var usersId in Program.sweetSleepList)
            {
                await client.SendTextMessageAsync(usersId, "Сладких снов");
            }            
        }
    }

    class AddSweatSleep : Command
    {
        public override string[] Nemes { get; set; } = new string[] { "снов", "Снов" };

        public override async void Execute(Message message, TelegramBotClient client)
        {
            await client.SendTextMessageAsync(message.Chat.Id, "Ждите сладких снов!");


            Program.sweetSleepList.Add(message.Chat.Id);
        }
    }
}
