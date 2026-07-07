using OptimizationAPP.Utilitys;
using System.Windows;

namespace OptimizationAPP
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            if (LanguageManager.HasSavedLanguage())
            {
               LanguageManager.LoadSavedLanguage();
                new MainWindow().Show();
            }
            else
            {
                new LanguageSelectorWindow().Show();
            }
        }
    }
}
