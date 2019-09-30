using System;

using NavigationViewParameter.ViewModels;

using Windows.UI.Xaml.Controls;

namespace NavigationViewParameter.Views
{
    public sealed partial class HomePage : Page
    {
        private HomeViewModel ViewModel
        {
            get { return ViewModelLocator.Current.HomeViewModel; }
        }

        public HomePage()
        {
            InitializeComponent();
        }
    }
}
