using System;
using System.Collections.Generic;
using System.Text;
using WebTaddy.Services;
using WebTaddy.Stores;
using WebTaddy.ViewModels;

namespace WebTaddy.Utilities
{
    static class ServiceFactory
    {

        public static INavigate CreateNavigationService(string type,
            NavigationStore navigationStore)
        {
            switch (type.ToLower())
            {
                case "layout":
                    return new NavigationService<LayoutViewModel>(
                        navigationStore,
                        () => new LayoutViewModel(navigationStore));
                case "time sheet":
                    return new LayoutNavigationService<TimeSheetViewModel>(
                        navigationStore,
                        () => new TimeSheetViewModel());
                default:
                    throw new ArgumentOutOfRangeException(nameof(type));
            }
        }
    }
}
