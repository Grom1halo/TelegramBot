using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using g1hgm_bot.Command.Commands;
using Telegram.Bot;
using Telegram.Bot.Args;

namespace g1hgm_bot
{
    class Program
    {
        private static TelegramBotClient client;
        public static List<Command.Command> commands;
        public static List<long> sweetSleepList;
        static void Main(string[] args)
        {
            client = new TelegramBotClient(Config.Token);

            sweetSleepList = new List<long>
            {
                1108234174
            };

            commands = new List<Command.Command>
            {
                new GetMyIdCommand(),
                new SendRandomPicture(),
                new SendDP(),
                new UserCommandList(),
                new BedWord(),
                new AdminMessage(),
                new Ckem(),
                new Ckem2(),
                new Cat(),
                new Dog(),
                new Musk(),
                new Otter(),
                new Mow(),
                new AntEater(),
                new Rat(),
                new Possum(),
                new Anime(),
                new Kapybara(),
                new SweatSleep(),
                new AddSweatSleep()
            };

            client.StartReceiving();
            client.OnMessage += OnMessegeHandler;
            Console.WriteLine("[Log]: Bot started");
            Console.ReadLine();
            client.StopReceiving();
        }

        private static async void OnMessegeHandler(object sender, MessageEventArgs e)
        {
            var message = e.Message;
            if(message.Text != null)
            {
                Console.Write($"[Log]: От: {message.From.FirstName} {message.From.LastName}: {message.Text} - ");
                Console.WriteLine($"<{DateTime.Now}>");

                Random rnd = new Random();
                int rndm = rnd.Next(0, RandomMessageGeniratcion.ReplacementSwitchLength());
                int crutch = 0;

                foreach (var comm in commands)
                {
                    if (comm.Contains(message.Text))
                    {
                        comm.Execute(message, client);
                    }
                    else
                    {
                        crutch++;
                        if (crutch == commands.Count)
                        {
                            await client.SendTextMessageAsync(message.Chat.Id, RandomMessageGeniratcion.WriteRadomMessage(rndm));
                            crutch = 0;
                        }
                    }
                }
            }
        }
    }
}
