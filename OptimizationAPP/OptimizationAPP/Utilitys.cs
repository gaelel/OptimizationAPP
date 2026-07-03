using System.Diagnostics;
using System.Security.Principal;
using System.Windows;

namespace OptimizationAPP.Utilitys
{
    public static class PermisosHelper
    {
        public static bool IsAdmin()
        {
            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(identity);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }

        public static void RestartAsAdmin()
        {
            var startInfo = new ProcessStartInfo
            {
                FileName = Process.GetCurrentProcess().MainModule.FileName,
                UseShellExecute = true,
                Verb = "runas"
            };

            try
            {
                Process.Start(startInfo);
                Application.Current.Shutdown();
            }
            catch (System.ComponentModel.Win32Exception)
            {
                // User canceled the UAC prompt
            }
        }
    }
}
