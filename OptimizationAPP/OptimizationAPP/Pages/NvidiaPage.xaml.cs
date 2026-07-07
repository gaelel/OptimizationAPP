using OptimizationAPP.Utilitys;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace OptimizationAPP.Pages
{
    public partial class NvidiaPage : Page
    {
        public NvidiaPage()
        {
            InitializeComponent();
            LoadTexts();

            if (!PermisosHelper.IsAdmin())
            {
                btnSiguiente.Content = "TERMINAR";
            }
        }

        private void LoadTexts()
        {
            txtTag.Text = LanguageManager.Get("TagNvidia");
            txtTitle.Text = LanguageManager.Get("TituloNvidia");
            txtDesc.Text = LanguageManager.Get("DescNvidia");
            btnSiguiente.Content = LanguageManager.Get("BtnSiguiente");
            btnAnterior.Content = LanguageManager.Get("BtnAnterior");
        }

        private void btnAnterior_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void btnSiguiente_Click(object sender, RoutedEventArgs e)
        {
            if (PermisosHelper.IsAdmin())
            {
                NavigationService.Navigate(new Pages.DeepTempPage());
            }
            else
            {
                Application.Current.Shutdown();
            }
        }
    }
}
