using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinGroceryList.Services;
using XamarinGroceryList.Views;

namespace XamarinGroceryList {
    public partial class App : Application {

        private static INavigationService navigationService;
        public static INavigationService NavigationService {
            get { return navigationService; }
        }

        public App() {
            InitializeComponent();
            MainPage = new NavigationPage(new GroceryListPage());
            navigationService = new NavigationService();
        }

        protected override void OnStart() { }

        protected override void OnSleep() {}

        protected override void OnResume() {}
    }
}
