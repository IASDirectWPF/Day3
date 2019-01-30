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
using System.Windows.Shapes;

namespace NW.WPF
{
    /// <summary>
    /// Interaction logic for Module08RoutedEvent.xaml
    /// </summary>
    public partial class Module08RoutedEvent : Window
    {
        public Module08RoutedEvent()
        {
            InitializeComponent();
        }

        private int eventCounter = 0;
        private void Window_MouseUp(object sender, MouseButtonEventArgs e)
        {
            eventCounter++;
            string message = String.Format(
                "#{0}:\r\nSender: {1}\r\nSource: {2}\r\nOriginal Source: {3}", 
                eventCounter, sender, e.Source, e.OriginalSource);
            ListBoxMessages.Items.Add(message);
            //e.Handled = true;
        }

        private void Window_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
