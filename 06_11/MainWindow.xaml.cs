using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace _06_11
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void Counter(ProgressBar progressBar,
            TextBlock textBlock,
            ThreadPriority priority = ThreadPriority.Normal,
            bool dynamicPriority = false,
            bool dispatcher = true)
        {
            Thread.CurrentThread.Priority = priority;
            for (int i = 0; i <= 100; i++)
            {
                if (dispatcher)
                {
                    Dispatcher.Invoke(() => progressBar.Value = i);
                    Dispatcher.Invoke(() => textBlock.Text = i.ToString());
                }
                else
                {
                    progressBar.Value = i;
                    textBlock.Text = i.ToString();
                }
                
                Thread.Sleep(100);
                if (dynamicPriority && i % 25 == 0 && i != 100)
                {
                    Thread.CurrentThread.Priority--;
                }
            }
        }

        public void StandartClick(object sender, RoutedEventArgs e)
        {
            new Thread(() => Counter(FirstBar, FirstText)).Start();
        }

        public void DynamicClick(object sender, RoutedEventArgs e)
        {
            new Thread(() => Counter(SecondBar, SecondText, ThreadPriority.Highest, true)).Start();
        }

        public void ErrorClick(object sender, RoutedEventArgs e)
        {
            new Thread(() => Counter(ThirdBar, ThirdText, dispatcher: false)).Start();
        }

        public void Threesome(object sender, RoutedEventArgs e)
        {
            new Thread(() => Counter(FirstBar, FirstText, priority: ThreadPriority.Lowest)).Start();
            new Thread(() => Counter(SecondBar, SecondText)).Start();
            new Thread(() => Counter(ThirdBar, ThirdText, priority: ThreadPriority.Highest)).Start();
        }
    }
}