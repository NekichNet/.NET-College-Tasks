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
            OpenNotepadAsync();
        }

        private async Task OpenNotepadAsync()
        {
            Process NotepadProcess = Process.Start(@"C:\Windows\system32\notepad.exe");
            await Task.Delay(3000);
            NotepadProcess.Kill();
        }

        private void UpdateBtn_Click(object sender, RoutedEventArgs e)
        {
            BackgroundThreadAsync();
        }

        private async Task BackgroundThreadAsync()
        {
            this.Dispatcher.BeginInvoke(DispatcherPriority.Normal,
                (ThreadStart)async delegate ()
                {
                    for (int i = 0; i < 10; i++)
                    {
                        OutputText.Text = (i).ToString();
                        await Task.Delay(500);
                    }
                }
            );
        }

        private void CmdBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenCmdAsync();
        }

        private async Task OpenCmdAsync()
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