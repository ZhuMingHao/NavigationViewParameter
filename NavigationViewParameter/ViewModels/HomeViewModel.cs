using System;

using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace NavigationViewParameter.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        public RelayCommand ViewLoadedCommand { get; private set; }
        public HomeViewModel()
        {
            ViewLoadedCommand = new RelayCommand(SaveEntry);
        }   
        private void SaveEntry()
        {
            // save entry.
        }
    }
}
