using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinGroceryList.Services;
using XamarinGroceryList.Views;

namespace XamarinGroceryList {
    public partial class App : Application {

        private static INavigationService navigationService;
        private static IDataBaseService database;

        public static INavigationService NavigationService { 
            get { 
                if (navigationService == null) {navigationService = new NavigationService(); ; } 
                return navigationService; 
            } 
        }

        public static IDataBaseService DataBase {
            get {
                if (database == null) { database = new DataBaseService(); ; }
                return database;
            }
        }

        public App() {
            InitializeComponent();
            MainPage = new NavigationPage(new GroceryListPage());
        }

        protected override void OnStart() {}

        protected override void OnSleep() {}

        protected override void OnResume() {}
    }
}
