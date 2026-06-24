using System.Windows;

namespace OptimizationAPP
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            expProcess.IsExpanded = !expProcess.IsExpanded;
        }

        private void btnTemp_Click(object sender, RoutedEventArgs e)
        {
            expProcess.IsExpanded = !expProcess.IsExpanded;
        }

        private void btnDisk_Click(object sender, RoutedEventArgs e)
        {
            expProcess.IsExpanded = !expProcess.IsExpanded;
        }

        private void btnDeepTemp_Click(object sender, RoutedEventArgs e)
        {
            expProcess.IsExpanded = !expProcess.IsExpanded;
        }

        private void btnPrefetch_Click(object sender, RoutedEventArgs e)
        {
            expProcess.IsExpanded = !expProcess.IsExpanded;
        }

        private void btnEvent_Click(object sender, RoutedEventArgs e)
        {
            expProcess.IsExpanded = !expProcess.IsExpanded;
        }

        private void btnAdvDisk_CLick(object sender, RoutedEventArgs e)
        {
            expProcess.IsExpanded = !expProcess.IsExpanded;
        }
    }
}