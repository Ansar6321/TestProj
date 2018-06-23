using System.Windows;
using Autofac;
using TestProj.Interfaces;
using TestProj.ViewModel;

namespace TestProj
{
    public partial class App : Application
    {
        public static IContainer Container { get; set; }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            ContainerBuilder containerBuilder = new ContainerBuilder();
            #region View
            containerBuilder.RegisterType<MainWindow>().As<IMainWindowView>();
            #endregion
            #region ViewModel
            containerBuilder.RegisterType<MainWindowViewModel>().As<IMainWindowViewModel>();
            #endregion
            Container = containerBuilder.Build();

            var mainViewModel = Container.Resolve<IMainWindowViewModel>();
            this.MainWindow = mainViewModel.View as Window;
            this.MainWindow.Show();
        }
    }
}
