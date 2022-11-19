using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFTelegramBot
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Bot client;
        public MainWindow()
        {
            InitializeComponent();

            //client = new Bot(this);
        }


        //private void Button1_Click(object sender, RoutedEventArgs e)
        //{
        //    ////client = new Bot(this);
        //    //if (client.BotMessageLog.Count != 0)
        //    //{
        //    //    if (Users.Items.Count == 0)
        //    //    {
        //    //        Users.Items.Add(new TabItem
        //    //        {
        //    //            Header = new TextBlock { Text = $"{client.BotMessageLog.Last().Id}" },
        //    //            Content = //Users.Items[1]
        //    //            client.BotMessageLog.Last().Id
        //    //        });
        //    //    }
        //    //    for (int i = 0; i < Users.Items.Count; i++)
        //    //    {
        //    //        //if (Users.FindName(client.BotMessageLog.Last().Id.ToString()) == null)
        //    //        //{
        //    //        bool helper = false;
                    
        //    //        if(Users.Items[i] == client.BotMessageLog.Last().Id.ToString())
        //    //        {
        //    //            continue;
        //    //        }
        //    //        if (Users.Items[i] != client.BotMessageLog.Last().Id.ToString() && helper == false)
        //    //        Users.Items.Add(new TabItem
        //    //        {
        //    //            Header = new TextBlock { Text = $"{client.BotMessageLog.Last().Id}" },
        //    //            Content = Users.Items[1]
        //    //            //client.BotMessageLog.Last().Message
        //    //        }) ;
        //    //        //}
        //    //    }
        //    //    //if(client.BotMessageLog.Last().Id)
        //    //    //Users.Items.Add(new TabItem
        //    //    //{
        //    //    //    Header = new TextBlock { Text = $"{client.BotMessageLog.Last().Id}" },
        //    //    //    Content = client.BotMessageLog.Last().Message 
        //    //    //});

        //    //} 
        //    logList.ItemsSource = client.BotMessageLog;
        //}

        //private void CheckUser()
        //{

        //}


        //private void Button2_Click(object sender, RoutedEventArgs e)
        //{
        //    client.cts.Cancel();
        //}

        //private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{

        //}
    }
}


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows;
//using System.Windows.Controls;
//using System.Windows.Data;
//using System.Windows.Documents;
//using System.Windows.Input;
//using System.Windows.Media;
//using System.Windows.Media.Imaging;
//using System.Windows.Navigation;
//using System.Windows.Shapes;

//namespace Example_1042
//{
//    /// <summary>
//    /// Логика взаимодействия для MainWindow.xaml
//    /// </summary>
//    public partial class MainWindow : Window
//    {
//        TelegramMessageClient client;

//        public MainWindow()
//        {
//            InitializeComponent();

//            client = new TelegramMessageClient(this);

//            logList.ItemsSource = client.BotMessageLog;
//        }

//        private void btnMsgSendClick(object sender, RoutedEventArgs e)
//        {
//            client.SendMessage(txtMsgSend.Text, TargetSend.Text);
//        }
//    }
//}
