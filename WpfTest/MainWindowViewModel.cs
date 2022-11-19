using System;
using System.Collections.ObjectModel;

namespace WpfTest
{
    public class MainWindowViewModel
    {
        private ObservableCollection<Message> _messages = new ObservableCollection<Message>()
        {
            new Message("User 1", DateTime.Now, "Привет мир!"),
        new Message("User 2", DateTime.Now, "Хочу кушать....")
        };

        public ObservableCollection<Message> Messages { get
            {
                return _messages;
            } }
    }
}
