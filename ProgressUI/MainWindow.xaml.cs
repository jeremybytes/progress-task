using System.Windows;
using System.Linq;
using System.Threading.Tasks;
using System;
using System.Threading;

namespace ProgressUI
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BadProgressButton_Click(object sender, RoutedEventArgs e)
        {
            var task = Task.Run(() => StartLongProcess(new Progress<string>(UpdateProgress)));
        }

        private void GoodProgressButton_Click(object sender, RoutedEventArgs e)
        {
            var progress = new Progress<string>(UpdateProgress);
            var task = Task.Run(() => StartLongProcess(progress));
        }

        private void StartLongProcess(IProgress<string> progress)
        {
            for(int i = 0; i <= 50; i++)
            {
                progress.Report(i.ToString());
                Thread.Sleep(100);
            }
        }

        private void UpdateProgress(string message)
        {
            OutputTextBlock.Text = message;
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            OutputTextBlock.Text = "";
        }
    }
}
