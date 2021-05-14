using System;
using System.Collections.Generic;
using System.Text;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace g1hgm_bot.Command
{
    public abstract class Command
    {
        public abstract string[] Nemes { get; set; }

        public abstract void Execute(Message message, TelegramBotClient client);

        public bool Contains(string messege)
        {
            foreach(var mess in Nemes)
            {
                if (messege.Contains(mess))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
