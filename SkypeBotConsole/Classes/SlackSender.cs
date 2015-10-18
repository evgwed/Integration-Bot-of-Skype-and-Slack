using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkypeBot
{
    static class SlackSender
    {
        private static string _SlackUrlWithAccessToken = String.Empty;
        private static string _SlackWebHookName = String.Empty;
        private static string _SlackChannelName = String.Empty;
        static SlackSender(){
            _SlackUrlWithAccessToken = ConfigurationSettings.AppSettings.GetValues("SlackUrlWithAccessToken").ToString();
            _SlackWebHookName = ConfigurationSettings.AppSettings.GetValues("SlackWebHookName").ToString();
            _SlackChannelName = ConfigurationSettings.AppSettings.GetValues("SlackChannelName").ToString();
        }
        public static void SendMessage(string messageText) {

            SlackClient client = new SlackClient(_SlackUrlWithAccessToken);

            client.PostMessage(username: _SlackWebHookName,
                        text: messageText,
                        channel: _SlackChannelName); 
        }

    }
}
