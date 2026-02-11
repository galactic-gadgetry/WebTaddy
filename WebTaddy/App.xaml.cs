using System.Configuration;
using System.Data;
using System.Windows;
using WebTaddy.Services;
using WebTaddy.Stores;
using WebTaddy.Utilities;
using WebTaddy.ViewModels;
using WebTaddy.Views;

namespace WebTaddy
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        private readonly NavigationStore _navigationStore;



        public App()
        {
            _navigationStore = StoreFactory.GetNewNavigationStore();
        }



        protected override void OnStartup(StartupEventArgs e)
        {
            INavigate layoutNavService =
                ServiceFactory.CreateNavigationService(
                    "layout", _navigationStore);
            INavigate timeSheetNavService =
                ServiceFactory.CreateNavigationService(
                    "time sheet", _navigationStore);
            layoutNavService.Navigate();
            timeSheetNavService.Navigate();

            MainViewModel mainViewModel = new(_navigationStore);
            MainWindow = new MainView()
            {
                DataContext = mainViewModel
            };
            MainWindow.Show();

            base.OnStartup(e);
        }
    }

}
