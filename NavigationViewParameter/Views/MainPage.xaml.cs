using System;

using NavigationViewParameter.ViewModels;

using Windows.UI.Xaml.Controls;

namespace NavigationViewParameter.Views
{
    public sealed partial class MainPage : Page
    {
        private MainViewModel ViewModel
        {
            get { return ViewModelLocator.Current.MainViewModel; }
        }

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
