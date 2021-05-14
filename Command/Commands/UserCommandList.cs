using System;
using System.Collections.Generic;
using System.Text;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types;

namespace g1hgm_bot.Command.Commands
{
    class UserCommandList : Command
    {
        public override string[] Nemes { get; set; } = new string[] { "/", "Команд", "/start", "команд" };

        public override async void Execute(Message message, TelegramBotClient client)
        {
            await client.SendTextMessageAsync(message.Chat.Id, "Привет, у меня есть следующие животные: " +
                "Коты, " +
                "Собаки, " +
                "Выбры, " +
                "Овцебыки, " +
                "Волосатые коровы, " +
                "Муравьеды, " +
                "Крысы, " +
                "Опосумы, " +
                "Капибары. " +
                "Позднее заведу: " +
                "Морских свинок, " +
                "Птиц, " +
                "Мышей, " +
                "Ежей, " +
                "Зайцев и кроликов. " +
                "Всем удачи я пошел спать");
        }
    }

    class AdminMessage : Command
    {
        public override string[] Nemes { get; set; } = new string[] { "!админ", "!Админ" };

        public override async void Execute(Message message, TelegramBotClient client)
        {
            await client.SendTextMessageAsync(message.Chat.Id, "Ща, я ему напишу");
            
            await client.SendTextMessageAsync("1108234174", $" тебя тут @{message.From.Username} зовет");
        }
    }
}
