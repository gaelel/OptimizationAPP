using System.Windows;
using System.Windows.Controls;
using OptimizationAPP;
using OptimizationAPP.Pages;
using OptimizationAPP.Utilitys;

namespace OptimizationAPP
{
    public partial class MainWindow : Window
    {
        private bool _isAdmin;
        public MainWindow()
        {
            InitializeComponent();
            _isAdmin = PermisosHelper.IsAdmin();
            ConfigurarAccesoModulos();
            menuFrame.Navigate(new StartPage());
        }

        private void ConfigurarAccesoModulos()
        {
            btnDeepTempFiles.IsEnabled = _isAdmin;
            btnPrefetch.IsEnabled = _isAdmin;
            btnEventViewer.IsEnabled = _isAdmin;
            btnAdvancedDisk.IsEnabled = _isAdmin;

            if (!_isAdmin)
            {
                string message = "Algunos módulos requieren privilegios de administrador. Por favor, reinicie la aplicación como administrador para acceder a todas las funciones.";
                btnDeepTempFiles.ToolTip = message;
                btnPrefetch.ToolTip = message;
                btnEventViewer.ToolTip = message;
                btnAdvancedDisk.ToolTip = message;
            }
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            menuFrame.Navigate(new StartPage());
        }

        private void btnTemp_Click(object sender, RoutedEventArgs e)
        {
            menuFrame.Navigate(new TempFilesPage());
        }

        private void btnDisk_Click(object sender, RoutedEventArgs e)
        {
            menuFrame.Navigate(new DiskPage());
        }

        private void btnDeepTemp_Click(object sender, RoutedEventArgs e)
        {
            menuFrame.Navigate(new Pages.DeepTempPage());
        }

        private void btnPrefetch_Click(object sender, RoutedEventArgs e)
        {
            menuFrame.Navigate(new Pages.PrefetchPage());
        }

        private void btnEvent_Click(object sender, RoutedEventArgs e)
        {
            menuFrame.Navigate(new Pages.EventVwrPage());
        }

        private void btnAdvDisk_Click(object sender, RoutedEventArgs e)
        {
            menuFrame.Navigate(new Pages.AdvDiskPage());
        }

        private void btnNvidia_Click(object sender, RoutedEventArgs e)
        {
            menuFrame.Navigate(new NvidiaPage());
        }
    }
}