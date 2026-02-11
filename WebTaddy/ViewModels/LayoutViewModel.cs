using System;
using System.Collections.Generic;
using System.Text;
using WebTaddy.Stores;

namespace WebTaddy.ViewModels
{
    class LayoutViewModel : ViewModelBase
    {
        /// <summary>
        /// Used to manage the app's navigation state.
        /// </summary>
        private readonly NavigationStore _navigationStore;


        /// <summary>
        /// The Layout's current content view-model.
        /// </summary>
        public ViewModelBase? CurrentContentViewModel =>
            _navigationStore.CurrentLayoutContentViewModel;



        public LayoutViewModel(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;

            _navigationStore.CurrentLayoutContentViewModelChanged +=
                OnCurrentContentViewModelChanged;
        }


        /// <summary>
        /// Handles the navigation store's layout content
        /// view-model change event.
        /// </summary>
        private void OnCurrentContentViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentContentViewModel));
        }
    }
}
