using Autofac;
using MHRArmorBuilder.Startup;
using MHRArmorBuilder.ViewModels;
using MHRArmorBuilder.Views;
using System.Windows;

namespace MHRArmorBuilder
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            var bootstrapper = new Bootstrapper();
            var container = bootstrapper.Bootstrap();

            using var scope = container.BeginLifetimeScope();

            var mainWindow = scope.Resolve<MainWindow>();
            mainWindow.DataContext = scope.Resolve<MainViewModel>();

            mainWindow.Show();
        }
    }
}
