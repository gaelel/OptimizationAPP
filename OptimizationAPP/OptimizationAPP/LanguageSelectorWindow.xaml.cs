using OptimizationAPP.Utilitys;
using System.Windows;

namespace OptimizationAPP
{
    public partial class LanguageSelectorWindow : Window
    {
        public LanguageSelectorWindow()
        {
            InitializeComponent();
        }

        private void btnSpanish_Click(object sender, RoutedEventArgs e)
        {
            LanguageManager.SetLanguage("es-ES");
            AbrirMainWindow();
        }

        private void btnEnglish_Click(object sender, RoutedEventArgs e)
        {
            LanguageManager.SetLanguage("en-US");
            AbrirMainWindow();
        }

        private void AbrirMainWindow()
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
