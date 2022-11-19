
using Telegram.Bot.Types;

namespace WPFTelegramBot
{
    class MessageLog
    {
        public long Id { get; set; }
        public string Time { get; set; }
        public string FirstName { get; set; }
        public Update Update { get; set; }
        public MessageLog(string Time, Update Update)
        {
            this.Time = Time;
            Id = Update.Message.Chat.Id;
            FirstName = Update.Message.Chat.FirstName;
            this.Update = Update;
        }
    }
}