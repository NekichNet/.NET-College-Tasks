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

namespace _25_10
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly object _locker = new object();
        private int _count = 0;
        private List<int> _list = new List<int>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void RaceBtn_Click(object sender, RoutedEventArgs e)
        {
            _count = 0;
            Thread first = new Thread(CounterThread);
            Thread second = new Thread(CounterThread);
            first.Start();
            second.Start();
            first.Join();
            second.Join();
            OutputText.Text = _count.ToString();
        }

        private void CounterThread()
        {
            for (int i = 0; i < 100000000; i++)
            {
                _count++;
            }
        }

        private void LockBtn_Click(object sender, RoutedEventArgs e)
        {
            _count = 0;
            Thread first = new Thread(CounterWithLockThread);
            Thread second = new Thread(CounterWithLockThread);
            first.Start();
            second.Start();
            first.Join();
            second.Join();
            OutputText.Text = _count.ToString();
        }

        private void CounterWithLockThread ()
        {
            for (int i = 0; i < 100000000; i++)
            {
                lock (_locker)
                {
                    _count++;
                }
            }
        }

        private void TimeoutBtn_Click(object sender, RoutedEventArgs e)
        {
            _count = 0;
            Thread first = new Thread(CounterWithTimeoutThread);
            Thread second = new Thread(CounterWithTimeoutThread);
            first.Start();
            second.Start();
            first.Join();
            second.Join();
            OutputText.Text = _count.ToString();
        }

        private void CounterWithTimeoutThread()
        {
            for (int i = 0; i < 100000000; i++)
            {
                while (true)
                {
                    if (Monitor.TryEnter(_locker))
                    {
                        try
                        {
                            _count++;
                        }
                        finally
                        {
                            Monitor.Exit(_locker);
                        }
                        break;
                    }
                    else
                    {
                        Thread.Sleep(5);
                    }
                }
            }
        }

        private void PulseBtn_Click(object sender, RoutedEventArgs e)
        {
            Thread first = new Thread(GeneratorThread);
            Thread second = new Thread(WorkerThread);
            first.Start();
            second.Start();
        }

        private void GeneratorThread()
        {
            for (int i = 0; i < 10; i++)
            {
                lock (_locker)
                {
                    _list.Add(i);
                    this.Dispatcher.BeginInvoke(DispatcherPriority.Normal,
                        (ThreadStart)delegate ()
                        {
                            for (int i = 0; i < 10; i++)
                            {
                                OutputText.Text = ListToString(_list);
                            }
                        }
                    );
                    Monitor.Pulse(_locker);
                }
                Thread.Sleep(500);
            }
        }

        private void WorkerThread()
        {
            for (int i = 0; i < 10; i++)
            {
                lock (_locker)
                {
                    while (!Monitor.Wait(_locker))
                    {
                        
                    }
                    if (_list.Count > 0)
                    {
                        _list.RemoveAt(0);
                    }
                    else { i++; }
                }
                Thread.Sleep(1000);
            }
        }

        private string ListToString(List<int> list)
        {
            string result = string.Empty;
            foreach (int i in list)
            {
                result += i.ToString() + " ";
            }
            return result.TrimEnd();
        }
    }
}