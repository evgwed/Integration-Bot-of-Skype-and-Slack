using SkypeBot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SkypeBotConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"Бот для интеграции Skype и Slack
Для запуска программы введите команду start.
Перейдите в запущенный Skype клиент и разрешите доступ программе. 
Бот успешно запущен, теперь каждое сообщение из skype транслируется в slack.
Для завершения работы введите exit.
            ");
            string msg = String.Empty;
            while (msg != "exit") {
                switch (msg)
                {
                    case "start":
                        Thread myThread = new Thread(SkypeManager.AttachSkype);
                        myThread.Start();
                        break;
                    case "tm":
                        SkypeManager.SendMessage("test message");
                        break;
                }
                msg = Console.ReadLine();
            }
        }

    }
}
