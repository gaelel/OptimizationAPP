using OptimizationAPP.Utilitys;
using System.Windows.Controls;

namespace OptimizationAPP
{
    public partial class StartPage : Page
    {
        public StartPage()
        {
            InitializeComponent();
            LoadTexts();
        }

        private void LoadTexts()
        {
            txtTag.Text = LanguageManager.Get("TagHome");
            txtTitulo.Text = LanguageManager.Get("TitleHome");
            txtDescription.Text = LanguageManager.Get("DescHome");
            btnSiguiente.Content = LanguageManager.Get("BtnSiguiente");
        }

        private void btnSiguiente_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            NavigationService.Navigate(new TempFilesPage());
        }
    }
}
