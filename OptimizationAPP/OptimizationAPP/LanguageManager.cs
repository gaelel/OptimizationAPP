using System.Globalization;
using System.Resources;

namespace OptimizationAPP.Utilitys
{
    public static class LanguageManager
    {
        private static ResourceManager _resourceManager;

        public static void SetLanguage(string languageCode)
        {
            _resourceManager = new ResourceManager($"OptimizationAPP.Strings.{languageCode}", typeof(LanguageManager).Assembly);

            Properties.Settings.Default.Language = languageCode;
            Properties.Settings.Default.Save();
        }

        public static string Get(string key)
        {
            if (_resourceManager == null) return key;
            return _resourceManager.GetString(key) ?? key;
        }

        public static bool HasSavedLanguage()
        {
            return !string.IsNullOrEmpty(Properties.Settings.Default.Language);
        }

        public static void LoadSavedLanguage()
        {
            SetLanguage(Properties.Settings.Default.Language);
        }
    }
}
