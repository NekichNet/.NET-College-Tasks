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

        private void NoteBtn_Click(object sender, RoutedEventArgs e)
        {
            new Thread(OpenNotepad).Start();
        }

        private void OpenNotepad()
        {
            Process NotepadProcess = Process.Start(@"C:\Windows\system32\notepad.exe");
            Thread.Sleep(3000);
            NotepadProcess.Kill();
        }

        private void UpdateBtn_Click(object sender, RoutedEventArgs e)
        {
            new Thread(BackgroundThread).Start();
        }

        private void BackgroundThread()
        {
            this.Dispatcher.BeginInvoke(DispatcherPriority.Normal,
                (ThreadStart) delegate ()
                {
                    for (int i = 0; i < 10; i++)
                    {
                        OutputText.Text = (i).ToString();
                        Thread.Sleep(500);
                    }
                }
            );
        }

        private void CmdBtn_Click(object sender, RoutedEventArgs e)
        {
            new Thread(OpenCmd).Start();
        }

        private void OpenCmd()
        {
            Process CmdProcess = new Process();
            CmdProcess.StartInfo.FileName = @"C:\Windows\system32\cmd.exe";
            CmdProcess.StartInfo.UseShellExecute = false;
            CmdProcess.StartInfo.RedirectStandardInput = true;
            CmdProcess.StartInfo.RedirectStandardOutput = true;
            CmdProcess.Start();

            CmdProcess.StandardInput.WriteLine("dir");
            String output = CmdProcess.StandardOutput.ReadToEnd();

            CmdProcess.WaitForExit(); // you need to close the console window to continue

            this.Dispatcher.BeginInvoke(DispatcherPriority.Normal,
                (ThreadStart)delegate ()
                {
                    OutputText.Text = output;
                }
            );
        }
    }
}