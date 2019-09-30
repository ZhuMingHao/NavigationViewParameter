using System;
using System.Runtime.CompilerServices;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace NavigationViewParameter.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public RelayCommand ViewLoadedCommand { get; private set; }
        public MainViewModel()
        {
            ViewLoadedCommand = new RelayCommand(SaveEntry);
        }

       
        private void SaveEntry()
        {
            // save entry.
        }
    }
}
