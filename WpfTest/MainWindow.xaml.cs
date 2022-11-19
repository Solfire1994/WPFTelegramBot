using System;
using System.Collections.ObjectModel;
using System.Windows;

namespace WpfTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        
        public MainWindow()
        {
            
            InitializeComponent();
            

            //DataContext = this;

        }

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    //Random random = new Random();
        //    ////ObservableCollection<int> collect = new ObservableCollection<int>();
        //    //for (int i = 0; i < 10; i++)
        //    //{
        //    //    collect.Add(random.Next(0, 10));
        //    //}



        //}
    }

    public class Message
    {
        public Message(string autor, DateTime date, string text)
        {
            Autor = autor;
            DateTime = date;
            Text = text;
        }

        public string Autor { get; set; }
        public DateTime DateTime { get; set; }
        public string Text { get; set; }
    }

}
